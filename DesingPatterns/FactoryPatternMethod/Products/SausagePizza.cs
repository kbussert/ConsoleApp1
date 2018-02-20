using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Interfaces.AbstractFactory;
using AbstractFactory.Interfaces.AbstractProducts;
using AbstractFactory.ConcreteClasses.Products;

namespace FactoryPatternMethod.Products
{
    class SausagePizza: Pizza
    {
        IngredientFactory factory;
        private PizzaType t;

        public SausagePizza(IngredientFactory factory, PizzaType t)
        {
            this.factory = factory;
            this.t = t;
        }

        internal override void prepare()
        {
            dough = factory.createDough();
            sauce = factory.createSauce();
            cheese = factory.createCheese();
            meats = factory.createMeats(t);
        }
    }
}
