using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Interfaces.AbstractFactory;
using AbstractFactory.Interfaces.AbstractProducts;
using AbstractFactory.ConcreteClasses.Products;

namespace FactoryPatternMethod.Products
{
    public class NYClamPizza : Pizza
    {
        IngredientFactory factory;

        public NYClamPizza(IngredientFactory factory)
        {
            this.factory = factory;
        }

        internal override void prepare()
        {
            dough = factory.createDough();
            sauce = factory.createSauce();
            cheese = factory.createCheese();
            meats = factory.createMeats(new IMeats[] { new FreshClams() });
        }
    }

    public class ChicagoClamPizza : Pizza
    {
        IngredientFactory factory;

        public ChicagoClamPizza(IngredientFactory factory)
        {
            this.factory = factory;
        }

        internal override void prepare()
        {
            dough = factory.createDough();
            sauce = factory.createSauce();
            cheese = factory.createCheese();
            meats = factory.createMeats(new IMeats[] { new FrozenClams() });
        }
    }
}
