using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    public class Product
    {
        public Product(int number, string name, decimal price)
        {
            IDNumber = number;
            Name = name;
            Price = price;
        }

        public int IDNumber { get; }
        public string Name { get; }
        public decimal Price { get; }
    }
}
