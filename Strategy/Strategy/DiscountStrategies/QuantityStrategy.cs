using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.DiscountStrategies
{
    public class QuantityStrategy : DiscountStrategy
    {
        /*
         * Un descuento del 5% si el cliente compra más de 10 artículos.
         * Un descuento del 10% si el cliente compra más de 20 artículos
         */

        public decimal Discount(Purchase purchase)
        {
            var money = purchase.MoneySpent;
            if (money > 10 && money<=20)
            {
                return money - money * 0.95m;
            }
            if (money < 20)
            {
                return money - money * 0.90m;
            }
            return purchase.MoneySpent;
        }
    }
}
