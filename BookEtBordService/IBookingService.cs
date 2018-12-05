using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Model;

namespace BookEtBordService {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IBookingService {

        // Table
        [OperationContract]
        List<BTable> GetAllTables();
        [OperationContract]
        List<BTable> GetAllFreeTables();
        [OperationContract]
        List<BTable> GetAllReservedTables();
        [OperationContract]
        void CreateTable(int seats, bool reserved);
        [OperationContract]
        void UpdateTable(int id, int seats, bool reserved);
        [OperationContract]
        void DeleteTable(int id);

        // Food
        [OperationContract]
        List<BFood> GetAllFood();
        [OperationContract]
        void CreateFood(string name, decimal price, int foodCategoryId, BFoodCategory foodCategory);
        [OperationContract]
        void UpdateFood(int id, string name, decimal price, BFoodCategory foodCategory);
        [OperationContract]
        void DeleteFood(int id);
        [OperationContract]
        List<BFood> GetAllFoodStarters();
        [OperationContract]
        List<BFood> GetAllFoodMainCourses();
        [OperationContract]
        List<BFood> GetAllFoodDesserts();
        [OperationContract]
        List<BFood> GetAllFoodCat();
        [OperationContract]
        List<BFoodCategory> GetAllFoodCat2();

        // Beverage
        [OperationContract]
        List<BBeverage> GetAllBeverage();
        [OperationContract]
        void CreateBeverage(string name, decimal price, BBeverageCategory beverageCategory);
        [OperationContract]
        void UpdateBeverage(int id, string name, decimal price, BBeverageCategory beverageCategory);
        [OperationContract]
        void DeleteBeverage(int id);
        [OperationContract]
        List<BBeverage> GetAllHotDrinks();
        [OperationContract]
        List<BBeverage> GetAllColdDrinks();
        [OperationContract]
        List<BBeverage> GetAllVines();

        //Order
        [OperationContract]
        BOrder CreateOrder(DateTime dateTime);
        [OperationContract]
        void CreateOrderLineTable(BOrder bOrder);
        [OperationContract]
        List<BOrderLine> GetOrderLines();
    }
}
