using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr7_SalesPriceCalculator
{
    class Pr7_SalesPriceCalculator
    {
        static void Main(string[] args)
        {
            FlatDiscountItem cocaCola = new FlatDiscountItem("Coca Cola", 58, 10);
            FlatDiscountItem thumsUp = new FlatDiscountItem("Thums-Up", 60, 25);

            UnitDiscountItem pears = new UnitDiscountItem("Pears", 45, 3, 1);
            UnitDiscountItem surfExcel = new UnitDiscountItem("Surf Excel", 130, 2, 1);

            GroceryItem amulCheese = new GroceryItem("Amul Cheese", 100);

            Dictionary<GroceryItem, int> groceryList = new Dictionary<GroceryItem, int>();
            Dictionary<String, double> weekdayOffers = new Dictionary<string, double>();

            groceryList = AddItemToList(groceryList, cocaCola, 1);
            groceryList = AddItemToList(groceryList, thumsUp, 3);
            groceryList = AddItemToList(groceryList, pears, 4);
            groceryList = AddItemToList(groceryList, surfExcel, 2);
            groceryList = AddItemToList(groceryList, amulCheese, 1);

            weekdayOffers.Add("Monday", 2);
            weekdayOffers.Add("Wednesday", 5);
            weekdayOffers.Add("Friday", 3);


            double originalBillAmount = CalculateOriginalBillForGroceries(groceryList);
            double totalBillAmount = CalculateDiscountedBillForGroceries(groceryList);
            double finalBillAmount = CalculateBillAfterDiscountOnTotalAmount(totalBillAmount, weekdayOffers, DateTime.Now);

            DisplayBill(groceryList, originalBillAmount, totalBillAmount, finalBillAmount, DateTime.Now);
            Console.Read();
        }

        private static double CalculateBillAfterDiscountOnTotalAmount(double totalBillAmount, Dictionary<String, double> weekdayOffers, DateTime dateTime)
        {
            String[] discounts = weekdayOffers.Keys.ToArray<String>();
            double finalBillAmount = 0;
            finalBillAmount = totalBillAmount * (100 - weekdayOffers[dateTime.DayOfWeek.ToString()]) / 100;
            
            return finalBillAmount;
        }

        private static void DisplayBill(Dictionary<GroceryItem, int> groceryList, double originalBillAmount, double totalBillAmount, double finalBillAmount, DateTime dateTime)
        {
            Console.WriteLine("Date: " + "\t" + dateTime.Date + "\t" + dateTime.DayOfWeek + "\t" + dateTime.TimeOfDay);
            Console.WriteLine("Name \t Quantity \t Original Price \t Discount Type \t Final Price");
            foreach(GroceryItem item in groceryList.Keys)
            {
                double itemBillAmount = 0;
                String discountType = "No Discount";
                String itemType = item.GetType().ToString();

                itemBillAmount = CalculateFlatDiscountOnItem(groceryList, item, itemBillAmount, itemType);

                discountType = DisplayDiscountTypeForItem(item, discountType, itemType);

                Console.WriteLine(item.GetItemName() + "\t" + groceryList[item] + "\t" + CalculateItemPriceBasedOnQuantity(groceryList, item) + "\t" + discountType + "\t" + itemBillAmount);
            }

            Console.WriteLine("\nOriginal Bill: " + originalBillAmount + "\n" + "Bill after individual discounts: " + totalBillAmount + "\n" + "Bill After daily Discounts (Final Bill): " + finalBillAmount);
        }

        private static string DisplayDiscountTypeForItem(GroceryItem item, String discountType, String itemType)
        {
            switch (itemType)
            {
                case "Pr7_SalesPriceCalculator.FlatDiscountItem":
                    discountType = ((FlatDiscountItem)item).GetDiscountPercentage() + "% Discount";
                    break;
                case "Pr7_SalesPriceCalculator.UnitDiscountItem":
                    discountType = "Buy " + ((UnitDiscountItem)item).GetNumberOfUnitsBought() + ", Get " + ((UnitDiscountItem)item).GetNumberOfUnitsGotFree() + " FREE!!!";
                    break;

            }
            return discountType;
        }

        private static double CalculateFlatDiscountOnItem(Dictionary<GroceryItem, int> groceryList, GroceryItem item, double itemBillAmount, String itemType)
        {
            switch (itemType)
            {
                case "Pr7_SalesPriceCalculator.FlatDiscountItem":
                    itemBillAmount = CalculateFlatDiscountItemPriceBasedOnQuantity(groceryList, item);
                    break;
                case "Pr7_SalesPriceCalculator.UnitDiscountItem":
                    itemBillAmount = CalculateUnitDiscountItemsPriceBasedOnQuantity(groceryList, item);
                    break;
                case "Pr7_SalesPriceCalculator.GroceryItem":
                    itemBillAmount = CalculateItemPriceBasedOnQuantity(groceryList, item);
                    break;
            }
            return itemBillAmount;
        }

        private static double CalculateOriginalBillForGroceries(Dictionary<GroceryItem, int> groceryList)
        {
            double billAmount = 0;
            foreach (GroceryItem item in groceryList.Keys)
            {
                billAmount = billAmount + CalculateItemPriceBasedOnQuantity(groceryList, item);
            }
            return billAmount;
        }

        private static double CalculateDiscountedBillForGroceries(Dictionary<GroceryItem, int> groceryList)
        {
            double billAmount = 0;
            foreach(GroceryItem item in groceryList.Keys)
            {
                String itemType = item.GetType().ToString();
                
                switch (itemType)
                {
                    case "Pr7_SalesPriceCalculator.FlatDiscountItem" :
                        billAmount = billAmount + CalculateFlatDiscountItemPriceBasedOnQuantity(groceryList, item);                        
                        break;
                    case "Pr7_SalesPriceCalculator.UnitDiscountItem":
                        billAmount = billAmount + CalculateUnitDiscountItemsPriceBasedOnQuantity(groceryList, item);
                        break;
                    case "Pr7_SalesPriceCalculator.GroceryItem":
                        billAmount = billAmount + CalculateItemPriceBasedOnQuantity(groceryList, item);
                        break;
                }
            }
            return billAmount;
        }

        private static double CalculateUnitDiscountItemsPriceBasedOnQuantity(Dictionary<GroceryItem, int> groceryList, GroceryItem item)
        {
            double originalPrice = 0, discountedPrice = 0;
            originalPrice = (((UnitDiscountItem)item).GetItemPrice()) * groceryList[item];

            int itemsToBuy = ((UnitDiscountItem)item).GetNumberOfUnitsBought();
            int itemsDiscounted = ((UnitDiscountItem)item).GetNumberOfUnitsGotFree();
            int totalItemNumbers = itemsToBuy + itemsDiscounted;
            int temp1 = 0, temp2 = 0;
                
            if (itemsToBuy >= groceryList[item])
            {
                discountedPrice = (((UnitDiscountItem)item).GetItemPrice()) * groceryList[item];
            }
            else if (totalItemNumbers <= groceryList[item])
            {
                temp1 = groceryList[item] / totalItemNumbers;
                temp2 = groceryList[item] % totalItemNumbers;

                discountedPrice = (((UnitDiscountItem)item).GetItemPrice()) * (temp1 * itemsToBuy + temp2);
            }
            else if (totalItemNumbers > groceryList[item])
            {
                discountedPrice = (((UnitDiscountItem)item).GetItemPrice()) * itemsToBuy;
            }

            return discountedPrice;
        }

        private static double CalculateFlatDiscountItemPriceBasedOnQuantity(Dictionary<GroceryItem, int> groceryList, GroceryItem item)
        {
            double originalPrice = 0, discountedPrice = 0;
            originalPrice = (((FlatDiscountItem)item).GetItemPrice()) * groceryList[item];
            discountedPrice = (((FlatDiscountItem)item).GetDiscountPrice()) * groceryList[item];
            
            return discountedPrice;
        
        }

        private static double CalculateItemPriceBasedOnQuantity(Dictionary<GroceryItem, int> groceryList, GroceryItem item)
        {
            double price = 0;
            price = item.GetItemPrice() * groceryList[item];
           
            return price;
        }

        private static Dictionary<GroceryItem, int> AddItemToList(Dictionary<GroceryItem, int> groceryList, GroceryItem groceryItem, int quantity)
        {
            groceryList.Add(groceryItem,quantity);
            return groceryList;
        }
    }
}
