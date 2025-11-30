using Dapper;
using HotelManager.Configuration;
using HotelManager.Domains;
using Microsoft.Data.SqlClient;

namespace HotelManager.DAL
{
    public class ClientDb
    {
        private string _connectionString = AppConfig.ConnectionString;

        public List<Client>? GetAllClients()
        {
            List<Client>? users = null;
            using (var connection = new SqlConnection(_connectionString))
            {
                users = connection.Query<Client>("SELECT * FROM Clients").ToList();
            }
            return users;
        }
        public Client? GetClient(int Id)
        {
            Client? user = null;
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = $"SELECT * FROM Clients WHERE Id = {Id}";
                user = connection.QueryFirstOrDefault<Client>(sql);
            }
            return user;
        }
        public bool AddClient(Client client)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "INSERT INTO Clients (FirstName, LastName, PhoneNumber) " +
                             "VALUES (@FirstName, @LastName, @PhoneNumber)";
                return connection.Execute(sql, client) > 0;
            }
        }
        public bool UpdateClient(Client client)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                int rowsAffected = connection.Execute("UPDATE Clients SET FirstName = @FirstName, LastName = @LastName, PhoneNumber=@PhoneNumber WHERE Id=@Id", client);
                return rowsAffected > 0;
            }
        }
        public bool DeleteClient(int Id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                int rowsAffected = connection.Execute("DELETE FROM Clients WHERE Id = @Id", new { Id });
                return rowsAffected > 0;
            }
        }
    }
}
