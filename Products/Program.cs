using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Products.Classes;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            Product one = new Product();
            one.expired = DateTime.Now.AddDays(20);
            one.Examine();
            
        }
    }
}
