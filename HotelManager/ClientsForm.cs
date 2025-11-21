using HotelManager.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager
{
    public partial class ClientsForm : Form
    {
        private readonly ClientDb _clientDb = new ClientDb();
        private readonly RoomDb _roomDb = new RoomDb();
        public ClientsForm()
        {
            InitializeComponent();
            this.FillTable();

            // bind rooms: show room Name, use Id as the value
            comboBox1.DataSource = _roomDb.GetAllRooms();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            comboBox1.SelectedIndex = -1; // optional: no selection initially
        }

        private void FillTable()
        {
            var clients = _clientDb.GetAllClients();
            if (dataGridView1.RowCount > 0)
            {
                dataGridView1.Rows.Clear();
            }
            if (clients == null)
            {
                return;
            }
            int index = 0;
            foreach (var client in clients)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells["Id"].Value = client.Id;
                dataGridView1.Rows[index].Cells["FirstName"].Value = client.FirstName;
                dataGridView1.Rows[index].Cells["LastName"].Value = client.LastName;
                dataGridView1.Rows[index].Cells["PhoneNumber"].Value = client.PhoneNumber;
                index++;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < dataGridView1.RowCount - 1)
            {
                string FullName = dataGridView1.Rows[e.RowIndex].Cells["FirstName"].Value.ToString() + " " +
                                  dataGridView1.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
                txt_client.Text = FullName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int days = (int)numericUpDown1.Value;
            dtp_endDate.Value = dtp_startDate.Value.AddDays(days);
        }
    }
}
