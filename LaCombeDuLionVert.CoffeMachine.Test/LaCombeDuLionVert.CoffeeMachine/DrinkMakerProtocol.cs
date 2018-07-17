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

            result.SugarCount = Convert.ToInt32(sugarCount);

            if (Convert.ToInt32(sugarCount) == 1)
            {
                result.HasStick = false;
            }

            return result;
        }
    }
}
