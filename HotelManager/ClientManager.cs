using HotelManager.DAL;
using HotelManager.Domains;

namespace HotelManager
{
    public partial class ClientManager : Form
    {
        private readonly ClientDb _clientDb;
        private readonly ResidenceDb _residenceDb;
        public ClientManager()
        {
            InitializeComponent();
            _clientDb = new ClientDb();
            _residenceDb = new ResidenceDb();
            FillTabel();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillTabel()
        {
            var clients = _clientDb.GetAllClients();
            if (clients != null)
            {
                dataGridView1.Rows.Clear();
            }
            else
            {
                return;
            }
            int i = 0;
            foreach (var client in clients)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells["Id"].Value = client.Id;
                dataGridView1.Rows[i].Cells["FirstName"].Value = client.FirstName;
                dataGridView1.Rows[i].Cells["LastName"].Value = client.LastName;
                dataGridView1.Rows[i].Cells["PhoneNumber"].Value = client.PhoneNumber;
                i++;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Id.Text = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            txt_FirstName.Text = dataGridView1.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
            txt_LastName.Text = dataGridView1.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
            txt_PhoneNumber.Text = dataGridView1.Rows[e.RowIndex].Cells["PhoneNumber"].Value.ToString();
        }

        private void btn_AdddClient_Click(object sender, EventArgs e)
        {
            Client client = new Client
            {
                FirstName = txt_FirstName.Text,
                LastName = txt_LastName.Text,
                PhoneNumber = txt_PhoneNumber.Text
            };
            if (_clientDb.AddClient(client))
            {
                FillTabel();
            }

        }

        private void btn_EditClient_Click(object sender, EventArgs e)
        {
            Client updClient = new Client
            {
                Id = Convert.ToInt32(txt_Id.Text),
                FirstName = txt_FirstName.Text,
                LastName = txt_LastName.Text,
                PhoneNumber = txt_PhoneNumber.Text
            };
            _clientDb.UpdateClient(updClient);
            FillTabel();
        }

        private void btn_DeleteClient_Click(object sender, EventArgs e)
        {
            if (txt_Id.Text.Length == 0 || string.IsNullOrEmpty(txt_Id.Text))
            {
                return;
            }
            int Id = Convert.ToInt32(txt_Id.Text);
            DialogResult result = MessageBox.Show($"Are you sure you want to delete this {txt_FirstName.Text +" "+txt_LastName.Text }?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            if (_residenceDb.DeleteClientResidences(Id))
            {
                if (_clientDb.DeleteClient(Id))
                {
                    FillTabel();
                }
            }
        }
    }
}
