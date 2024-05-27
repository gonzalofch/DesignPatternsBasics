using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Discounter

    {
        private DiscountStrategy Strategy;

        public decimal ExecuteStrategy(Purchase purchase)
        {
            return Strategy.Discount(purchase);
        }

        public void SetStrategy(DiscountStrategy strategy) {
            this.Strategy = strategy;
        }
    }
}
