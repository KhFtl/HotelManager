using HotelManager.DAL;
using HotelManager.Domains;
using HotelManager.Domains.VM;
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
        private readonly ResidenceDb _residenceDb = new ResidenceDb();
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

        private void FillResidencesTable(int IdClient)
        {
            var residences = _residenceDb.GetResidenceVMs(IdClient);
            if (residences == null)
            {
                return;
            }
            if (dgrv_residence.RowCount > 0)
            {
                dgrv_residence.Rows.Clear();
            }
            int index = 0;
            foreach (var residence in residences)
            {
                dgrv_residence.Rows.Add();
                dgrv_residence.Rows[index].Cells["ClientName"].Value = residence.ClientName;
                dgrv_residence.Rows[index].Cells["RoomName"].Value = residence.RoomName;
                dgrv_residence.Rows[index].Cells["StartDate"].Value = residence.StartDate.ToShortDateString();
                dgrv_residence.Rows[index].Cells["EndDate"].Value = residence.EndDate.ToShortDateString();
                dgrv_residence.Rows[index].Cells["CountDays"].Value = residence.CountDays;
                dgrv_residence.Rows[index].Cells["Price"].Value = residence.RoomPrice;
                dgrv_residence.Rows[index].Cells["TotalSum"].Value = residence.TotalPrice;
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
                int IdClient = (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
                FillResidencesTable(IdClient);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a client is selected
                var currentRow = dataGridView1.CurrentRow;
                if (currentRow == null)
                {
                    MessageBox.Show("Please select a client first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Safely extract client id
                var idCellValue = currentRow.Cells["Id"].Value;
                if (!(idCellValue is int clientId))
                {
                    MessageBox.Show("Selected client does not have a valid Id.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Safely extract room id from comboBox1.SelectedValue to avoid CS8605
                var selectedValue = comboBox1.SelectedValue;
                if (!(selectedValue is int roomId))
                {
                    MessageBox.Show("Please select a room.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Residence residence = new Residence
                {
                    IdClient = clientId,
                    IdRoom = roomId,
                    StartDate = dtp_startDate.Value,
                    EndDate = dtp_endDate.Value,
                    CountDays = (int)numericUpDown1.Value
                };
                _residenceDb.Add(residence);
                FillResidencesTable(residence.IdClient);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int days = (int)numericUpDown1.Value;
            dtp_endDate.Value = dtp_startDate.Value.AddDays(days);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientManager clientManager = new ClientManager();
            clientManager.ShowDialog();
        }
    }
}
