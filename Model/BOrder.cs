using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BOrder
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public List<BOrderLine> OrderLines;

        public BOrder()
        {
        }

        public BOrder(DateTime dateTime)
        {
            DateTime = dateTime;
            OrderLines = new List<BOrderLine>();
        }

        public void AddOrderLine(BOrderLine ol)
        {
            OrderLines.Add(ol);
        }

        public List<BOrderLine> GetOrderLines()
        {
            return OrderLines;
        }

        public void SetOrderLines(List<BOrderLine> orderLines)
        {
            OrderLines = orderLines;
        }
    }
}
