using HotelManager.DAL;
using HotelManager.Domains;
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
    public partial class RegisterFrom : Form
    {
        private readonly UserDb userDb = new UserDb();
        public RegisterFrom()
        {
            InitializeComponent();
            FillTable();

            // Ensure KeyDown is handled so special keys like Delete are detected
            dataGridView1.KeyDown += dataGridView1_KeyDown;
        }

        private void FillTable()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.Clear();
            }
            var users = userDb.GetAllUsers();
            int rowIndex = 0;
            foreach (var item in users)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells["Id"].Value = item.Id;
                dataGridView1.Rows[rowIndex].Cells["Login"].Value = item.Login;
                dataGridView1.Rows[rowIndex].Cells["Password"].Value = item.Password;
                rowIndex++;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Login = txt_login.Text,
                Password = txt_password.Text
            };
            if (userDb.AddUser(user))
            {
                MessageBox.Show($"Користувача {user.Login} створено", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.FillTable();
            }
        }

        private void DeleteSelectedUser()
        {
            if (dataGridView1.CurrentCell == null || dataGridView1.Rows.Count == 0)
                return;

            int selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            var idCell = dataGridView1.Rows[selectedRowIndex].Cells["Id"].Value;
            if (idCell == null)
                return;

            if (!int.TryParse(idCell.ToString(), out int userId))
                return;

            DialogResult dgResult = MessageBox.Show($"Ви дійсно бажаєте видалити користувача з Id {userId}?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dgResult == DialogResult.Yes)
            {
                userDb.DeleteUser(userId);
                FillTable();
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteSelectedUser();
                // optionally prevent further processing
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteSelectedUser();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FillTable();
        }
    }
}
