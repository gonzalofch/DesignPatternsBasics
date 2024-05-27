using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyFiles
{
    public class Discounter

    {
        private DiscountStrategy Strategy;

        public double ExecuteStrategy(Purchase purchase)
        {
            return Strategy.Discount(purchase);
        }

        public void SetStrategy(DiscountStrategy strategy) {
            this.Strategy = strategy;
        }
    }
}
