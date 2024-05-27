using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.DiscountStrategies
{
    public class SeasonStrategy : DiscountStrategy
    {
        /*
         * Un descuento del 10% durante la temporada navideña.
         * Un descuento del 15% durante la temporada de verano.
         */

        public decimal Discount(Purchase purchase)
        {
            var money = purchase.MoneySpent;

            if (purchase.PurchaseSeason == Enum.Season.Christmas)
            {
                /*funcionalidad*/
                return money - money * 0.90m;
            }

            if (purchase.PurchaseSeason == Enum.Season.Summer)
            {
                return money - money * 0.85m;
            }

            return money;
        }
    }
}
