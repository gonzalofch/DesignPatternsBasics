using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyFiles
{
    public class PurchaseData
    {
        public double FinalAmountToPay { get; }

        public double DiscountApplied { get; }


        public PurchaseData(double finalAmountToPay, double discountApplied)
        {
            FinalAmountToPay = finalAmountToPay;
            DiscountApplied = discountApplied;
        }
    }
}
