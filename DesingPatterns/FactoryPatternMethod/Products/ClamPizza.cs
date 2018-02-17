using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Interfaces.AbstractFactory;
using AbstractFactory.Interfaces.AbstractProducts;
using AbstractFactory.ConcreteClasses.Products;

namespace FactoryPatternMethod.Products
{
    class ClamPizza : Pizza
    {
        IngredientFactory factory;

        public ClamPizza(IngredientFactory factory)
        {
            this.factory = factory;
        }

        internal override void prepare()
        {
            dough = factory.createDough();
            sauce = factory.createSauce();
            cheese = factory.createCheese();
            meats = factory.createMeats(new IMeats[] { new Sausage() });  //////////////////Change this to use some form of Clams
        }
    }
}
