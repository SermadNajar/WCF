using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using System.Configuration;

namespace BookEtBordService.DataAccessLayer {
    class DBFood {
        private string _connectionString;

        public DBFood() {
            _connectionString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        }

        public List<BFood> GetAllFood() {
            List<BFood> foods = new List<BFood>();
            BFood tempF;
            BFoodCategory tempFC;

            using (SqlConnection connection = new SqlConnection(_connectionString)) {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand()) {
                    cmd.CommandText = "select food.id as fid, food.name as fname, food.price as price, foodcategory.id as id, FoodCategory.name as name from Food, FoodCategory where Food.foodCategoryID = FoodCategory.id";
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read()) {
                        tempF = new BFood();
                        tempFC = new BFoodCategory();
                        tempF.Id = reader.GetInt32(reader.GetOrdinal("fid"));
                        tempF.Name = reader.GetString(reader.GetOrdinal("fname"));
                        tempF.Price = reader.GetDecimal(reader.GetOrdinal("price"));
                        tempFC.Id = reader.GetInt32(reader.GetOrdinal("id"));
                        tempFC.Name = reader.GetString(reader.GetOrdinal("name"));
                        tempF.FoodCategory = tempFC;
                        foods.Add(tempF);
                    }
                }
            }
            return foods;
        }

        public List<BFoodCategory> GetAllFoodCat2()
        {
            List<BFoodCategory> foodCats = new List<BFoodCategory>();
            BFoodCategory tempFC;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {


                    cmd.CommandText = "select FoodCategory.id, FoodCategory.name  from FoodCategory;";
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        tempFC = new BFoodCategory(); 
                        tempFC.Id = reader.GetInt32(reader.GetOrdinal("id"));
                        tempFC.Name = reader.GetString(reader.GetOrdinal("name"));
                        foodCats.Add(tempFC);
                    }
                }
            }
            return foodCats;
        }

        public List<BFood> GetAllFoodCat()
        {
            List<BFood> foods = new List<BFood>();
            BFood tempF;
            BFoodCategory tempFC;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    

                    cmd.CommandText = "select fo.id as id, fo.name, fo.price, fo.foodCategoryId, fc.id as category, fc.name as foodCategoryName from Food fo RIGHT OUTER JOIN FoodCategory fc ON fo.foodCategoryId = fc.id";
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        tempF = new BFood();
                        tempFC = new BFoodCategory();
                        tempF.Id = reader.GetInt32(reader.GetOrdinal("id"));
                        tempF.Name = reader.GetString(reader.GetOrdinal("name"));
                        tempF.Price = reader.GetDecimal(reader.GetOrdinal("price"));
                        tempF.FoodCategoryId = reader.GetInt32(reader.GetOrdinal("foodCategoryId"));
                        tempFC.Id = reader.GetInt32(reader.GetOrdinal("category"));
                        tempFC.Name = reader.GetString(reader.GetOrdinal("foodCategoryName"));
                        tempF.FoodCategory = tempFC;
                        foods.Add(tempF);
                    }
                }
            }
            return foods;
        }

        public List<BFood> GetAllFoodStarters() {
            List<BFood> foods = new List<BFood>();
            BFood tempF;
            BFoodCategory tempFC;

            using (SqlConnection connection = new SqlConnection(_connectionString)) {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand()) {
                    cmd.CommandText = "select food.id as fid, food.name as fname, food.price as price, foodcategory.id as id, FoodCategory.name as name from Food, FoodCategory where Food.foodCategoryID = FoodCategory.id and FoodCategory.id = 1";
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read()) {
                        tempF = new BFood();
                        tempFC = new BFoodCategory();
                        tempF.Id = reader.GetInt32(reader.GetOrdinal("fid"));
                        tempF.Name = reader.GetString(reader.GetOrdinal("fname"));
                        tempF.Price = reader.GetDecimal(reader.GetOrdinal("price"));
                        tempFC.Id = reader.GetInt32(reader.GetOrdinal("id"));
                        tempFC.Name = reader.GetString(reader.GetOrdinal("name"));
                        tempF.FoodCategory = tempFC;
                        foods.Add(tempF);
                    }
                }
            }
            return foods;
        }

        public List<BFood> GetAllFoodMainCourses() {
            List<BFood> foods = new List<BFood>();
            BFood tempF;
            BFoodCategory tempFC;

            using (SqlConnection connection = new SqlConnection(_connectionString)) {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand()) {
                    cmd.CommandText = "select food.id as fid, food.name as fname, food.price as price, foodcategory.id as id, FoodCategory.name as name from Food, FoodCategory where Food.foodCategoryID = FoodCategory.id and FoodCategory.id = 2";
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read()) {
                        tempF = new BFood();
                        tempFC = new BFoodCategory();
                        tempF.Id = reader.GetInt32(reader.GetOrdinal("fid"));
                        tempF.Name = reader.GetString(reader.GetOrdinal("fname"));
                        tempF.Price = reader.GetDecimal(reader.GetOrdinal("price"));
                        tempFC.Id = reader.GetInt32(reader.GetOrdinal("id"));
                        tempFC.Name = reader.GetString(reader.GetOrdinal("name"));
                        tempF.FoodCategory = tempFC;
                        foods.Add(tempF);
                    }
                }
            }
            return foods;
        }

        public List<BFood> GetAllFoodDesserts() {
            List<BFood> foods = new List<BFood>();
            BFood tempF;
            BFoodCategory tempFC;

            using (SqlConnection connection = new SqlConnection(_connectionString)) {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand()) {
                    cmd.CommandText = "select food.id as fid, food.name as fname, food.price as price, foodcategory.id as id, FoodCategory.name as name from Food, FoodCategory where Food.foodCategoryID = FoodCategory.id and FoodCategory.id = 3";
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read()) {
                        tempF = new BFood();
                        tempFC = new BFoodCategory();
                        tempF.Id = reader.GetInt32(reader.GetOrdinal("fid"));
                        tempF.Name = reader.GetString(reader.GetOrdinal("fname"));
                        tempF.Price = reader.GetDecimal(reader.GetOrdinal("price"));
                        tempFC.Id = reader.GetInt32(reader.GetOrdinal("id"));
                        tempFC.Name = reader.GetString(reader.GetOrdinal("name"));
                        tempF.FoodCategory = tempFC;
                        foods.Add(tempF);
                    }
                }
            }
            return foods;
        }


        public void CreateFood(BFood food)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand cmdInsertFood = connection.CreateCommand())
                {

                    cmdInsertFood.CommandText = "INSERT INTO Food(Name, Price, FoodCategoryId) VALUES(@Name, @Price, @FoodCategoryId)";
                    cmdInsertFood.Parameters.AddWithValue("Name", food.Name);
                    cmdInsertFood.Parameters.AddWithValue("Price", food.Price);
                    cmdInsertFood.Parameters.AddWithValue("foodCategoryId", food.FoodCategoryId);
                    cmdInsertFood.ExecuteNonQuery();
                }
            }
        }

        public void UpdateFood(BFood food)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand cmdUpdateFood = connection.CreateCommand())
                {
                    
                    cmdUpdateFood.CommandText = "update food set name = @name, price = @price, foodCategoryId = @foodCategoryId where id = @id";
                    cmdUpdateFood.Parameters.AddWithValue("id", food.Id);
                    cmdUpdateFood.Parameters.AddWithValue("name", food.Name);
                    cmdUpdateFood.Parameters.AddWithValue("price", food.Price);
                    cmdUpdateFood.Parameters.AddWithValue("foodCategoryId", food.FoodCategory.Id);
                    cmdUpdateFood.ExecuteNonQuery();
                }
            }
        }

        public void DeleteFood(BFood food)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand cmdDeleteFood = connection.CreateCommand())
                {

                    cmdDeleteFood.CommandText = "delete from Food where id = @id";
                    cmdDeleteFood.Parameters.AddWithValue("Id", food.Id);
                    cmdDeleteFood.ExecuteNonQuery();
                }
            }
        }
    }
    

}
