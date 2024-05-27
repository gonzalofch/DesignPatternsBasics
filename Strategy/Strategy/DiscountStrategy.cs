using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyFiles
{
    public interface DiscountStrategy 
    {
        public double Discount(Purchase purchase);
    }
}
