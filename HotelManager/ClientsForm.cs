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
        public ClientsForm()
        {
            InitializeComponent();
            this.FillTable();
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
    }
}
