using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BBeverageCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public BBeverageCategory(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public BBeverageCategory()
        {

        }
    }
}