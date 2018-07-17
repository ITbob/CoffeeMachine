using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCombeDuLionVert.MoneySystem
{
    public interface IBuyableItem
    {
        Int32 Pounds { get; set; }
        Int32 Cents { get; set; }
        String GetLabel();
    }
}
