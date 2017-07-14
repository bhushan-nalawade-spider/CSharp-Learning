using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr7_SalesPriceCalculator
{
    public class GroceryItem
    {
        public GroceryItem()
        {

        }

        public GroceryItem(String itemName, double itemPrice)
        {
            this.itemName = itemName;
            this.itemPrice = itemPrice;
        }
        private String itemName = "";
        private double itemPrice = 0.0;

        public String GetItemName()
        {
            return itemName;
        }

        public void SetItemName(String itemName)
        {
            this.itemName = itemName;
        }

        public double GetItemPrice()
        {
            return itemPrice;
        }

        public void SetItemPrice(double itemPrice)
        {
            this.itemPrice = itemPrice;
        }
    }
}
