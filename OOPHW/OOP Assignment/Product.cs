using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHW
{
   public class Product
    {
        private string name = "Jawaher";
        private double price = 30.00;
        private int quantity = 6;
        public double TotalCost()
        {
            return price * quantity;
        }
        public double TotalCost(double price, double quantity)
        { 
            return price * quantity;
        }
    }
}
