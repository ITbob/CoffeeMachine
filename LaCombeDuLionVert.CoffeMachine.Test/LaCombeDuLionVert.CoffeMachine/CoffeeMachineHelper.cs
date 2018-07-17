using LaCombeDuLionVert.Coffee.MoneySys;
using LaCombeDuLionVert.CoffeeCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCombeDuLionVert.CoffeMachine
{
    public class CoffeeMachineHelper
    {
        public static CoffeeMachineAck Handle(String command, Int32 pounds, Int32 cents)
        {
            return new CoffeeMachineAck();
        }
    }
}
