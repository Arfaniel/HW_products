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
            Product[] one = new Product[5];
            for (int i = 0; i < one.Length; i++)
            {
                one[i] = new Product();
            }
            one[0].expired = DateTime.Now.AddDays(11);
            one[1].expired = DateTime.Now.AddDays(1);
            one[2].expired = DateTime.Now;
            one[3].expired = DateTime.Now.AddDays(-1);
            one[4].expired = DateTime.Now.AddDays(-5);
            foreach (Product item in one)
            {
                item.Examine();
                item.Show();
            }
        }
    }
}
