using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Decorator.Component;
using Decorator.ConcreteComponent;

namespace DecoratorTestProject
{
    [TestClass]
    public class UnitTest1
    {
        //retrieve the price of a house blend coffee
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Beverage bev = new HouseBlend();
            decimal price;
            //Act
            price = bev.GetPrice();
            //Assert
            Assert.AreEqual(price, 0.89m);
        }
    }
}
