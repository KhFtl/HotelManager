namespace HotelManager
{
    partial class RoomForm
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
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            btn_close = new Button();
            btn_refresh = new Button();
            Id = new DataGridViewTextBoxColumn();
            NameRoom = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(9, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1271, 538);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Room Manager";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, NameRoom, Price });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1265, 500);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(btn_close);
            groupBox2.Controls.Add(btn_refresh);
            groupBox2.Location = new Point(9, 565);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1271, 125);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Control";
            // 
            // btn_close
            // 
            btn_close.Location = new Point(1071, 38);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(194, 68);
            btn_close.TabIndex = 1;
            btn_close.Text = "Close";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // btn_refresh
            // 
            btn_refresh.Location = new Point(6, 38);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(194, 68);
            btn_refresh.TabIndex = 0;
            btn_refresh.Text = "Refresh";
            btn_refresh.UseVisualStyleBackColor = true;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            // 
            // NameRoom
            // 
            NameRoom.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NameRoom.HeaderText = "Назва номеру";
            NameRoom.MinimumWidth = 6;
            NameRoom.Name = "NameRoom";
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            Price.DefaultCellStyle = dataGridViewCellStyle1;
            Price.HeaderText = "Ціна номеру за 1 добу";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            // 
            // RoomForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1292, 702);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "RoomForm";
            Text = "Room Manager";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Button btn_close;
        private Button btn_refresh;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn NameRoom;
        private DataGridViewTextBoxColumn Price;
    }
}