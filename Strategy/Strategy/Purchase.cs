using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Enum;
namespace Strategy
{
    public class Purchase
    {
        public decimal MoneySpent {  get; set; }
        public int PurchasedElements { get; set; }
        public Season PurchaseSeason { get; set; }
        public bool IsVIP { get; set; }
        public bool SpecialPurchase { get; set; }

        public Purchase(int purchasedElements, Season season, bool isVIP, bool specialPurchase)
        {
            PurchasedElements = purchasedElements;
            PurchaseSeason = season;
            IsVIP = isVIP;
            SpecialPurchase = specialPurchase;
        }
    }
}
