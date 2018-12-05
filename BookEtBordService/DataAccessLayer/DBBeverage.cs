using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using System.Configuration;

namespace BookEtBordService.DataAccessLayer
{
    class DBBeverage
    {
        private string _connectionString;

        public DBBeverage() {
            _connectionString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        }

        public List<BBeverage> GetAllBeverage()
        {
            List<BBeverage> beverages = new List<BBeverage>();
            BBeverage tempB;
            BBeverageCategory tempBC;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "select beverage.id as bid, beverage.name as bname, beverage.price as price, beverageCategory.id as id, beverageCategory.name as name from Beverage, BeverageCategory where Beverage.beverageCategoryID = BeverageCategory.id";
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        tempB = new BBeverage();
                        tempBC = new BBeverageCategory();
                        tempB.Id = reader.GetInt32(reader.GetOrdinal("bid"));
                        tempB.Name = reader.GetString(reader.GetOrdinal("bname"));
                        tempB.Price = reader.GetDecimal(reader.GetOrdinal("price"));
                        tempBC.Id = reader.GetInt32(reader.GetOrdinal("id"));
                        tempBC.Name = reader.GetString(reader.GetOrdinal("name"));
                        tempB.BeverageCategory = tempBC;
                        beverages.Add(tempB);
                    }
                }
            }
            return beverages;
        }

        public void CreateBeverage(BBeverage beverage)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand cmdInsertBeverage = connection.CreateCommand())
                {

                    cmdInsertBeverage.CommandText = "INSERT INTO Beverage(Name, Price, BeverageCategory) VALUES(@Name, @Price, @BeverageCategory)";
                    cmdInsertBeverage.Parameters.AddWithValue("Name", beverage.Name);
                    cmdInsertBeverage.Parameters.AddWithValue("Price", beverage.Price);
                    cmdInsertBeverage.Parameters.AddWithValue("beverageCategoryId", beverage.BeverageCategory);
                    cmdInsertBeverage.ExecuteNonQuery();
                }
            }
        }

        public void UpdateBeverage(BBeverage beverage)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand cmdUpdateBeverage = connection.CreateCommand())
                {

                    cmdUpdateBeverage.CommandText = "update beverage set name = @name, price = @price, BeverageCategoryId = @beverageCategoryId where id = @id";
                    cmdUpdateBeverage.Parameters.AddWithValue("id", beverage.Id);
                    cmdUpdateBeverage.Parameters.AddWithValue("name", beverage.Name);
                    cmdUpdateBeverage.Parameters.AddWithValue("price", beverage.Price);
                    cmdUpdateBeverage.Parameters.AddWithValue("beverageCategoryId", beverage.BeverageCategory.Id);
                    cmdUpdateBeverage.ExecuteNonQuery();
                }
            }
        }

        public void DeleteBeverage(BBeverage beverage)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand cmdDeleteBeverage = connection.CreateCommand())
                {

                    cmdDeleteBeverage.CommandText = "delete from Beverage where id = @id";
                    cmdDeleteBeverage.Parameters.AddWithValue("Id", beverage.Id);
                    cmdDeleteBeverage.ExecuteNonQuery();
                }
            }
        }

        public List<BBeverage> GetAllHotDrinks()
        {
            List<BBeverage> beverages = new List<BBeverage>();
            BBeverage tempB;
            BBeverageCategory tempBC;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "select beverage.id as bid, beverage.name as bname, beverage.price as price, beverageCategory.id as id, BeverageCategory.name as name from Beverage, BeverageCategory where Beverage.beverageCategoryID = BeverageCategory.id and BeverageCategory.id = 1";
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        tempB = new BBeverage();
                        tempBC = new BBeverageCategory();
                        tempB.Id = reader.GetInt32(reader.GetOrdinal("bid"));
                        tempB.Name = reader.GetString(reader.GetOrdinal("bname"));
                        tempB.Price = reader.GetDecimal(reader.GetOrdinal("price"));
                        tempBC.Id = reader.GetInt32(reader.GetOrdinal("id"));
                        tempBC.Name = reader.GetString(reader.GetOrdinal("name"));
                        tempB.BeverageCategory = tempBC;
                        beverages.Add(tempB);
                    }
                }
            }
            return beverages;
        }

        public List<BBeverage> GetAllColdDrinks()
        {
            List<BBeverage> beverages = new List<BBeverage>();
            BBeverage tempB;
            BBeverageCategory tempBC;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "select beverage.id as bid, beverage.name as bname, beverage.price as price, beverageCategory.id as id, BeverageCategory.name as name from Beverage, BeverageCategory where Beverage.beverageCategoryID = BeverageCategory.id and BeverageCategory.id = 2";
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        tempB = new BBeverage();
                        tempBC = new BBeverageCategory();
                        tempB.Id = reader.GetInt32(reader.GetOrdinal("bid"));
                        tempB.Name = reader.GetString(reader.GetOrdinal("bname"));
                        tempB.Price = reader.GetDecimal(reader.GetOrdinal("price"));
                        tempBC.Id = reader.GetInt32(reader.GetOrdinal("id"));
                        tempBC.Name = reader.GetString(reader.GetOrdinal("name"));
                        tempB.BeverageCategory = tempBC;
                        beverages.Add(tempB);
                    }
                }
            }
            return beverages;
        }

        public List<BBeverage> GetAllVines()
        {
            List<BBeverage> beverages = new List<BBeverage>();
            BBeverage tempB;
            BBeverageCategory tempBC;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "select beverage.id as bid, beverage.name as bname, beverage.price as price, beverageCategory.id as id, BeverageCategory.name as name from Beverage, BeverageCategory where Beverage.beverageCategoryID = BeverageCategory.id and BeverageCategory.id = 3";
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        tempB = new BBeverage();
                        tempBC = new BBeverageCategory();
                        tempB.Id = reader.GetInt32(reader.GetOrdinal("bid"));
                        tempB.Name = reader.GetString(reader.GetOrdinal("bname"));
                        tempB.Price = reader.GetDecimal(reader.GetOrdinal("price"));
                        tempBC.Id = reader.GetInt32(reader.GetOrdinal("id"));
                        tempBC.Name = reader.GetString(reader.GetOrdinal("name"));
                        tempB.BeverageCategory = tempBC;
                        beverages.Add(tempB);
                    }
                }
            }
            return beverages;
        }
    }
}
