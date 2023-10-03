using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListApp
{
    internal class ListItemsName
    {
        public int Id { get; set; }
        public string Name { get; set; }   
        public int Unit { get; set; }

        public double Amount { get; set; }

        public double Balance { get { return Unit * Amount; } }

        public ListItemsName(int id,string name,int unit,double amount) {
        
            Id = id;
            Name = name;
            Unit = unit;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"{Name},{Amount}";
        }
     
    }
}
