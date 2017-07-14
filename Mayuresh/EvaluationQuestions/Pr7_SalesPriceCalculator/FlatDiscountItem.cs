using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr7_SalesPriceCalculator
{
    class FlatDiscountItem : GroceryItem
    {
        double discountPercentage = 0.0;
        double discountedPrice = 0.0;

        public FlatDiscountItem()
        {

        }

        public FlatDiscountItem(String itemName, double itemPrice) : base(itemName, itemPrice)
        {
            
        }

        public FlatDiscountItem(String itemName, double itemPrice, double discountPercentage)
            : base(itemName, itemPrice)
        {
            this.discountPercentage = discountPercentage;
            SetDiscountPrice(this.discountPercentage);
        }

       
        public double GetDiscountPercentage()
        {
            return discountPercentage;
        }

        public void SetDiscountPercentage(double discountPercentage)
        {
            this.discountPercentage = discountPercentage;
            SetDiscountPrice(this.discountPercentage);
        }

        public double GetDiscountPrice()
        {
            return discountedPrice;
        }

        private void SetDiscountPrice(double discountPercentage)
        {

            this.discountedPrice = (100 - GetDiscountPercentage()) * base.GetItemPrice() / 100;
        }


    }
}
