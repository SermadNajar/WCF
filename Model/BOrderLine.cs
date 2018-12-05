using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BOrderLine
    {
        public int Id { get; set; }
        public int Quanitity { get; set; }
        public BTable TableId { get; set; }
        public BFood FoodId { get; set; }
        public BOrder OrderId { get; set; }


        public BOrderLine(BTable tableId, BOrder orderId)
        {

            TableId = tableId;
            OrderId = orderId;
        }

        public BOrderLine(int quanitity, BFood foodId, BOrder orderId)
        {
            Quanitity = quanitity;
            FoodId = foodId;
            OrderId = orderId;
        }

        public BOrderLine()
        {
        }


    }
}
