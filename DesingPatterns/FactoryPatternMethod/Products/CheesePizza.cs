using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Interfaces.AbstractFactory;

namespace FactoryPatternMethod.Products
{
    class CheesePizza : Pizza
    {
        IngredientFactory factory;
        private PizzaType t;

        public CheesePizza(IngredientFactory factory, PizzaType t)
        {
            this.factory = factory;
            this.t = t;
        }

        internal override void Prepare()
        {
            dough = factory.createDough();
            sauce = factory.createSauce();
            cheese = factory.createCheese();
        }
    }
}
