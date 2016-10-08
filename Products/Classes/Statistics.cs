using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Classes
{
    public class Statistics
    {
        public delegate void counter(Product[] one);
       
         private void TotalSum(Product[] one)
        {
            float sum = 0F;
            for (int i = 0; i < one.Length; i++)
            {
                sum += one[i].price;
            }
            Console.WriteLine($"Total price is: {sum}");
        }
        private void SumExp(Product[] one)
        {
            float sum = 0F;
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
        private void avgPrice(Product[] one)
        {
            float sum = 0F;
            int i = 0;
            for (; i < one.Length; i++)
            {
                sum += one[i].price;
            }
            sum = sum / i;
            Console.WriteLine($"Average price is: {sum}" );
        }
        private void TotalWeight(Product[] one)
        {
            float sum = 0F;
            for (int i = 1; i < one.Length; i++)
            {
                sum += one[i].weight;
            }
            Console.WriteLine($"Total weight is {sum}");
        }
        public void Menu(Product[] one)
        {
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            counter expCount = null;
            Console.WriteLine("Собираем отчет:");
            Console.WriteLine("Стоимость всех товаров \t Добавить - ПРОБЕЛ");
            key = Console.ReadKey();
            if(key.Key == ConsoleKey.Spacebar)
            {
                expCount += TotalSum;
            }
            Console.WriteLine("Стоимость всех просроченных товаров \t Добавить - ПРОБЕЛ");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Spacebar)
            {
                expCount += SumExp;
            }
            Console.WriteLine("Средняя цена одного товара \t Добавить - ПРОБЕЛ");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Spacebar)
            {
                expCount += avgPrice;
            }
            Console.WriteLine("Общий вес всех товаров \t Добавить - ПРОБЕЛ");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Spacebar)
            {
                expCount += TotalWeight;
            }
            expCount(one);
        }

    }
}
