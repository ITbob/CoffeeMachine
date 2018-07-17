using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaCombeDuLionVert.Coffee.MoneySys;
using LaCombeDuLionVert.MoneySystem;

namespace LaCombeDuLionVert.FirstIteration.Test
{
    [TestFixture]
    class Drink_Money_System_Test
    {
        [Test]
        public void Should_Have_Enough_Money_For_a_Tea()
        {
            var buyableTea = new BuyableDrink();
            buyableTea.DrinkType = CoffeeCommand.DrinkType.Tea;
            buyableTea.Amount = 0.6f;

            var result = MoneyHandler.Handle(buyableTea, 1);

            Assert.AreEqual(0, 4f, result);
        }
    }
}
