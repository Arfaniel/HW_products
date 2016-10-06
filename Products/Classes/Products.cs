using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Classes
{
    public class Product
    {
        public string name;
        public string category;
        public DateTime expired;
        public float weight;
        public float price;

        public delegate string ShowStatus();
        public ShowStatus Status;

        public string ShowWhite()
        {
            Console.ForegroundColor = ConsoleColor.White;
            return expired.ToShortDateString();
        }
        public string ShowGreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            return expired.ToShortDateString();
        }
        public string ShowRed()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            return expired.ToShortDateString();
        }
        public void Examine()
        {
            DateTime now = DateTime.Now;
            if (expired <= now)
            {
                Status = ShowRed;
            }
            if (expired < now.AddDays(10))
            {
                Status = ShowGreen;
            }
            else
            {
                Status = ShowWhite;
            }
                
        }
    }
}
