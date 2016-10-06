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
            one[0].price = 2.3F;
            one[1].price = 2.6F;
            one[2].price = 8.57F;
            one[3].price = 64.84F;
            one[4].price = 5.34F;
            one[0].weight = 21.45F;
            one[1].weight = 843.5F;
            one[2].weight = 48.2F;
            one[3].weight = 35.25F;
            one[4].weight = 5.64F;

            foreach (Product item in one)
            {
                item.Examine();
                item.Show();
            }
            Statistics stat = new Statistics();
            stat.Menu(one);
        }
    }
}
