using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeMeToThe
{
    class CandyShop
    {
        public double sugarAmount;
        public int money;

        public CandyShop(double sugarAmount)
        {
            this.sugarAmount = sugarAmount;
        }
        List<Sweets> CandyShopsStorage = new List<Sweets>();

        public void CreateSweets(Sweets sweets)
        {
            CandyShopsStorage.Add(sweets);
        }
    }
}
