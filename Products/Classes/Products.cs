using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Classes
{
    class Products
    {
        public string name;
        public string category;
        public DateTime expired;
        public float weight;
        public float price;

        public delegate void ShowStatus();
        public void ShowNorm()
        {

        }
        public void ShowNear()
        {

        }
        public void ShowExp()
        {

        }
    }
}
