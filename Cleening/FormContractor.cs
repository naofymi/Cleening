using System;
using System.Windows.Forms;

namespace Cleening
{
    public partial class FormContractor : Form
    {
        private int selectedId = -1;
        private bool isLoading = false;

        public FormContractor()
        {
            InitializeComponent();
        }

        private void FormContractor_Load(object sender, EventArgs e)
        {
            LoadRequests();
        }

        private void LoadRequests()
        {
            isLoading = true;
            var requests = Database.GetAllRequests();

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Id", "ID");
            dataGridView1.Columns.Add("FullName", "ФИО");
            dataGridView1.Columns.Add("Phone", "Телефон");
            dataGridView1.Columns.Add("Office", "Офис");
            dataGridView1.Columns.Add("Rooms", "Кабинеты");
            dataGridView1.Columns.Add("Services", "Услуги");
            dataGridView1.Columns.Add("ScheduledAt", "Дата");
            dataGridView1.Columns.Add("Comment", "Комментарий");
            dataGridView1.Columns.Add("Status", "Статус");
            dataGridView1.Columns.Add("Rating", "Оценка");
            dataGridView1.Columns.Add("Feedback", "Отзыв");


            foreach (var req in requests)
            {
                dataGridView1.Rows.Add(
                    req.Id,
                    req.FullName,
                    req.Phone,
                    req.Office,
                    req.Rooms,
                    req.Services,
                    req.ScheduledAt,
                    req.Comment,
                    req.Status,
                    req.Rating > 0 ? req.Rating.ToString() : "",
                    req.Feedback
                );
            }

            button1.Enabled = false;
            isLoading = false;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (isLoading) return;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                string status = dataGridView1.SelectedRows[0].Cells["Status"].Value?.ToString();

                button1.Enabled = (status == "В работе");
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Выберите заявку!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Отметить заявку как выполненную?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Database.UpdateStatus(selectedId, "Выполнено");
                MessageBox.Show("Заявка отмечена как выполненная!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRequests();
            }
        }
    }
}