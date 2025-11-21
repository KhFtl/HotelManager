using Dapper;
using HotelManager.Configuration;
using HotelManager.Domains;
using Microsoft.Data.SqlClient;

namespace HotelManager.DAL
{
    public class RoomDb
    {
        private string _connectionString = AppConfig.ConnectionString;

        public bool AddRoom(Room room)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "INSERT INTO Rooms (Name, Price) " +
                             "VALUES (@Name, @Price)";
                return connection.Execute(sql, room) > 0;
            }
        }
        public bool UpdateRoom(Room room)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                // include WHERE clause to update specific row by Id
                int rowsAffected = connection.Execute("UPDATE Rooms SET Name = @Name, Price = @Price WHERE Id = @Id", room);
                return rowsAffected > 0;
            }
        }
        public bool DeleteRoom(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                int rowAffected = connection.Execute("DELETE FROM Rooms WHERE Id = @Id", new { Id = id });
                return rowAffected > 0;
            }
        }
        public List<Room>? GetAllRooms()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Rooms";
                return connection.Query<Room>(sql).ToList();
            }
        }
        public Room? GetRoomById(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Rooms WHERE Id = @Id";
                return connection.QueryFirstOrDefault<Room>(sql, new { Id = id });
            }
        }
    }
}
