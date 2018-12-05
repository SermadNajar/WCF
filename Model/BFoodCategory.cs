using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    public class BFoodCategory {
        public int Id { get; set; }
        public string Name { get; set; }

        public BFoodCategory(int id, string name) {
            Id = id;
            Name = name;
        }

        public BFoodCategory() {

        }
    }
}
