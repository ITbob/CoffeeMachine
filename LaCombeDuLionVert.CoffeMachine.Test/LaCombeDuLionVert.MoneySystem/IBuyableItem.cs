using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCombeDuLionVert.MoneySystem
{
    public interface IBuyableItem
    {
        Single Amount { get; set; }
        String GetLabel();
    }
}
