using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorePricingCalculator
{
    class ProductCart
    {
        public int SelectProduct()
        {
            Console.WriteLine("Please select a product to be added to shopping cart");
            int product = int.Parse(Console.ReadLine());
            return product;
        }

        public double AddSelectedProductToCart(int product, double totalProductPriceWithDiscount)
        {
            double priceOfSelectedProduct = 0;

            int quantityOfSelectedProduct = 0;

            double productPriceWithDiscount = 0;

            double productPriceWithoutDiscount = 0;

            PricingCalculator price = new PricingCalculator();

            priceOfSelectedProduct = EnterPriceOfSelectedProduct();

            quantityOfSelectedProduct = QuantityOfSelectedProduct();

            productPriceWithoutDiscount = price.CaclulateProductPriceWithoutDiscount(priceOfSelectedProduct, quantityOfSelectedProduct);

            productPriceWithDiscount = price.CaclulateProductPriceWithDiscount(product, priceOfSelectedProduct, quantityOfSelectedProduct);

            totalProductPriceWithDiscount = totalProductPriceWithDiscount + productPriceWithDiscount;

            return totalProductPriceWithDiscount;
        }

        public double EnterPriceOfSelectedProduct()
        {
            Console.WriteLine("Enter price of the product: ");

            double costOfProduct = double.Parse(Console.ReadLine());

            return costOfProduct;
        }

        public int QuantityOfSelectedProduct()
        {
            Console.WriteLine("Enter  the quantity of selected product: ");

            int quantityOfProduct = int.Parse(Console.ReadLine());

            return quantityOfProduct;
        }
    }
}
