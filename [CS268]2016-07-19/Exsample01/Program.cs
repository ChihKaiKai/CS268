using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreLibrary;

namespace Exsample01
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[]{
            new Product()
            {
                Name = "iPhone6S",
                Price = 24500
            },
            new Product()
            {
                Name = "iPhone6Splus",
                Price = 28500
            }
            };

            Array.Sort(products);
            foreach (var product in products)
                Console.WriteLine(product);


        }
    }
}
