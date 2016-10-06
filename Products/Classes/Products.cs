using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Products;

namespace Products.Classes
{
    public class Product
    {
        public string name;
        public string category;
        public DateTime expired;
        public float weight;
        public float price;

        public delegate void ShowStatus();
        ShowStatus Status = null;

        public void ShowWhite()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(expired);
            Console.ResetColor();
        }
        public void ShowGreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(expired);
            Console.ResetColor();
        }
        public void ShowRed()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(expired);
            Console.ResetColor();
        }
        public void Examine()
        {
            DateTime now = DateTime.Now;
            if (expired <= now)
            {
                Status = new ShowStatus(ShowRed);
            }
            if (expired < now.AddDays(10))
            {
                Status = new ShowStatus(ShowGreen);
            }
            else
            {
                Status = new ShowStatus(ShowWhite);
            }
                


        }
        public void Show()
        {
            Status();
        }
    }
}
