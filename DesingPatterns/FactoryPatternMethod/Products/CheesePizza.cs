using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Interfaces.AbstractFactory;

namespace FactoryPatternMethod.Products
{
    class CheesePizza : Pizza
    {
        IngredientFactory factory;

        public CheesePizza(IngredientFactory factory)
        {
            this.factory = factory;
        }

        internal override void prepare()
        {
            dough = factory.createDough();
            sauce = factory.createSauce();
            cheese = factory.createCheese();
        }
    }
}
