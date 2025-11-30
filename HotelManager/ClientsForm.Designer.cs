namespace HotelManager
{
    partial class ClientsForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            button1 = new Button();
            label5 = new Label();
            txt_client = new TextBox();
            dtp_endDate = new DateTimePicker();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            dtp_startDate = new DateTimePicker();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            dgrv_residence = new DataGridView();
            ClientName = new DataGridViewTextBoxColumn();
            RoomName = new DataGridViewTextBoxColumn();
            StartDate = new DataGridViewTextBoxColumn();
            EndDate = new DataGridViewTextBoxColumn();
            CountDays = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            TotalSum = new DataGridViewTextBoxColumn();
            button2 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrv_residence).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1456, 178);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Clients";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, FirstName, LastName, PhoneNumber });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1450, 140);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            // 
            // FirstName
            // 
            FirstName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FirstName.HeaderText = "Ім'я";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            LastName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LastName.HeaderText = "Прізвище";
            LastName.MinimumWidth = 6;
            LastName.Name = "LastName";
            // 
            // PhoneNumber
            // 
            PhoneNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PhoneNumber.HeaderText = "Номер телефона";
            PhoneNumber.MinimumWidth = 6;
            PhoneNumber.Name = "PhoneNumber";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txt_client);
            groupBox2.Controls.Add(dtp_endDate);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(dtp_startDate);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(15, 193);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1453, 236);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Control";
            // 
            // button1
            // 
            button1.Location = new Point(507, 152);
            button1.Name = "button1";
            button1.Size = new Size(388, 59);
            button1.TabIndex = 10;
            button1.Text = "Заселити";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 137);
            label5.Name = "label5";
            label5.Size = new Size(82, 32);
            label5.TabIndex = 9;
            label5.Text = "Клієнт";
            // 
            // txt_client
            // 
            txt_client.Location = new Point(6, 172);
            txt_client.Name = "txt_client";
            txt_client.ReadOnly = true;
            txt_client.Size = new Size(469, 39);
            txt_client.TabIndex = 8;
            // 
            // dtp_endDate
            // 
            dtp_endDate.CustomFormat = "dd.MM.yyyy HH:mm";
            dtp_endDate.Format = DateTimePickerFormat.Custom;
            dtp_endDate.Location = new Point(454, 77);
            dtp_endDate.Name = "dtp_endDate";
            dtp_endDate.Size = new Size(213, 39);
            dtp_endDate.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(454, 35);
            label4.Name = "label4";
            label4.Size = new Size(189, 32);
            label4.TabIndex = 6;
            label4.Text = "Дата виселення";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(278, 77);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 39);
            numericUpDown1.TabIndex = 5;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(278, 32);
            label3.Name = "label3";
            label3.Size = new Size(163, 32);
            label3.TabIndex = 4;
            label3.Text = "Кількість днів";
            // 
            // dtp_startDate
            // 
            dtp_startDate.CustomFormat = "dd.MM.yyyy HH:mm";
            dtp_startDate.Format = DateTimePickerFormat.Custom;
            dtp_startDate.Location = new Point(6, 77);
            dtp_startDate.Name = "dtp_startDate";
            dtp_startDate.Size = new Size(240, 39);
            dtp_startDate.TabIndex = 3;
            dtp_startDate.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 35);
            label2.Name = "label2";
            label2.Size = new Size(185, 32);
            label2.TabIndex = 2;
            label2.Text = "Дата заселення";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(684, 77);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(208, 39);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(684, 32);
            label1.Name = "label1";
            label1.Size = new Size(180, 32);
            label1.TabIndex = 0;
            label1.Text = "Оберіть номер";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(dgrv_residence);
            groupBox3.Location = new Point(15, 435);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1453, 293);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Residences";
            // 
            // dgrv_residence
            // 
            dgrv_residence.AllowUserToAddRows = false;
            dgrv_residence.AllowUserToDeleteRows = false;
            dgrv_residence.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrv_residence.Columns.AddRange(new DataGridViewColumn[] { ClientName, RoomName, StartDate, EndDate, CountDays, Price, TotalSum });
            dgrv_residence.Dock = DockStyle.Fill;
            dgrv_residence.Location = new Point(3, 35);
            dgrv_residence.Name = "dgrv_residence";
            dgrv_residence.ReadOnly = true;
            dgrv_residence.RowHeadersWidth = 51;
            dgrv_residence.Size = new Size(1447, 255);
            dgrv_residence.TabIndex = 0;
            // 
            // ClientName
            // 
            ClientName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ClientName.HeaderText = "Клієнт";
            ClientName.MinimumWidth = 6;
            ClientName.Name = "ClientName";
            ClientName.ReadOnly = true;
            // 
            // RoomName
            // 
            RoomName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RoomName.HeaderText = "Номер";
            RoomName.MinimumWidth = 6;
            RoomName.Name = "RoomName";
            RoomName.ReadOnly = true;
            // 
            // StartDate
            // 
            StartDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            StartDate.DefaultCellStyle = dataGridViewCellStyle1;
            StartDate.HeaderText = "Дата заселення";
            StartDate.MinimumWidth = 6;
            StartDate.Name = "StartDate";
            StartDate.ReadOnly = true;
            // 
            // EndDate
            // 
            EndDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Format = "g";
            dataGridViewCellStyle2.NullValue = null;
            EndDate.DefaultCellStyle = dataGridViewCellStyle2;
            EndDate.HeaderText = "Дата виселення";
            EndDate.MinimumWidth = 6;
            EndDate.Name = "EndDate";
            EndDate.ReadOnly = true;
            // 
            // CountDays
            // 
            CountDays.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CountDays.HeaderText = "Кількість днів";
            CountDays.MinimumWidth = 6;
            CountDays.Name = "CountDays";
            CountDays.ReadOnly = true;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            Price.DefaultCellStyle = dataGridViewCellStyle3;
            Price.HeaderText = "Ціна";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // TotalSum
            // 
            TotalSum.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            TotalSum.DefaultCellStyle = dataGridViewCellStyle4;
            TotalSum.HeaderText = "Сума";
            TotalSum.MinimumWidth = 6;
            TotalSum.Name = "TotalSum";
            TotalSum.ReadOnly = true;
            // 
            // button2
            // 
            button2.Location = new Point(1250, 161);
            button2.Name = "button2";
            button2.Size = new Size(197, 59);
            button2.TabIndex = 11;
            button2.Text = "Client Manager";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ClientsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1480, 740);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "ClientsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clients";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgrv_residence).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn PhoneNumber;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dgrv_residence;
        private DateTimePicker dtp_startDate;
        private Label label2;
        private ComboBox comboBox1;
        private Label label1;
        private DateTimePicker dtp_endDate;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Label label5;
        private TextBox txt_client;
        private Button button1;
        private DataGridViewTextBoxColumn ClientName;
        private DataGridViewTextBoxColumn RoomName;
        private DataGridViewTextBoxColumn StartDate;
        private DataGridViewTextBoxColumn EndDate;
        private DataGridViewTextBoxColumn CountDays;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn TotalSum;
        private Button button2;
    }
}