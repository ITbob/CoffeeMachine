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

        public static DrinkType GetTypeDrink(Char s)
        {
            var result = DrinkType.None;

            if (s == 'T')
            {
                result = DrinkType.Tea;
            }
            else if (s == 'H')
            {
                result = DrinkType.Chocolate;
            }
            else if (s == 'C')
            {
                result = DrinkType.Coffee;
            }
            else if (s == 'O')
            {
                result = DrinkType.Orange;
            }

            return result;
        }

        private static TemperatureRange GetTemperaturRange(Char s)
        {
            if(s == 'h')
            {
                return TemperatureRange.Hot;
            }
            else
            {
                return TemperatureRange.None;
            }

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
                if(data[0].Length == 1)
                {
                    result.DrinkType = GetTypeDrink(data[0][0]);
                }
                else
                {
                    result.DrinkType = GetTypeDrink(data[0][0]);
                    result.Temperature = GetTemperaturRange(data[0][1]);
                }
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
