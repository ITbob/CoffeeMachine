using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCombreDuLionVert.Drinks
{
    public static class DrinksContainer
    {
        public static LaCombeDuLionVert.Drinks.Drinkable[] Drinks
        { get; } = new LaCombeDuLionVert.Drinks.Drinkable[]
        {
            new LaCombeDuLionVert.Drinks.Drinkable()
            {
                Label = "Orange"
            },

        };
    }
}
