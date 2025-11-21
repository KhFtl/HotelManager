using HotelManager.DAL;
using HotelManager.Domains;

namespace HotelManager
{
    public partial class LoginForm : Form
    {
        private readonly UserDb _userDb = new UserDb();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string login = txt_login.Text;
            if (login == string.Empty || txt_password.Text == string.Empty)
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            User? user = _userDb.FindUser(login);
            if (user != null)
            {
                if (user.Password == txt_password.Text)
                {
                    ClientsForm clients = new ClientsForm();
                    clients.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Incorrect password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            RegisterFrom reg = new RegisterFrom();
            reg.ShowDialog();
        }

        private void btn_roomManager_Click(object sender, EventArgs e)
        {
            RoomForm roomForm = new RoomForm();
            roomForm.ShowDialog();
        }
    }
}
