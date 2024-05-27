using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyFiles.DiscountStrategies
{
    public class SpecialStrategy : DiscountStrategy
    {
        /*
         * Un descuento del 20% para clientes VIP.
         * Un descuento del 25% para el "Producto del Mes"
         */

        public double Discount(Purchase purchase)
        {
            var money = purchase.MoneySpent;

            if (purchase.IsVIP)
            {
                return money - money * 0.80;
            }
            /*Para el "Producto del Mes", no se me ocurria otra manera de hacerlo sin revisar un array de productos y tener q crear un objeto producto*/
            if (purchase.SpecialPurchase)
            {
                return money - money * 0.75;
            }

            return money;
        }
    }
}
