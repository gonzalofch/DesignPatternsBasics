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

        public PurchaseData Execute(Purchase purchase)
        {
            decimal finalAmmountToPay = 0;
            decimal discountApplied = 0;
            decimal initialAmmount = purchase.MoneySpent;
            discounter.SetStrategy(new QuantityStrategy());
            discountApplied += discounter.ExecuteStrategy(purchase);
            discounter.SetStrategy(new SeasonStrategy());
            discountApplied += discounter.ExecuteStrategy(purchase);
            discounter.SetStrategy(new SpecialStrategy());
            discountApplied += discounter.ExecuteStrategy(purchase);

            finalAmmountToPay = initialAmmount - discountApplied;

            return new PurchaseData(discountApplied, finalAmmountToPay);
        }
    }
}
