using LaCombeDuLionVert.CoffeeCommand;
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

            var result = DrinkCommandHandler.Handle(command);

            var expectedResult = new DrinkCommand()
            {
                HasStick = true,
                SugarCount = 1,
                DrinkType = DrinkType.Tea
            };

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Should_get_one_chocolate_with_no_sugar_and_no_stick()
        {
            var command = "H::";

            var result = DrinkCommandHandler.Handle(command);

            var expectedResult = new DrinkCommand()
            {
                HasStick = false,
                SugarCount = 0,
                DrinkType = DrinkType.Chocolate
            };

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Should_get_one_coffee_with_two_sugars_and_one_stick()
        {
            var command = "C:2:0";

            var result = DrinkCommandHandler.Handle(command);

            var expectedResult = new DrinkCommand()
            {
                HasStick = true,
                SugarCount = 2,
                DrinkType = DrinkType.Coffee
            };

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Should_get_the_user_interface_message()
        {
            var command = "M:message-content";

            var result = DrinkCommandHandler.Handle(command);

            var expectedResult = new DrinkCommand()
            {
                Message = "message-content"
            };

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Should_get_one_orange_with_no_sugar_and_no_stick()
        {
            var command = "O::";

            var result = DrinkCommandHandler.Handle(command);

            var expectedResult = new DrinkCommand()
            {
                HasStick = false,
                SugarCount = 0,
                DrinkType = DrinkType.Orange
            };

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Should_get_one_hot_chocolate()
        {
            var command = "Ch::";

            var result = DrinkCommandHandler.Handle(command);

            var expectedResult = new DrinkCommand()
            {
                HasStick = false,
                SugarCount = 0,
                DrinkType = DrinkType.Coffee,
                Temperature = TemperatureRange.Hot
            };

            Assert.AreEqual(expectedResult, result);
        }
    }
}
