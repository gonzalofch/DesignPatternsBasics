using StrategyFiles.DiscountStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyFiles
{
    public class Aplication
    {
        Discounter discounter;

        public PurchaseData Execute(Purchase purchase)
        {
            double discountApplied = 0;
            discounter.SetStrategy(new QuantityStrategy());
            discountApplied += discounter.ExecuteStrategy(purchase);
            discounter.SetStrategy(new SeasonStrategy());
            discountApplied += discounter.ExecuteStrategy(purchase);
            discounter.SetStrategy(new SpecialStrategy());
            discountApplied += discounter.ExecuteStrategy(purchase);

            double finalAmmountToPay = purchase.MoneySpent - discountApplied;

            return new PurchaseData(finalAmmountToPay, discountApplied);
        }
    }
}
