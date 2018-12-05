using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    public class BFood {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int FoodCategoryId { get; set; }
        public BFoodCategory FoodCategory { get; set; }


        public BFood(string name, decimal price, int foodCategoryId, BFoodCategory foodCategory)
        {
            Name = name;
            Price = price;
            FoodCategory = foodCategory;
            FoodCategoryId = foodCategory.Id;
        }

        public BFood(int id, BFoodCategory foodCategory) {
            Id = id;
            FoodCategory = foodCategory;
        }


        public BFood(int id, string name, decimal price, BFoodCategory foodCategory)
        {
            Id = id;
            Name = name;
            Price = price;
            FoodCategory = foodCategory;
        }
        public BFood(int id)
        {
            Id = id;
        }

        public BFood()
        {

        }


    }

    
}

