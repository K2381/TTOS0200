using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra8
{
   
    public class Product
    {
       public string Name { get; set; }
       public string Price { get; set; }

        public Product()
        {

        }

        public Product(string name,string price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", Name, Price);
        }
    }





}
