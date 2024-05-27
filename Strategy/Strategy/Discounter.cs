using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyFiles
{
    public class Discounter

    {
        private IDiscountStrategy _discountStrategy;

        public double ExecuteStrategy(Purchase purchase)
        {
            return _discountStrategy.ApplyDiscount(purchase);
        }

        public void SetStrategy(IDiscountStrategy strategy) {
            this._discountStrategy = strategy;
        }
    }
}
