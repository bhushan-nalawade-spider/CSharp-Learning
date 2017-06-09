using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorePricingCalculator
{
    class PricingCalculator
    {
        public double CaclulateProductPriceWithoutDiscount(double priceOfSelectedProduct, int quantityOfSelectedProduct)
        {
            double totalPriceOfSelectedProductWithoutDiscount = priceOfSelectedProduct * quantityOfSelectedProduct;

            return totalPriceOfSelectedProductWithoutDiscount;
        }

        public double CaclulateProductPriceWithDiscount(int selectedProduct, double priceOfSelectedProduct, int quantityOfSelectedProduct)
        {
            DiscountCalculator discount = new DiscountCalculator();

            double discountedPriceOfProduct = discount.ProductLevelDiscount(selectedProduct, priceOfSelectedProduct, quantityOfSelectedProduct);

            double discountedPriceOfProductIncludingWeekdayDiscount = discount.WeekdayDiscount(discountedPriceOfProduct);

            return discountedPriceOfProductIncludingWeekdayDiscount;
        }
    }
}
