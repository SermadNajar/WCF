using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using System.Configuration;

namespace BookEtBordService.DataAccessLayer {
    class DBTable {

        private string _connectionString;

        public DBTable() {
            _connectionString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        }

        public void CreateTable(BTable bTable)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand cmdInsertProd = connection.CreateCommand())
                {
                    
                    cmdInsertProd.CommandText = "INSERT INTO BTable(Seats, Reserved) VALUES(@Seats, @Reserved)";
                    cmdInsertProd.Parameters.AddWithValue("Seats", bTable.Seats);
                    cmdInsertProd.Parameters.AddWithValue("Reserved", bTable.Reserved);
                    cmdInsertProd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateTable(BTable bTable)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand cmdUpdateTable = connection.CreateCommand())
                {

                    cmdUpdateTable.CommandText = "update BTable set seats = @Seats, reserved = @Reserved where id = @id";
                    cmdUpdateTable.Parameters.AddWithValue("Id", bTable.Id);
                    cmdUpdateTable.Parameters.AddWithValue("Seats", bTable.Seats);
                    cmdUpdateTable.Parameters.AddWithValue("Reserved", bTable.Reserved);
                    cmdUpdateTable.ExecuteNonQuery();
                }
            }
        }

        public void DeleteTable(BTable bTable)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand cmdDeleteTable = connection.CreateCommand())
                {

                    cmdDeleteTable.CommandText = "delete from BTable where id = @id";
                    cmdDeleteTable.Parameters.AddWithValue("Id", bTable.Id);
                    cmdDeleteTable.ExecuteNonQuery();
                }
            }
        }

        public List<BTable> GetAllTables() {
            List<BTable> tables = new List<BTable>();
            BTable tempT;

            using (SqlConnection connection = new SqlConnection(_connectionString)) {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand()) {
                    cmd.CommandText = "select Id, Seats, Reserved from BTable";
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read()) {
                        tempT = new BTable();
                        tempT.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                        tempT.Seats = reader.GetInt32(reader.GetOrdinal("Seats"));
                        tempT.Reserved = reader.GetBoolean(reader.GetOrdinal("Reserved"));
                        tables.Add(tempT);
                    }
                }
            }
            return tables;
        }

        public List<BTable> GetAllFreeTables() {
            List<BTable> tables = new List<BTable>();
            BTable tempT;

            using (SqlConnection connection = new SqlConnection(_connectionString)) {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand()) {
                    cmd.CommandText = "select Id, Seats, Reserved from BTable where reserved = 'false'";
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read()) {
                        tempT = new BTable();
                        tempT.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                        tempT.Seats = reader.GetInt32(reader.GetOrdinal("Seats"));
                        tempT.Reserved = reader.GetBoolean(reader.GetOrdinal("Reserved"));
                        tables.Add(tempT);
                    }
                }
            }
            return tables;
        }

        public List<BTable> GetAllReservedTables() {
            List<BTable> tables = new List<BTable>();
            BTable tempT;

            using (SqlConnection connection = new SqlConnection(_connectionString)) {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand()) {
                    cmd.CommandText = "select Id, Seats, Reserved from BTable where reserved = 'true'";
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read()) {
                        tempT = new BTable();
                        tempT.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                        tempT.Seats = reader.GetInt32(reader.GetOrdinal("Seats"));
                        tempT.Reserved = reader.GetBoolean(reader.GetOrdinal("Reserved"));
                        tables.Add(tempT);
                    }
                }
            }
            return tables;
        }


    }

}
