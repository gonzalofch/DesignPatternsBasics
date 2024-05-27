using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyFiles.DiscountStrategies
{
    public class QuantityStrategy : DiscountStrategy
    {
        /*
         * Un descuento del 5% si el cliente compra más de 10 artículos.
         * Un descuento del 10% si el cliente compra más de 20 artículos
         */

        public double Discount(Purchase purchase)
        {
            var money = purchase.MoneySpent;
            if (purchase.PurchasedElements > 10 && purchase.PurchasedElements <= 20)
            {
                return money - money * 0.95;
            }
            if (purchase.PurchasedElements > 20)
            {
                return money - money * 0.90; 
            }

            return 0;
        }
    }
}
