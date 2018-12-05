using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Model;
using BookEtBordService.Controller;

namespace BookEtBordService {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class BookingService : IBookingService {
        private BOrder currOrder;
        // Table
        public List<BTable> GetAllFreeTables()
        {
            TableController tableController = new TableController();
            List<BTable> foundTables = tableController.GetAllFreeTables();
            return foundTables;
        }

        public List<BTable> GetAllReservedTables()
        {
            TableController tableController = new TableController();
            List<BTable> foundTables = tableController.GetAllReservedTables();
            return foundTables;
        }

        public List<BTable> GetAllTables()
        {
            TableController tableController = new TableController();
            List<BTable> foundTables = tableController.GetAllTables();
            return foundTables;
        }
        public void CreateTable(int seats, bool reserved) {
            BTable btable = new BTable(seats,reserved);
            TableController tableController = new TableController();
            tableController.CreateTable(btable);
        }

        public void UpdateTable(int id, int seats, bool reserved)
        {
            BTable btable = new BTable(id, seats, reserved);
            TableController tableController = new TableController();
            tableController.UpdateTable(btable);
        }

        public void DeleteTable(int id)
        {
            BTable btable = new BTable(id);
            TableController tableController = new TableController();
            tableController.DeleteTable(btable);
        }

        // Food
        public List<BFood> GetAllFood() {
            FoodController foodController = new FoodController();
            List<BFood> foundFoods = foodController.GetAllFood();
            return foundFoods;
        }

        public void CreateFood(string name, decimal price, int foodCategoryId, BFoodCategory foodCategory)
        {
            BFood food = new BFood(name, price, foodCategoryId, foodCategory);
            FoodController foodController = new FoodController();
            foodController.CreateFood(food);
        }

        public void UpdateFood(int id, string name, decimal price, BFoodCategory foodCategory)
        {
            BFood food = new BFood(id, name, price, foodCategory);
            FoodController foodController = new FoodController();
            foodController.UpdateFood(food);
        }

        public void DeleteFood(int id)
        {
            BFood food = new BFood(id);
            FoodController foodController = new FoodController();
            foodController.DeleteFood(food);
        }

        public List<BFood> GetAllFoodStarters()
        {
            FoodController foodController = new FoodController();
            List<BFood> foundFoods = foodController.GetAllFoodStarters();
            return foundFoods;
        }

        public List<BFood> GetAllFoodMainCourses()
        {
            FoodController foodController = new FoodController();
            List<BFood> foundFoods = foodController.GetAllFoodMainCourses();
            return foundFoods;
        }

        public List<BFood> GetAllFoodDesserts()
        {
            FoodController foodController = new FoodController();
            List<BFood> foundFoods = foodController.GetAllFoodDesserts();
            return foundFoods;
        }

        public List<BFood> GetAllFoodCat()
        {
            FoodController foodController = new FoodController();
            List<BFood> foundFoods = foodController.GetAllFoodCat();
            return foundFoods;
        }

        public List<BFoodCategory> GetAllFoodCat2()
        {
            FoodController foodController = new FoodController();
            List<BFoodCategory> foundCats = foodController.GetAllFoodCat2();
            return foundCats;
        }

        // Beverage 
        public List<BBeverage> GetAllBeverage()
        {
            BeverageController beverageController = new BeverageController();
            List<BBeverage> foundBeverages = beverageController.GetAllBeverage();
            return foundBeverages;
        }

        public void CreateBeverage(string name, decimal price, BBeverageCategory beverageCategory)
        {
            BBeverage beverage = new BBeverage(name, price, beverageCategory);
            BeverageController beverageController = new BeverageController();
            beverageController.CreateBeverage(beverage);
        }

        public void UpdateBeverage(int id, string name, decimal price, BBeverageCategory beverageCategory)
        {
            BBeverage beverage = new BBeverage(id, name, price, beverageCategory);
            BeverageController beverageController = new BeverageController();
            beverageController.UpdateBeverage(beverage);
        }

        public void DeleteBeverage(int id)
        {
            BBeverage beverage = new BBeverage(id);
            BeverageController beverageController= new BeverageController();
            beverageController.DeleteBeverage(beverage);
        }


        public List<BBeverage> GetAllHotDrinks() {
            BeverageController beverageController = new BeverageController();
            List<BBeverage> foundBeverages = beverageController.GetAllHotDrinks();
            return foundBeverages;
        }

        public List<BBeverage> GetAllColdDrinks() {
            BeverageController beverageController = new BeverageController();
            List<BBeverage> foundBeverages = beverageController.GetAllColdDrinks();
            return foundBeverages;
        }

        public List<BBeverage> GetAllVines() {
            BeverageController beverageController = new BeverageController();
            List<BBeverage> foundBeverages = beverageController.GetAllVines();
            return foundBeverages;
        }

        public BOrder CreateOrder(DateTime dateTime)
        {
            currOrder = new BOrder(dateTime);
            OrderController orderController = new OrderController();
            orderController.CreateOrder(dateTime);
            return currOrder;
        }

        public void CreateOrderLineTable(BOrder currOrder) {

            OrderController orderController = new OrderController();
            orderController.CreateOrderLineTable(currOrder);



        }

        public BOrderLine CreateOrderLineFood(int quantity, BFood bFood, BOrder bOrder)
        {
            throw new NotImplementedException();
        }

        public List<BOrderLine> GetOrderLines()
        {
            List<BOrderLine> getOrderLines = currOrder.GetOrderLines();
            return getOrderLines;


        }


    }

}
