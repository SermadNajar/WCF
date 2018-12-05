using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BTable
    {
        public int Id { get; set; }
        public int Seats { get; set; }
        public bool Reserved { get; set; }

        public BTable(int seats, bool reserved) { 
            Seats = seats;
            Reserved = reserved;
        }

        public BTable(int id, int seats, bool reserved)
        {
            Id = id;
            Seats = seats;
            Reserved = reserved;
        }
        public BTable(int id)
        {
            Id = id;
        }

        public BTable()
        {
                
        }
    }
}
