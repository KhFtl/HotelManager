namespace HotelManager
{
    partial class ClientManager
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
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            label4 = new Label();
            txt_Id = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_PhoneNumber = new TextBox();
            txt_LastName = new TextBox();
            txt_FirstName = new TextBox();
            button4 = new Button();
            btn_DeleteClient = new Button();
            btn_EditClient = new Button();
            btn_AdddClient = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(2, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1286, 338);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Clients";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, FirstName, LastName, PhoneNumber });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1280, 300);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // FirstName
            // 
            FirstName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FirstName.HeaderText = "Ім'я";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            LastName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LastName.HeaderText = "Прізвище";
            LastName.MinimumWidth = 6;
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            PhoneNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PhoneNumber.HeaderText = "Номер телефону";
            PhoneNumber.MinimumWidth = 6;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.ReadOnly = true;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txt_Id);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txt_PhoneNumber);
            groupBox2.Controls.Add(txt_LastName);
            groupBox2.Controls.Add(txt_FirstName);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(btn_DeleteClient);
            groupBox2.Controls.Add(btn_EditClient);
            groupBox2.Controls.Add(btn_AdddClient);
            groupBox2.Location = new Point(2, 356);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1286, 330);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Control";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(333, 150);
            label4.Name = "label4";
            label4.Size = new Size(37, 32);
            label4.TabIndex = 11;
            label4.Text = "Id";
            // 
            // txt_Id
            // 
            txt_Id.Location = new Point(333, 192);
            txt_Id.Name = "txt_Id";
            txt_Id.Size = new Size(279, 39);
            txt_Id.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(333, 59);
            label3.Name = "label3";
            label3.Size = new Size(130, 32);
            label3.TabIndex = 9;
            label3.Text = "Прізвище";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(24, 157);
            label2.Name = "label2";
            label2.Size = new Size(214, 32);
            label2.TabIndex = 8;
            label2.Text = "Номер телефону";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(24, 59);
            label1.Name = "label1";
            label1.Size = new Size(62, 32);
            label1.TabIndex = 7;
            label1.Text = "Ім'я";
            // 
            // txt_PhoneNumber
            // 
            txt_PhoneNumber.Location = new Point(22, 192);
            txt_PhoneNumber.Name = "txt_PhoneNumber";
            txt_PhoneNumber.Size = new Size(279, 39);
            txt_PhoneNumber.TabIndex = 6;
            // 
            // txt_LastName
            // 
            txt_LastName.Location = new Point(333, 101);
            txt_LastName.Name = "txt_LastName";
            txt_LastName.Size = new Size(279, 39);
            txt_LastName.TabIndex = 5;
            // 
            // txt_FirstName
            // 
            txt_FirstName.Location = new Point(22, 101);
            txt_FirstName.Name = "txt_FirstName";
            txt_FirstName.Size = new Size(279, 39);
            txt_FirstName.TabIndex = 4;
            // 
            // button4
            // 
            button4.Location = new Point(1118, 272);
            button4.Name = "button4";
            button4.Size = new Size(162, 52);
            button4.TabIndex = 3;
            button4.Text = "Close";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btn_DeleteClient
            // 
            btn_DeleteClient.Location = new Point(379, 272);
            btn_DeleteClient.Name = "btn_DeleteClient";
            btn_DeleteClient.Size = new Size(162, 52);
            btn_DeleteClient.TabIndex = 2;
            btn_DeleteClient.Text = "Delete Client";
            btn_DeleteClient.UseVisualStyleBackColor = true;
            btn_DeleteClient.Click += btn_DeleteClient_Click;
            // 
            // btn_EditClient
            // 
            btn_EditClient.Location = new Point(194, 272);
            btn_EditClient.Name = "btn_EditClient";
            btn_EditClient.Size = new Size(162, 52);
            btn_EditClient.TabIndex = 1;
            btn_EditClient.Text = "Edit Client";
            btn_EditClient.UseVisualStyleBackColor = true;
            btn_EditClient.Click += btn_EditClient_Click;
            // 
            // btn_AdddClient
            // 
            btn_AdddClient.Location = new Point(6, 272);
            btn_AdddClient.Name = "btn_AdddClient";
            btn_AdddClient.Size = new Size(162, 52);
            btn_AdddClient.TabIndex = 0;
            btn_AdddClient.Text = "Add Client";
            btn_AdddClient.UseVisualStyleBackColor = true;
            btn_AdddClient.Click += btn_AdddClient_Click;
            // 
            // ClientManager
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 698);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "ClientManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClientManager";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private Button button4;
        private Button btn_DeleteClient;
        private Button btn_EditClient;
        private Button btn_AdddClient;
        private TextBox txt_FirstName;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn PhoneNumber;
        private TextBox txt_PhoneNumber;
        private TextBox txt_LastName;
        private Label label4;
        private TextBox txt_Id;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}