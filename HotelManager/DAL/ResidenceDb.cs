using System.Collections.Generic;
using System.Linq;
using Dapper;
using HotelManager.Configuration;
using HotelManager.Domains;
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