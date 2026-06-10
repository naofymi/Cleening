namespace Cleening
{
    partial class FormLogin
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnContractor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(106, 14);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(191, 77);
            this.btnEmployee.TabIndex = 0;
            this.btnEmployee.Text = "Я сотрудник";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnContractor
            // 
            this.btnContractor.Location = new System.Drawing.Point(103, 103);
            this.btnContractor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnContractor.Name = "btnContractor";
            this.btnContractor.Size = new System.Drawing.Size(191, 77);
            this.btnContractor.TabIndex = 1;
            this.btnContractor.Text = "Я подрядчик";
            this.btnContractor.UseVisualStyleBackColor = true;
            this.btnContractor.Click += new System.EventHandler(this.btnContractor_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 283);
            this.Controls.Add(this.btnContractor);
            this.Controls.Add(this.btnEmployee);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormLogin";
            this.Text = "Вход в систему";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnContractor;
        private System.Windows.Forms.Button btnEmployee;
    }
}

