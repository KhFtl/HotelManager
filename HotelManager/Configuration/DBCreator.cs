using Dapper;
using Microsoft.Data.SqlClient;
using System;

namespace HotelManager.Configuration
{
    public static class DBCreator
    {
        private static readonly string _connectionString = AppConfig.ConnectionString;

        public static bool ExistDatabase(string DbName)
        {
            try
            {
                var builder = new SqlConnectionStringBuilder(_connectionString)
                {
                    InitialCatalog = "master"
                };

                using var connection = new SqlConnection(builder.ConnectionString);
                connection.Open();

                const string sql = "SELECT COUNT(1) FROM sys.databases WHERE name = @name";
                var count = connection.QuerySingle<int>(sql, new { name = DbName });

                return count > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void CreateDb(string dbName)
        {
            if (string.IsNullOrWhiteSpace(dbName))
            {
                return;
            }
            // If DB already exists, consider it success (no need to recreate)
            if (ExistDatabase(dbName))
            {
                return;
            }
                // 1) Create database in master
                var masterBuilder = new SqlConnectionStringBuilder(_connectionString)
                {
                    InitialCatalog = "master"
                };

                using (var masterConn = new SqlConnection(masterBuilder.ConnectionString))
                {
                    masterConn.Open();
                    var createDbSql = $"CREATE DATABASE [{dbName}]";
                    masterConn.Execute(createDbSql);

                    // ensure database is writable
                    masterConn.Execute($"ALTER DATABASE [{dbName}] SET READ_WRITE");
                }

                // 2) Connect to the newly created database and create tables + constraints
                var dbBuilder = new SqlConnectionStringBuilder(_connectionString)
                {
                    InitialCatalog = dbName
                };

                using (var dbConn = new SqlConnection(dbBuilder.ConnectionString))
                {
                dbConn.Open();

                // Create tables (no GO statements)
                const string createClients = @"
                                                CREATE TABLE [dbo].[Clients](
	                                                [Id] [int] IDENTITY(1,1) NOT NULL,
	                                                [FirstName] [nvarchar](50) NOT NULL,
	                                                [LastName] [nvarchar](50) NOT NULL,
	                                                [PhoneNumber] [nvarchar](20) NOT NULL,
                                                 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED ([Id] ASC)
                                                );";

                const string createRooms = @"
                                            CREATE TABLE [dbo].[Rooms](
	                                            [Id] [int] IDENTITY(1,1) NOT NULL,
	                                            [Name] [nvarchar](50) NOT NULL,
	                                            [Price] [decimal](18, 2) NOT NULL,
                                             PRIMARY KEY CLUSTERED ([Id] ASC)
                                            );";

                const string createResidence = @"
                                                CREATE TABLE [dbo].[Residence](
	                                                [Id] [int] IDENTITY(1,1) NOT NULL,
	                                                [IdClient] [int] NOT NULL,
	                                                [IdRoom] [int] NOT NULL,
	                                                [StartDate] [datetime] NOT NULL,
	                                                [EndDate] [datetime] NULL,
	                                                [CountDays] [int] NOT NULL,
                                                 CONSTRAINT [PK_Residence] PRIMARY KEY CLUSTERED ([Id] ASC)
                                                );";

                const string createUsers = @"
                                            CREATE TABLE [dbo].[Users](
	                                            [Id] [int] IDENTITY(1,1) NOT NULL,
	                                            [Login] [nvarchar](50) NOT NULL,
	                                            [Password] [nvarchar](50) NOT NULL,
                                             CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([Id] ASC)
                                            );";

                dbConn.Execute(createClients);
                dbConn.Execute(createRooms);
                dbConn.Execute(createResidence);
                dbConn.Execute(createUsers);

                // Add foreign keys
                const string fkClients = @"
                                        ALTER TABLE [dbo].[Residence] 
                                            ADD CONSTRAINT [FK_Residence_Clients] FOREIGN KEY([IdClient]) REFERENCES [dbo].[Clients]([Id]);";

                const string fkRooms = @"
                                        ALTER TABLE [dbo].[Residence] 
                                            ADD CONSTRAINT [FK_Residence_Rooms] FOREIGN KEY([IdRoom]) REFERENCES [dbo].[Rooms]([Id]);";

                dbConn.Execute(fkClients);
                dbConn.Execute(fkRooms);
            }
        }
    }
}
