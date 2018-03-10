using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Decorator.Component;
using Decorator.ConcreteComponent;
using Decorator.ConcreteDecorators;

namespace DecoratorTestProject
{
    [TestClass]
    public class UnitTest1
    {
        //retrieve the price of a house blend coffee
        [TestMethod]
        public void HouseBlendPriceTest()
        {
            //Arrange
            Beverage bev = new HouseBlend();
            decimal price;
            //Act
            price = bev.GetPrice();
            //Assert
            Assert.AreEqual(price, 0.89m);
        }

        //retrieve the price of a dark roast coffee
        [TestMethod]
        public void DarkRoastPriceTest()
        {
            //Arrange
            Beverage bev = new DarkRoast();
            decimal price;
            //Act
            price = bev.GetPrice();
            //Assert
            Assert.AreEqual(price, 0.99m);
        }

        //retrieve the price of a decaf coffee
        [TestMethod]
        public void DecafPriceTest()
        {
            //Arrange
            Beverage bev = new Decaf();
            decimal price;
            //Act
            price = bev.GetPrice();
            //Assert
            Assert.AreEqual(price, 1.05m);
        }

        //retrieve the price of an espresso coffee
        [TestMethod]
        public void EspressotPriceTest()
        {
            //Arrange
            Beverage bev = new Espresso();
            decimal price;
            //Act
            price = bev.GetPrice();
            //Assert
            Assert.AreEqual(price, 1.99m);
        }

        //retrieve the price of an espresso with whip
        [TestMethod]
        public void EspressoWithWhipPriceTest()
        {
            //Arrange
            Beverage bev = new Espresso();
            bev = new Whip(bev);
            decimal price;
            //Act
            price = bev.GetPrice();
            //Assert
            Assert.AreEqual(price, 2.09m);
        }

        //retrieve the price of a house blend with whip
        [TestMethod]
        public void HouseBlendWithWhipPriceTest()
        {
            //Arrange
            Beverage bev = new HouseBlend();
            bev = new Whip(bev);
            decimal price;
            //Act
            price = bev.GetPrice();
            //Assert
            Assert.AreEqual(price, 0.99m);
        }

        //retrieve the price of a dark roast with soy
        [TestMethod]
        public void DarkRoastWithSoyPriceTest()
        {
            //Arrange
            Beverage bev = new DarkRoast();
            bev = new Soy(bev);
            decimal price;
            //Act
            price = bev.GetPrice();
            //Assert
            Assert.AreEqual(price, 1.14m);
        }

        //retrieve the price of a decaf with soy
        [TestMethod]
        public void DecafWithSoyPriceTest()
        {
            //Arrange
            Beverage bev = new Decaf();
            bev = new Soy(bev);
            decimal price;
            //Act
            price = bev.GetPrice();
            //Assert
            Assert.AreEqual(price, 1.20m);
        }

        //retrieve the price of a house blend with mocha
        [TestMethod]
        public void HouseBlendWithMochaPriceTest()
        {
            //Arrange
            Beverage bev = new HouseBlend();
            bev = new Mocha(bev);
            decimal price;
            //Act
            price = bev.GetPrice();
            //Assert
            Assert.AreEqual(price, 1.09m);
        }
    }

    

}
