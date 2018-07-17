using LaCombeDuLionVert.CoffeeMachine;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCombeDuLionVert.FirstIteration.Test
{
    [TestFixture]
    class Drink_Order_Transmission_Test
    {
        [Test]
        public void Should_get_one_tea_with_one_suger_and_no_stick()
        {
            var command = "T:1:0";

            var result = DrinkMakerProtocol.Handle(command);

            Assert.AreEqual(new DrinkMakerCommand()
            {
                HasStick = false,
                SugarCount = 1,
                DrinkType = DrinkType.Tea
            }, result);
        }
    }
}
