namespace HotelManager
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txt_login = new TextBox();
            txt_password = new TextBox();
            btn_login = new Button();
            btn_exit = new Button();
            btn_register = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(23, 61);
            label1.Name = "label1";
            label1.Size = new Size(85, 32);
            label1.TabIndex = 0;
            label1.Text = "Login:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(23, 137);
            label2.Name = "label2";
            label2.Size = new Size(129, 32);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // txt_login
            // 
            txt_login.Location = new Point(160, 54);
            txt_login.Name = "txt_login";
            txt_login.Size = new Size(494, 39);
            txt_login.TabIndex = 2;
            txt_login.Text = "admin";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(160, 130);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(494, 39);
            txt_password.TabIndex = 3;
            txt_password.Text = "admin";
            // 
            // btn_login
            // 
            btn_login.Location = new Point(23, 226);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(150, 47);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(504, 226);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(150, 47);
            btn_exit.TabIndex = 5;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_register
            // 
            btn_register.Location = new Point(263, 226);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(173, 47);
            btn_register.TabIndex = 6;
            btn_register.Text = "User Manager";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 300);
            Controls.Add(btn_register);
            Controls.Add(btn_exit);
            Controls.Add(btn_login);
            Controls.Add(txt_password);
            Controls.Add(txt_login);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_login;
        private TextBox txt_password;
        private Button btn_login;
        private Button btn_exit;
        private Button btn_register;
    }
}
