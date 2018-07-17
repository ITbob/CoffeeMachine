using LaCombeDuLionVert.CoffeMachine;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCombeDuLionVert.FirstIteration.Test
{
    [TestFixture]
    public class Drink_General_Test
    {
        [Test]
        public void Should_Have_A_Tea()
        {
            var command = "T:1:0";
            var result = CoffeeMachineHelper.Handle(command, 0,60);

            Assert.AreEqual(true, result.IsPassed);
        }
    }
}
