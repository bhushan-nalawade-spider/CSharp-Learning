using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorePricingCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalPriceWithDiscount = 0;

            ProductCatalogue catalogue = new ProductCatalogue();

            Menu:

            Console.Clear();

            catalogue.DisplayCatalogue();

            ProductCart cart = new ProductCart();

            int product = cart.SelectProduct();

            if (product == 8)
            {
                Console.WriteLine("Total: " + totalPriceWithDiscount);

                Environment.Exit(0);
            }
            else
            {
                double totalDiscountedPrice = cart.AddSelectedProductToCart(product, totalPriceWithDiscount);

                totalPriceWithDiscount = totalDiscountedPrice;

                goto Menu;
            }
            

        }
    }
}
