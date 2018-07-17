using LaCombeDuLionVert.CoffeeCommand;
using LaCombeDuLionVert.MoneySystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCombeDuLionVert.Coffee.MoneySys
{
    public class BuyableDrink : IBuyableItem
    {
        public DrinkType DrinkType { get; set; }
        public Int32 Pounds { get; set; } = 0;
        public Int32 Cents { get; set; } = 0;

        public string GetLabel()
        {
            return DrinkType.ToString();
        }
    }
}
