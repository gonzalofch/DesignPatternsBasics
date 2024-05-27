using Strategy.DiscountStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Aplication
    {
        Discounter discounter;
        private decimal DiscountApplied = 0;
        private decimal AmmountToPay = 0;

        public void Execute(Purchase purchase)
        {
            var initialAmmount = purchase.MoneySpent;
            discounter.SetStrategy(new QuantityStrategy());
            DiscountApplied += discounter.ExecuteStrategy(purchase);
            discounter.SetStrategy(new SeasonStrategy());
            DiscountApplied += discounter.ExecuteStrategy(purchase);
            discounter.SetStrategy(new SpecialStrategy());
            DiscountApplied += discounter.ExecuteStrategy(purchase);
            AmmountToPay = initialAmmount-DiscountApplied;
        }
    }
}
