using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyFiles.Enum;
namespace StrategyFiles
{
    public class Purchase
    {
        public double MoneySpent {  get; set; }
        public int PurchasedElements { get; set; }
        public Season PurchaseSeason { get; set; }
        public bool IsVIP { get; set; }
        public bool SpecialPurchase { get; set; }

        public Purchase(double moneySpent, int purchasedElements, Season season, bool isVIP, bool specialPurchase)
        {
            MoneySpent = moneySpent;
            PurchasedElements = purchasedElements;
            PurchaseSeason = season;
            IsVIP = isVIP;
            SpecialPurchase = specialPurchase;
        }
    }
}
