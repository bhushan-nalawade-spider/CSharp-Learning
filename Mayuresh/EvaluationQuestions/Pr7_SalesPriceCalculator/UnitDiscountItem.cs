using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr7_SalesPriceCalculator
{
    class UnitDiscountItem : GroceryItem
    {

        public UnitDiscountItem()
        {

        }

        public UnitDiscountItem(String itemName, double itemPrice) : base(itemName, itemPrice)
        {
            
        }

        public UnitDiscountItem(String itemName, double itemPrice, int numberOfUnitsBought, int numberOfUnitsGotFree)
            : base(itemName, itemPrice)
        {
            this.numberOfUnitsBought = numberOfUnitsBought;
            this.numberOfUnitsGotFree = numberOfUnitsGotFree;
        }

        int numberOfUnitsBought = 0;
        int numberOfUnitsGotFree = 0;

        public int GetNumberOfUnitsBought()
        {
            return numberOfUnitsBought;
        }

        public void SetNumberOfUnitsBought(int numberOfUnitsBought)
        {
            this.numberOfUnitsBought = numberOfUnitsBought;
        }

        public int GetNumberOfUnitsGotFree()
        {
            return numberOfUnitsGotFree;
        }

        public void SetNumberOfUnitsGotFree(int numberOfUnitsGotFree)
        {
            this.numberOfUnitsGotFree = numberOfUnitsGotFree;
        }
    }
}
