using HotelManager.Domains;
using Microsoft.Data.SqlClient;

namespace HotelManager.DAL
{
    public class UserDb
    {
        private string _connectionString = String.Empty;
        public UserDb()
        {
            _connectionString = Configuration.AppConfig.ConnectionString;
        }
        public User? FindUser(string Login)
        {
            User? user = null;
            string query = $"SELECT * FROM Users WHERE Login = '{Login}'";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                user = new User
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Login = reader["Login"].ToString()!,
                                    Password = reader["Password"].ToString()!
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                   MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return user;
        }
        public bool AddUser(User user)
        {
            if (user == null)
            {
                return false;
            }
            User? existUser = FindUser(user.Login);
            if (existUser != null)
            {
                MessageBox.Show($"User {user.Login} is exists!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string query = $"INSERT INTO Users (Login, Password) VALUES ('{user.Login}', '{user.Password}')";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        public bool ChangeUserPassword(User user)
        {
            if (user == null)
            {
                return false;
            }
            string query = $"UPDATE Users SET Password = '{user.Password}' WHERE Login = '{user.Login}'";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        public bool DeleteUser(int Id)
        {
            string query = $"DELETE FROM Users WHERE Id = '{Id}'";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            string query = "SELECT * FROM Users";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                User user = new User
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Login = reader["Login"].ToString()!,
                                    Password = reader["Password"].ToString()!
                                };
                                users.Add(user);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return users;
        }
    }
}
