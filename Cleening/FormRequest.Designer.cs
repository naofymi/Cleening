namespace Cleening
{
    partial class FormRequest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbOffice = new System.Windows.Forms.ComboBox();
            this.txtRooms = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.clbServices = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpSchedule = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Новая заявка на уборку";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ФИО";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(15, 53);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(281, 20);
            this.txtFullName.TabIndex = 2;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(15, 112);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(281, 20);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Телефон";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Адрес офиса";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmbOffice
            // 
            this.cmbOffice.FormattingEnabled = true;
            this.cmbOffice.Items.AddRange(new object[] {
            "БЦ \"Golf Palace\", ул. Харьковская д., 75к1",
            "БЦ \"Магелан\", ул. 50 лет Октября, д., 14"});
            this.cmbOffice.Location = new System.Drawing.Point(15, 185);
            this.cmbOffice.Name = "cmbOffice";
            this.cmbOffice.Size = new System.Drawing.Size(281, 21);
            this.cmbOffice.TabIndex = 6;
            this.cmbOffice.SelectedIndexChanged += new System.EventHandler(this.cmbOffice_SelectedIndexChanged);
            // 
            // txtRooms
            // 
            this.txtRooms.Location = new System.Drawing.Point(15, 255);
            this.txtRooms.Name = "txtRooms";
            this.txtRooms.Size = new System.Drawing.Size(281, 20);
            this.txtRooms.TabIndex = 8;
            this.txtRooms.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Кабинеты";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(15, 311);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(164, 23);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Отправить заявку";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Услуги";
            // 
            // clbServices
            // 
            this.clbServices.FormattingEnabled = true;
            this.clbServices.Items.AddRange(new object[] {
            "Мойка окон",
            "Влажная уборка",
            "Чистка ковров",
            "Вывоз мусора",
            "Чистка вентиляции",
            "Генеральная уборка"});
            this.clbServices.Location = new System.Drawing.Point(383, 53);
            this.clbServices.Name = "clbServices";
            this.clbServices.Size = new System.Drawing.Size(120, 89);
            this.clbServices.TabIndex = 11;
            this.clbServices.SelectedIndexChanged += new System.EventHandler(this.clbServices_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(380, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Дата и время";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dtpSchedule
            // 
            this.dtpSchedule.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpSchedule.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSchedule.Location = new System.Drawing.Point(383, 186);
            this.dtpSchedule.Name = "dtpSchedule";
            this.dtpSchedule.Size = new System.Drawing.Size(160, 20);
            this.dtpSchedule.TabIndex = 13;
            this.dtpSchedule.ValueChanged += new System.EventHandler(this.dtpSchedule_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Комментарий";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(383, 255);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(322, 136);
            this.txtComment.TabIndex = 15;
            this.txtComment.TextChanged += new System.EventHandler(this.txtComment_TextChanged);
            // 
            // FormRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpSchedule);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.clbServices);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtRooms);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbOffice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRequest";
            this.Text = "Новая заявка на уборку";
            this.Load += new System.EventHandler(this.FormRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbOffice;
        private System.Windows.Forms.TextBox txtRooms;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox clbServices;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpSchedule;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtComment;
    }
}