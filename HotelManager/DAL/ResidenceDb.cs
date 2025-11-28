using System.Collections.Generic;
using System.Linq;
using Dapper;
using HotelManager.Configuration;
using HotelManager.Domains;
using HotelManager.Domains.VM;
using Microsoft.Data.SqlClient;

namespace HotelManager.DAL
{
    public class ResidenceDb
    {
        private string _connectionString = AppConfig.ConnectionString;

        public List<Residence>? GetAll()
        {
            using var connection = new SqlConnection(_connectionString);
            return connection.Query<Residence>("SELECT Id, IdClient, IdRoom, StartDate, EndDate, CountDays FROM Residence").ToList();
        }

        public List<ResidenceVM>? GetResidenceVMs(int clientId)
        {
            using var connection = new SqlConnection(_connectionString);

            string sql = @"
                            SELECT 
                                res.Id,
                                c.FirstName + ' ' + c.LastName AS ClientName,
                                rm.Name AS RoomName,
                                res.StartDate,
                                res.EndDate,
                                res.CountDays,
                                rm.Price AS RoomPrice,
                                (res.CountDays * rm.Price) AS TotalPrice
                            FROM Residence AS res
                            INNER JOIN Clients AS c ON res.IdClient = c.Id
                            INNER JOIN Rooms AS rm ON res.IdRoom = rm.Id
                            WHERE c.Id = @ClientId";

            return connection.Query<ResidenceVM>(sql, new { ClientId = clientId }).ToList();
        }


        public Residence? Get(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            return connection.QueryFirstOrDefault<Residence>("SELECT Id, IdClient, IdRoom, StartDate, EndDate, CountDays FROM Residence WHERE Id = @Id", new { Id = id });
        }

        public bool Add(Residence residence)
        {
            using var connection = new SqlConnection(_connectionString);
            const string sql = @"INSERT INTO Residence (IdClient, IdRoom, StartDate, EndDate, CountDays)
                                 VALUES (@IdClient, @IdRoom, @StartDate, @EndDate, @CountDays)";
            return connection.Execute(sql, residence) > 0;
        }

        public bool Update(Residence residence)
        {
            using var connection = new SqlConnection(_connectionString);
            const string sql = @"UPDATE Residence
                                    SET IdClient = @IdClient,
                                        IdRoom = @IdRoom,
                                        StartDate = @StartDate,
                                        EndDate = @EndDate,
                                        CountDays = @CountDays
                                    WHERE Id = @Id";
            return connection.Execute(sql, residence) > 0;
        }

        public bool Delete(int id)
        {
            using var connection = new SqlConnection(_connectionString);
            const string sql = "DELETE FROM Residence WHERE Id = @Id";
            return connection.Execute(sql, new { Id = id }) > 0;
        }
    }
}