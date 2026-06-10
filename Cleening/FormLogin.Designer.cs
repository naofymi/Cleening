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
            this.btnEmployee.Location = new System.Drawing.Point(211, 27);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(382, 148);
            this.btnEmployee.TabIndex = 0;
            this.btnEmployee.Text = "Я сотрудник";
            this.btnEmployee.UseVisualStyleBackColor = true;
            // 
            // btnContractor
            // 
            this.btnContractor.Location = new System.Drawing.Point(206, 198);
            this.btnContractor.Name = "btnContractor";
            this.btnContractor.Size = new System.Drawing.Size(382, 148);
            this.btnContractor.TabIndex = 1;
            this.btnContractor.Text = "Я подрядчик";
            this.btnContractor.UseVisualStyleBackColor = true;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 545);
            this.Controls.Add(this.btnContractor);
            this.Controls.Add(this.btnEmployee);
            this.Name = "FormLogin";
            this.Text = "Вход в систему";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnContractor;
    }
}

