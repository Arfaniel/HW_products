using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Classes
{
    public class Statistics
    {
        public delegate int counter();
        

        public void TotalSum(Product[] one)
        {
            float sum = one[0].price;
            for (int i = 1; i < one.Length; i++)
            {
                sum += one[i].price;
            }
            Console.WriteLine($"Total price is: {sum}");
        }
        public void SumExp(Product[] one)
        {
            float sum = 0;
            DateTime now = DateTime.Now;
            for (int i = 1; i < one.Length; i++)
            {
                if (one[i].expired <= now)
                {
                    sum += one[i].price;
                }
            }
            Console.WriteLine($"Total price for all expired prods is: {sum}"); 
        }
        public void avgPrice(Product[] one)
        {
            float sum = 0;
            int i = 0;
            for (; i < one.Length; i++)
            {
                sum += one[i].price;
            }
            sum = sum / i;
            Console.WriteLine($"Average price is: {sum}" );
        }
        public void TotalWeight(Product[] one)
        {
            float sum = 0;
            for (int i = 1; i < one.Length; i++)
            {
                sum += one[i].weight;
            }
            Console.WriteLine($"Total weight is {sum}");
        }
        public void Menu()
        {
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            counter expCount = null;
            do
            {
                Console.WriteLine();
            } while (key.Key != ConsoleKey.Escape);
        }

    }
}
