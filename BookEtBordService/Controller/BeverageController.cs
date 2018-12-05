using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using BookEtBordService.DataAccessLayer;

namespace BookEtBordService.Controller {
    class BeverageController
    {
        public List<BBeverage> GetAllBeverage()
        {
            DBBeverage dBBeverage = new DBBeverage();
            List<BBeverage> foundBeverages = dBBeverage.GetAllBeverage();
            return foundBeverages;
        }

        public void CreateBeverage(BBeverage beverage)
        {
            DBBeverage dBBeverage = new DBBeverage();
            dBBeverage.CreateBeverage(beverage);
        }

        public void UpdateBeverage(BBeverage beverage)
        {
            DBBeverage dBBeverage = new DBBeverage();
            dBBeverage.UpdateBeverage(beverage);

        }

        public void DeleteBeverage(BBeverage beverage)
        {
            DBBeverage dBBeverage = new DBBeverage();
            dBBeverage.DeleteBeverage(beverage);

        }

        public List<BBeverage> GetAllHotDrinks()
        {
            DBBeverage dBBeverage = new DBBeverage();
            List<BBeverage> foundBeverages = dBBeverage.GetAllHotDrinks();
            return foundBeverages;
        }

        public List<BBeverage> GetAllColdDrinks()
        {
            DBBeverage dBBeverage = new DBBeverage();
            List<BBeverage> foundBeverages = dBBeverage.GetAllColdDrinks();
            return foundBeverages;
        }

        public List<BBeverage> GetAllVines()
        {
            DBBeverage dBBeverage = new DBBeverage();
            List<BBeverage> foundBeverages = dBBeverage.GetAllVines();
            return foundBeverages;
        }
    }
}
