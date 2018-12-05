using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using BookEtBordService.DataAccessLayer;

namespace BookEtBordService.Controller {
    class TableController {
        public List<BTable> GetAllTables() {
            DBTable dBTable = new DBTable();
            List<BTable> foundTables = dBTable.GetAllTables();
            return foundTables;
        }

        public List<BTable> GetAllFreeTables() {
            DBTable dBTable = new DBTable();
            List<BTable> foundTables = dBTable.GetAllFreeTables();
            return foundTables;
        }

        public List<BTable> GetAllReservedTables() {
            DBTable dBTable = new DBTable();
            List<BTable> foundTables = dBTable.GetAllReservedTables();
            return foundTables;
        }

        public void CreateTable(BTable btable)
        {
            DBTable dBTable = new DBTable();
            dBTable.CreateTable(btable);

        }

        public void UpdateTable(BTable btable)
        {
            DBTable dBTable = new DBTable();
            dBTable.UpdateTable(btable);

        }

        public void DeleteTable(BTable btable)
        {
            DBTable dBTable = new DBTable();
            dBTable.DeleteTable(btable);

        }

    }
}
