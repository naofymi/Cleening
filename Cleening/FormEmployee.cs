using System;
using System.Windows.Forms;

namespace Cleening
{
    public partial class FormEmployee : Form
    {
        private int selectedId = -1;
        private bool isLoading = false;

        public FormEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRequest formRequest = new FormRequest();
            formRequest.ShowDialog();
            LoadRequests();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
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
            dataGridView1.Columns.Add("Status", "Статус");
            dataGridView1.Columns.Add("Rating", "Оценка");


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
                    req.Status,
                    req.Rating > 0 ? req.Rating.ToString() : ""
                );
            }

            button2.Enabled = false;
            isLoading = false;
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            LoadRequests();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Выберите заявку!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormRating formRating = new FormRating(selectedId);
            formRating.ShowDialog();
            LoadRequests();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (isLoading) return;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                string status = dataGridView1.SelectedRows[0].Cells["Status"].Value?.ToString();

                button2.Enabled = (status == "Выполнено");
            }
            else
            {
                button2.Enabled = false;
            }
        }
    }
}