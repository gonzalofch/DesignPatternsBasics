using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class PurchaseData
    {
        public decimal DiscountApplied { get; }

        public decimal FinalAmmountToPay { get; }

        public PurchaseData(decimal discountApplied, decimal finalAmmountToPay)
        {
            DiscountApplied = discountApplied;
            FinalAmmountToPay = finalAmmountToPay;
        }
    }
}
