using LaCombeDuLionVert.CoffeeCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCombeDuLionVert.CoffeeCommand
{
    public static class DrinkMakerProtocol
    {
        public static DrinkMakerCommand Handle(String s)
        {
            DrinkMakerCommand result = new DrinkMakerCommand();

            String[] data = s.Split(':');

            if (data[0] == "T")
            {
                result.DrinkType = DrinkType.Tea;
            }
            else if (data[0] == "H")
            {
                result.DrinkType = DrinkType.Chocolate;
            }
            else if (data[0] == "C")
            {
                result.DrinkType = DrinkType.Coffee;
            }
            else if(data[0] == "M")
            {
                result.Message = data[1];
                return result;
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
