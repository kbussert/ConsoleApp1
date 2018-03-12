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

        //retrieve the price of an espresso with mocha
        [TestMethod]
        public void EspressoWithMochaPriceTest()
        {
            //Arrange
            Beverage bev = new Espresso();
            bev = new Mocha(bev);
            decimal price;
            //Act
            price = bev.GetPrice();
            //Assert
            Assert.AreEqual(price, 2.19m);
        }

        //retrieve the price of a dark roast with steamed milk
        [TestMethod]
        public void DarkRoastWithMochaPriceTest()
        {
            //Arrange
            Beverage bev = new DarkRoast();
            bev = new SteamedMilk(bev);
            decimal price;
            //Act
            price = bev.GetPrice();
            //Assert
            Assert.AreEqual(price, 1.09m);
        }

        //retrieve the price of a decaf with steamed milk
        [TestMethod]
        public void DecafWithMochaPriceTest()
        {
            //Arrange
            Beverage bev = new Decaf();
            bev = new SteamedMilk(bev);
            decimal price;
            //Act
            price = bev.GetPrice();
            //Assert
            Assert.AreEqual(price, 1.15m);
        }

        //retrieve the price of a dark roast mocha whip
        [TestMethod]
        public void DarkRoastMochaWhipPriceTest()
        {
            //Arrange
            Beverage bev = new DarkRoast();
            bev = new Mocha(bev);
            bev = new Whip(bev);
            decimal price;
            //Act
            price = bev.GetPrice();
            //Assert
            Assert.AreEqual(price, 1.29m);
        }

        //retrieve the price of a dark roast with steamed milk
        [TestMethod]
        public void DoubleMochaSoyLatteWithWhipPriceTest()
        {
            //Arrange
            Beverage bev = new HouseBlend();
            bev = new Soy(bev);
            bev = new Mocha(bev);
            bev = new Mocha(bev);
            bev = new Whip(bev);
            decimal price;
            //Act
            price = bev.GetPrice();
            //Assert
            Assert.AreEqual(price, 1.54m);
        }
    }

    

}
