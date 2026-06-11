using System;
using System.Windows.Forms;

namespace Cleening
{
    public partial class FormRating : Form
    {
        private int requestId;

        public FormRating(int id)
        {
            InitializeComponent();
            requestId = id;
        }

        private void FormRating_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int rating = 0;

            if (radioButton1.Checked) rating = 1;
            else if (radioButton2.Checked) rating = 2;
            else if (radioButton3.Checked) rating = 3;
            else if (radioButton4.Checked) rating = 4;
            else if (radioButton5.Checked) rating = 5;

            if (rating == 0)
            {
                MessageBox.Show("Поставьте оценку!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Database.UpdateRating(requestId, rating, txtFeedback.Text);
            MessageBox.Show("Оценка сохранена!", "Успех",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void txtFeedback_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}