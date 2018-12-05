using BookEtBordService.DataAccessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookEtBordService.Controller
{
    public class OrderController
    {
        private BOrder currOrder;


        public BOrder CreateOrder(DateTime dateTime)
        {
            currOrder = new BOrder(dateTime);
            //DBOrder dBOrder = new DBOrder();
            currOrder.DateTime = DateTime.Now;
            //dBOrder.CreateOrder(currOrder);
            return currOrder;

        }


        public void CreateOrderLineTable(BOrder currOrder)
        {
            DBOrder dbOrder = new DBOrder();
            dbOrder.FinishOrder(currOrder);


        }

        public bool FinishOrder() {
            bool isAllOk = true;
            if (isAllOk) {
                DBOrder dbOrder = new DBOrder();
                dbOrder.FinishOrder(currOrder);
            }
            return isAllOk;
        }


    }
}
