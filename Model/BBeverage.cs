using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BBeverage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public BBeverageCategory BeverageCategory { get; set; }


        public BBeverage(string name, decimal price, BBeverageCategory beverageCategory)
        {
            Name = name;
            Price = price;
            BeverageCategory = beverageCategory;
        }

        public BBeverage(int id, BBeverageCategory beverageCategory)
        {
            Id = id;
            BeverageCategory = beverageCategory;
        }


        public BBeverage(int id, string name, decimal price, BBeverageCategory beverageCategory)
        {
            Id = id;
            Name = name;
            Price = price;
            BeverageCategory = beverageCategory;
        }
        public BBeverage(int id)
        {
            Id = id;
        }

        public BBeverage()
        {

        }
    }
}

