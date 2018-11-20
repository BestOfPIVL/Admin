namespace LoginIn
{
    partial class Form1
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
            this.label0 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb8Mail = new System.Windows.Forms.TextBox();
            this.tb1Username = new System.Windows.Forms.TextBox();
            this.tb2Password = new System.Windows.Forms.TextBox();
            this.tb3PassConf = new System.Windows.Forms.TextBox();
            this.tb7Year = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb4Status = new System.Windows.Forms.ComboBox();
            this.cb5Faculty = new System.Windows.Forms.ComboBox();
            this.cb6Spec = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(28, 211);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(0, 13);
            this.label0.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password confirmation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Admission year";
            // 
            // tb8Mail
            // 
            this.tb8Mail.Location = new System.Drawing.Point(60, 184);
            this.tb8Mail.Name = "tb8Mail";
            this.tb8Mail.Size = new System.Drawing.Size(100, 20);
            this.tb8Mail.TabIndex = 22;
            this.tb8Mail.TextChanged += new System.EventHandler(this.tb8Mail_TextChanged);
            // 
            // tb1Username
            // 
            this.tb1Username.Location = new System.Drawing.Point(67, 2);
            this.tb1Username.Name = "tb1Username";
            this.tb1Username.Size = new System.Drawing.Size(100, 20);
            this.tb1Username.TabIndex = 13;
            // 
            // tb2Password
            // 
            this.tb2Password.Location = new System.Drawing.Point(67, 30);
            this.tb2Password.Name = "tb2Password";
            this.tb2Password.Size = new System.Drawing.Size(100, 20);
            this.tb2Password.TabIndex = 14;
            // 
            // tb3PassConf
            // 
            this.tb3PassConf.Location = new System.Drawing.Point(128, 56);
            this.tb3PassConf.Name = "tb3PassConf";
            this.tb3PassConf.Size = new System.Drawing.Size(100, 20);
            this.tb3PassConf.TabIndex = 15;
            // 
            // tb7Year
            // 
            this.tb7Year.Location = new System.Drawing.Point(88, 160);
            this.tb7Year.Name = "tb7Year";
            this.tb7Year.Size = new System.Drawing.Size(100, 20);
            this.tb7Year.TabIndex = 21;
            this.tb7Year.TextChanged += new System.EventHandler(this.tb7Year_TextChanged);
            this.tb7Year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb7Year_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Faculty";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Specialty";
            // 
            // cb4Status
            // 
            this.cb4Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb4Status.DropDownWidth = 204;
            this.cb4Status.FormattingEnabled = true;
            this.cb4Status.Location = new System.Drawing.Point(64, 79);
            this.cb4Status.Name = "cb4Status";
            this.cb4Status.Size = new System.Drawing.Size(204, 21);
            this.cb4Status.TabIndex = 18;
            this.cb4Status.SelectedIndexChanged += new System.EventHandler(this.cb4Status_SelectedIndexChanged);
            // 
            // cb5Faculty
            // 
            this.cb5Faculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb5Faculty.DropDownWidth = 300;
            this.cb5Faculty.FormattingEnabled = true;
            this.cb5Faculty.ItemHeight = 13;
            this.cb5Faculty.Location = new System.Drawing.Point(64, 106);
            this.cb5Faculty.Name = "cb5Faculty";
            this.cb5Faculty.Size = new System.Drawing.Size(204, 21);
            this.cb5Faculty.TabIndex = 19;
            this.cb5Faculty.SelectedIndexChanged += new System.EventHandler(this.Cb5Faculty_SelectedIndexChanged);
            // 
            // cb6Spec
            // 
            this.cb6Spec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb6Spec.DropDownWidth = 680;
            this.cb6Spec.FormattingEnabled = true;
            this.cb6Spec.ItemHeight = 13;
            this.cb6Spec.Location = new System.Drawing.Point(64, 135);
            this.cb6Spec.Name = "cb6Spec";
            this.cb6Spec.Size = new System.Drawing.Size(204, 21);
            this.cb6Spec.TabIndex = 20;
            this.cb6Spec.SelectedIndexChanged += new System.EventHandler(this.cb6Spec_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(186, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Check";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(296, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Введите код, подтверждающий, что Вы - администратор.";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(64, 135);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 20);
            this.textBox2.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(174, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(195, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(231, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 164);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 334);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb8Mail);
            this.Controls.Add(this.tb7Year);
            this.Controls.Add(this.cb6Spec);
            this.Controls.Add(this.cb5Faculty);
            this.Controls.Add(this.cb4Status);
            this.Controls.Add(this.tb3PassConf);
            this.Controls.Add(this.tb2Password);
            this.Controls.Add(this.tb1Username);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label0);
            this.Name = "Form1";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb8Mail;
        private System.Windows.Forms.TextBox tb1Username;
        private System.Windows.Forms.TextBox tb2Password;
        private System.Windows.Forms.TextBox tb3PassConf;
        private System.Windows.Forms.TextBox tb7Year;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb4Status;
        private System.Windows.Forms.ComboBox cb5Faculty;
        private System.Windows.Forms.ComboBox cb6Spec;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

