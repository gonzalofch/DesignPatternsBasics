using StrategyFiles.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTests.Tests
{
    public struct PurchaseTestData
    {
        public double MoneySpent { get; set; }
        public int PurchasedElements { get; set; }
        public Season PurchaseSeason { get; set; }
        public bool IsVIP { get; set; }
        public bool SpecialPurchase { get; set; }
    }
}
