using LaCombeDuLionVert.CoffeeMachine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCombeDuLionVert.CoffeeMachine
{
    public static class DrinkMakerProtocol
    {
        public static DrinkMakerCommand Handle(String s)
        {
            DrinkMakerCommand result = new DrinkMakerCommand();

            String[] data = s.Split(':');
            String type = data[0];
            String sugarCount = data[1];
            String stick = data[2];

            if (type == "T")
            {
                result.DrinkType = DrinkType.Tea;
            }
            else if (type == "H")
            {
                result.DrinkType = DrinkType.Chocolate;
            }
            else if (type == "C")
            {
                result.DrinkType = DrinkType.Coffee;
            }

            if (sugarCount == String.Empty)
            {
                result.SugarCount = 0;
            }
            else
            {
                result.SugarCount = Convert.ToInt32(sugarCount);
            }

            if (stick == "0")
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
