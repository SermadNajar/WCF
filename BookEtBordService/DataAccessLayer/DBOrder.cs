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
    public class DBOrder
    {
        
        private string _connectionString;

        public DBOrder()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        }

        public BOrder CreateOrder(BOrder currOrder)
        {
            int oId = 0;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand cmdInsertProd = connection.CreateCommand())
                {

                    cmdInsertProd.CommandText = "INSERT INTO BOrder(orderDate) output INSERTED.ID VALUES(@orderDate)";
                    cmdInsertProd.Parameters.AddWithValue("orderDate", currOrder.DateTime);
                    oId = (int)cmdInsertProd.ExecuteScalar();


                }
            }
            DBOrderLine dbOrderline = new DBOrderLine();
            List<BOrderLine> ols = dbOrderline.SaveOrderLines(oId, currOrder.GetOrderLines());
            //currOrder.SetOrderLines(ols);
            return currOrder;
        }

        public void FinishOrder(BOrder currOrder)
        {
            CreateOrder(currOrder);
        }


    }
}
