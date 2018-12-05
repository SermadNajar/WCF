using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using BookEtBordService.DataAccessLayer;

namespace BookEtBordService.Controller {
    class FoodController {
        public List<BFood> GetAllFood() {
            DBFood dBFood = new DBFood();
            List<BFood> foundFoods = dBFood.GetAllFood();
            return foundFoods;
        }
        public void CreateFood(BFood food)
        {
            DBFood dBFood = new DBFood();
            dBFood.CreateFood(food);
        }

        public void UpdateFood(BFood food)
        {
            DBFood dBFood = new DBFood();
            dBFood.UpdateFood(food);

        }

        public void DeleteFood(BFood food)
        {
            DBFood dBFood = new DBFood();
            dBFood.DeleteFood(food);

        }


        public List<BFood> GetAllFoodStarters() {
            DBFood dBFood = new DBFood();
            List<BFood> foundFoods = dBFood.GetAllFoodStarters();
            return foundFoods;
        }

        public List<BFood> GetAllFoodMainCourses() {
            DBFood dBFood = new DBFood();
            List<BFood> foundFoods = dBFood.GetAllFoodMainCourses();
            return foundFoods;
        }

        public List<BFood> GetAllFoodDesserts() {
            DBFood dBFood = new DBFood();
            List<BFood> foundFoods = dBFood.GetAllFoodDesserts();
            return foundFoods;
        }

        public List<BFood> GetAllFoodCat()
        {
            DBFood dBFood = new DBFood();
            List<BFood> foundFoods = dBFood.GetAllFoodCat();
            return foundFoods;
        }

        public List<BFoodCategory> GetAllFoodCat2()
        {
            DBFood dBFood = new DBFood();
            List<BFoodCategory> foundCats = dBFood.GetAllFoodCat2();
            return foundCats;
        }
    }

}

