using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorePricingCalculator
{
    class DiscountCalculator
    {
        public double ProductLevelDiscount(int selectedProduct, double priceOfSelectedProduct, int quantityOfSelectedProduct)
        {
            double discountedPriceOfProduct = 0;

            if (selectedProduct == 1)
            {
                discountedPriceOfProduct = priceOfSelectedProduct - ((10 * priceOfSelectedProduct) / 100);
            }
            else if (selectedProduct == 2)
            {
                discountedPriceOfProduct = priceOfSelectedProduct - ((10 * priceOfSelectedProduct) / 100);
            }
            else if (selectedProduct == 3)
            {
                discountedPriceOfProduct = priceOfSelectedProduct;
            }
            else if (selectedProduct == 4)
            {
                discountedPriceOfProduct = priceOfSelectedProduct;
            }
            else if (selectedProduct == 5)
            {
                discountedPriceOfProduct = priceOfSelectedProduct;
            }
            else if (selectedProduct == 6)
            {
                discountedPriceOfProduct = priceOfSelectedProduct - ((05 * priceOfSelectedProduct) / 100);
            }
            else if (selectedProduct == 7)
            {
                discountedPriceOfProduct = priceOfSelectedProduct;
            }

            discountedPriceOfProduct = discountedPriceOfProduct * quantityOfSelectedProduct;

            return discountedPriceOfProduct;

        }

        public double WeekdayDiscount(double discountedPriceOfProduct)
        {
            double discountedPriceOfProductIncludingWeekdayDiscount = 0;

            int todaysDay = (int)System.DateTime.Now.DayOfWeek;

            switch (todaysDay)
            {
                case 1:
                    discountedPriceOfProductIncludingWeekdayDiscount = discountedPriceOfProduct - ((02 * discountedPriceOfProduct) / 100);
                    break;
                case 2:
                    discountedPriceOfProductIncludingWeekdayDiscount = discountedPriceOfProduct;
                    break;
                case 3:
                    discountedPriceOfProductIncludingWeekdayDiscount = discountedPriceOfProduct - ((05 * discountedPriceOfProduct) / 100);
                    break;
                case 4:
                    discountedPriceOfProductIncludingWeekdayDiscount = discountedPriceOfProduct;
                    break;
                case 5:
                    discountedPriceOfProductIncludingWeekdayDiscount = discountedPriceOfProduct - ((05 * discountedPriceOfProduct) / 100);
                    break;
                case 6:
                    discountedPriceOfProductIncludingWeekdayDiscount = discountedPriceOfProduct;
                    break;
                case 7:
                    discountedPriceOfProductIncludingWeekdayDiscount = discountedPriceOfProduct;
                    break;
            }
            return discountedPriceOfProductIncludingWeekdayDiscount;
        }
    }
}
