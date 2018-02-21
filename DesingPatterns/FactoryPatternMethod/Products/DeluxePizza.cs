using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Interfaces.AbstractFactory;
using AbstractFactory.ConcreteClasses.Products;
using AbstractFactory.Interfaces.AbstractProducts;

namespace FactoryPatternMethod.Products
{
    class DeluxePizza : Pizza
    {
        IngredientFactory factory;
        private PizzaType t;

        public DeluxePizza(IngredientFactory factory, PizzaType t)
        {
            this.factory = factory;
            this.t = t;
        }

        internal override void Prepare()
        {
            dough = factory.createDough();
            sauce = factory.createSauce();
            cheese = factory.createCheese();
            meats = factory.createMeats(t);
            veggies = factory.createVeggies(t);
        }
    }
}
