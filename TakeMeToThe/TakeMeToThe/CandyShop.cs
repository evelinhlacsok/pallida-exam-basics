using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeMeToThe
{
    class CandyShop
    {
        List<Sweets> CandyShopsStorage = new List<Sweets>();

        public void CreateSweets(Sweets sweets)
        {
            sweets.CreateSweets(sweets);
        }
    }
}
