using System;
using System.Collections.Generic;
using System.Text;
using FactoryPatternMethod.Products;
using AbstractFactory.Interfaces.AbstractFactory;


namespace FactoryPatternMethod.Factories
{
    abstract class PizzaStore
    {
        Pizza pizza;
        protected abstract Pizza create(PizzaType T);

        public void orderPizza(PizzaType T)
        {
            pizza = create(T);
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();
        }

    }
}
