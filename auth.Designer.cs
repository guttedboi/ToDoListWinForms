<<<<<<< HEAD
﻿namespace ToDoListWinForms
{
    partial class auth
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
            this.loginBtn = new System.Windows.Forms.Button();
            this.regLink = new System.Windows.Forms.LinkLabel();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.pwdBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.pwdLabel = new System.Windows.Forms.Label();
            this.auth_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(85, 119);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(86, 23);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Вход";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // regLink
            // 
            this.regLink.AutoSize = true;
            this.regLink.Location = new System.Drawing.Point(72, 145);
            this.regLink.Name = "regLink";
            this.regLink.Size = new System.Drawing.Size(113, 13);
            this.regLink.TabIndex = 1;
            this.regLink.TabStop = true;
            this.regLink.Text = "Зарегестрироваться";
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(85, 51);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(138, 20);
            this.loginBox.TabIndex = 2;
            // 
            // pwdBox
            // 
            this.pwdBox.Location = new System.Drawing.Point(85, 79);
            this.pwdBox.Name = "pwdBox";
            this.pwdBox.Size = new System.Drawing.Size(138, 20);
            this.pwdBox.TabIndex = 3;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(36, 54);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(38, 13);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "Логин";
            // 
            // pwdLabel
            // 
            this.pwdLabel.AutoSize = true;
            this.pwdLabel.Location = new System.Drawing.Point(36, 82);
            this.pwdLabel.Name = "pwdLabel";
            this.pwdLabel.Size = new System.Drawing.Size(45, 13);
            this.pwdLabel.TabIndex = 5;
            this.pwdLabel.Text = "Пароль";
            // 
            // auth_error
            // 
            this.auth_error.AutoSize = true;
            this.auth_error.ForeColor = System.Drawing.Color.Red;
            this.auth_error.Location = new System.Drawing.Point(30, 9);
            this.auth_error.Name = "auth_error";
            this.auth_error.Size = new System.Drawing.Size(199, 26);
            this.auth_error.TabIndex = 6;
            this.auth_error.Text = "Логин или пароль введены не верно! \r\nПопробуйте еще раз.";
            this.auth_error.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.auth_error.Visible = false;
            // 
            // auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 187);
            this.Controls.Add(this.auth_error);
            this.Controls.Add(this.pwdLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.pwdBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.regLink);
            this.Controls.Add(this.loginBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "auth";
            this.Text = "ToDoList - Auth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.LinkLabel regLink;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label pwdLabel;
        public System.Windows.Forms.TextBox loginBox;
        public System.Windows.Forms.TextBox pwdBox;
        public System.Windows.Forms.Label auth_error;
    }
}

=======
﻿namespace ToDoListWinForms
{
    partial class auth
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
            this.loginBtn = new System.Windows.Forms.Button();
            this.regLink = new System.Windows.Forms.LinkLabel();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.pwdBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.pwdLabel = new System.Windows.Forms.Label();
            this.auth_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(85, 119);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(86, 23);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Вход";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // regLink
            // 
            this.regLink.AutoSize = true;
            this.regLink.Location = new System.Drawing.Point(72, 145);
            this.regLink.Name = "regLink";
            this.regLink.Size = new System.Drawing.Size(113, 13);
            this.regLink.TabIndex = 1;
            this.regLink.TabStop = true;
            this.regLink.Text = "Зарегестрироваться";
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(85, 51);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(138, 20);
            this.loginBox.TabIndex = 2;
            // 
            // pwdBox
            // 
            this.pwdBox.Location = new System.Drawing.Point(85, 79);
            this.pwdBox.Name = "pwdBox";
            this.pwdBox.Size = new System.Drawing.Size(138, 20);
            this.pwdBox.TabIndex = 3;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(36, 54);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(38, 13);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "Логин";
            // 
            // pwdLabel
            // 
            this.pwdLabel.AutoSize = true;
            this.pwdLabel.Location = new System.Drawing.Point(36, 82);
            this.pwdLabel.Name = "pwdLabel";
            this.pwdLabel.Size = new System.Drawing.Size(45, 13);
            this.pwdLabel.TabIndex = 5;
            this.pwdLabel.Text = "Пароль";
            // 
            // auth_error
            // 
            this.auth_error.AutoSize = true;
            this.auth_error.ForeColor = System.Drawing.Color.Red;
            this.auth_error.Location = new System.Drawing.Point(30, 9);
            this.auth_error.Name = "auth_error";
            this.auth_error.Size = new System.Drawing.Size(199, 26);
            this.auth_error.TabIndex = 6;
            this.auth_error.Text = "Логин или пароль введены не верно! \r\nПопробуйте еще раз.";
            this.auth_error.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.auth_error.Visible = false;
            // 
            // auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 187);
            this.Controls.Add(this.auth_error);
            this.Controls.Add(this.pwdLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.pwdBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.regLink);
            this.Controls.Add(this.loginBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "auth";
            this.Text = "ToDoList - Auth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.LinkLabel regLink;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label pwdLabel;
        public System.Windows.Forms.TextBox loginBox;
        public System.Windows.Forms.TextBox pwdBox;
        public System.Windows.Forms.Label auth_error;
    }
}

>>>>>>> origin/master
