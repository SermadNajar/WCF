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
    public class DBOrderLine
    {
        private string _connectionString;

        public DBOrderLine()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        }

        public List<BOrderLine> SaveOrderLines(int oId, List<BOrderLine> orderLines)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand cmdInsertProdo = connection.CreateCommand())
                {
                    try {
                        foreach (BOrderLine ol in orderLines) {
                            cmdInsertProdo.CommandText = "INSERT INTO OrderLine(tableId, orderId) VALUES(@tableId, @orderId)";
                            cmdInsertProdo.Parameters.AddWithValue("tableId", ol.TableId.Id);
                            cmdInsertProdo.Parameters.AddWithValue("orderId", oId);
                            cmdInsertProdo.ExecuteNonQuery();
                        }
                    }
                    catch (ArgumentNullException e) {
                        Console.WriteLine("{0} First exception caught.", e);
                    }

                    return orderLines;
                }
                
            }
        }
    }
}
