using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public interface DiscountStrategy 
    {
        public decimal Discount(Purchase purchase);
    }
}
