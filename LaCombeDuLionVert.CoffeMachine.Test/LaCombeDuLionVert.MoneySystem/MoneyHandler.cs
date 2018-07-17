using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCombeDuLionVert.MoneySystem
{
    public static class MoneyHandler
    {
        public static Tuple<Int32, Int32> Handle(IBuyableItem item, Int32 pounds, Int32 cents)
        {
            var remainingPounds = pounds - item.Pounds;
            cents += remainingPounds * 100;
            var remainingCents = cents - item.Cents;

            return new Tuple<int, int>(0, remainingCents);
        }
    }
}
