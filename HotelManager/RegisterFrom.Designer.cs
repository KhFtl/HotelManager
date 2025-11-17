namespace HotelManager
{
    partial class RegisterFrom
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
            btn_exit = new Button();
            btn_register = new Button();
            txt_password = new TextBox();
            txt_login = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Login = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(15, 104);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(155, 47);
            btn_exit.TabIndex = 11;
            btn_exit.Text = "Close";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_register
            // 
            btn_register.Location = new Point(15, 38);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(155, 47);
            btn_register.TabIndex = 10;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(152, 104);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(294, 39);
            txt_password.TabIndex = 9;
            // 
            // txt_login
            // 
            txt_login.Location = new Point(152, 28);
            txt_login.Name = "txt_login";
            txt_login.Size = new Size(294, 39);
            txt_login.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(15, 111);
            label2.Name = "label2";
            label2.Size = new Size(129, 32);
            label2.TabIndex = 7;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(15, 35);
            label1.Name = "label1";
            label1.Size = new Size(85, 32);
            label1.TabIndex = 6;
            label1.Text = "Login:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_login);
            groupBox1.Controls.Add(txt_password);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(472, 178);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Зареєструвати";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(506, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(782, 531);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Користувачі";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Login, Password });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 493);
            dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            // 
            // Login
            // 
            Login.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Login.HeaderText = "Логін";
            Login.MinimumWidth = 6;
            Login.Name = "Login";
            // 
            // Password
            // 
            Password.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Password.HeaderText = "Пароль";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(btn_exit);
            groupBox3.Controls.Add(btn_register);
            groupBox3.Location = new Point(12, 206);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(472, 339);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Керування";
            // 
            // button1
            // 
            button1.Location = new Point(291, 38);
            button1.Name = "button1";
            button1.Size = new Size(155, 47);
            button1.TabIndex = 12;
            button1.Text = "Видалити";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(291, 104);
            button2.Name = "button2";
            button2.Size = new Size(155, 47);
            button2.TabIndex = 13;
            button2.Text = "Refresh";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // RegisterFrom
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 555);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "RegisterFrom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_exit;
        private Button btn_register;
        private TextBox txt_password;
        private TextBox txt_login;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Login;
        private DataGridViewTextBoxColumn Password;
        private GroupBox groupBox3;
        private Button button1;
        private Button button2;
    }
}