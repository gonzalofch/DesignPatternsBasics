using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyFiles
{
    public class PurchaseData
    {
        public double FinalAmmountToPay { get; }

        public double DiscountApplied { get; }


        public PurchaseData(double finalAmmountToPay, double discountApplied)
        {
            FinalAmmountToPay = finalAmmountToPay;
            DiscountApplied = discountApplied;
        }
    }
}
