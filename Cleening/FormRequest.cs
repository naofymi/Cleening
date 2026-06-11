using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cleening
{
    public partial class FormRequest : Form
    {
        public FormRequest()
        {
            InitializeComponent();
        }

        private void FormRequest_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string services = "";
            for (int i = 0; i < clbServices.CheckedItems.Count; i++)
            {
                services += clbServices.CheckedItems[i].ToString() + ", ";
            }
            services = services.TrimEnd(',', ' ');
            if (string.IsNullOrWhiteSpace(services))
            {
                MessageBox.Show("Выберите хотя бы одну услугу!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Введите ФИО!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return;
            }
            string[] nameParts = txtFullName.Text.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (nameParts.Length < 2)
            {
                MessageBox.Show("Введите полное ФИО!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return;
            }
            foreach (string part in nameParts)
            {
                if (part.Length < 2)
                {
                    MessageBox.Show("Введите ваше имя, фамилию и отчество(при наличии)!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFullName.Focus();
                    return;
                }
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Введите телефон!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }
            string phone = txtPhone.Text.Trim().Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "");
            if (!phone.StartsWith("8") && !phone.StartsWith("+7") && !phone.StartsWith("7"))
            {
                MessageBox.Show("Телефон должен начинаться с 8, +7 или 7!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }
            string phoneDigits = phone.StartsWith("+") ? phone.Substring(1) : phone;
            if (!phoneDigits.All(char.IsDigit))
            {
                MessageBox.Show("Телефон должен содержать только цифры!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }
            if (phoneDigits.Length < 10 || phoneDigits.Length > 11)
            {
                MessageBox.Show("Телефон должен содержать 11 цифр!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }
            if (cmbOffice.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cmbOffice.Text))
            {
                MessageBox.Show("Выберите адрес офиса!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbOffice.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtRooms.Text))
            {
                MessageBox.Show("Введите номера кабинетов!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRooms.Focus();
                return;
            }
            if (dtpSchedule.Value < DateTime.Now)
            {
                MessageBox.Show("Нельзя заказать клининг в прошлое! У нас пока нет таких технологий", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpSchedule.Focus();
                return;
            }
            try
            {
                Database.AddRequest(
                    txtFullName.Text.Trim(),
                    phone,
                    cmbOffice.Text,
                    txtRooms.Text.Trim(),
                    services,
                    dtpSchedule.Value.ToString("dd.MM.yyyy HH:mm"),
                    txtComment.Text
                );

                MessageBox.Show("Заявка успешно создана!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFullName.Clear();
                txtPhone.Clear();
                cmbOffice.SelectedIndex = -1;
                txtRooms.Clear();
                clbServices.ClearSelected();
                txtComment.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtComment_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbOffice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clbServices_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpSchedule_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
