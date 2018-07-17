using LaCombeDuLionVert.Coffee.MoneySys;
using LaCombeDuLionVert.CoffeeCommand;
using LaCombeDuLionVert.MoneySystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCombeDuLionVert.CoffeMachine
{
    public class CoffeeMachineHelper
    {
        private static List<BuyableDrink> _drinks = new List<BuyableDrink>
        {
            new BuyableDrink(){
                DrinkType = DrinkType.Chocolate,
                Cents = 50
            },
            new BuyableDrink(){
                DrinkType = DrinkType.Tea,
                Cents = 40
            },
            new BuyableDrink(){
                DrinkType = DrinkType.Coffee,
                Cents = 60
            }
        };


        public static CoffeeMachineAck Handle(String text, Int32 pounds, Int32 cents)
        {
            //1. get the buyable item from the text
            var type = DrinkCommandHandler.GetTypeDrink(text.Split(':')[0]);
            var buyableItem = _drinks.Where(d => d.DrinkType == type).Single();

            //2. check we have enough money
            var amount = MoneyHandler.Handle(buyableItem, pounds, cents);

            if(amount.Item1 < 0 || amount.Item2 < 0)
            {
                return new CoffeeMachineAck() {
                    IsPassed = false,
                    Message = $"{Math.Abs(amount.Item1)}.{Math.Abs(amount.Item2)} are missing."
                };
            }

            //3. we send the command to the drink maker
            DrinkCommandHandler.Handle(text);

            return new CoffeeMachineAck() { IsPassed = true };
        }
    }
}
