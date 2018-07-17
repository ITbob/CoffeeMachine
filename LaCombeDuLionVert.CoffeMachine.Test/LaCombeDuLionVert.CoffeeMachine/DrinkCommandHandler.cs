using LaCombeDuLionVert.CoffeeCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCombeDuLionVert.CoffeeCommand
{
    public static class DrinkCommandHandler
    {
        public static DrinkType GetTypeDrink(String s)
        {
            var result = DrinkType.None;
            if (s == "T")
            {
                result = DrinkType.Tea;
            }
            else if (s == "H")
            {
                result = DrinkType.Chocolate;
            }
            else if (s == "C")
            {
                result = DrinkType.Coffee;
            }
            else if (s == "O")
            {
                result = DrinkType.Orange;
            }
            return result;
        }

        public static DrinkCommand Handle(String s)
        {
            DrinkCommand result = new DrinkCommand();

            String[] data = s.Split(':');

            if (data[0] == "M")
            {
                result.Message = data[1];
                return result;
            }
            else
            {
                result.DrinkType = GetTypeDrink(data[0]);
            }

            if (data[1] == String.Empty)
            {
                result.SugarCount = 0;
            }
            else
            {
                result.SugarCount = Convert.ToInt32(data[1]);
            }

            if (data[2] == "0")
            {
                result.HasStick = true;
            }
            else
            {
                result.HasStick = false;
            }

            return result;
        }
    }
}
