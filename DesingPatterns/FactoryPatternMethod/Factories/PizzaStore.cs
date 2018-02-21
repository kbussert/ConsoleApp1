using System;
using System.Collections.Generic;
using System.Text;
using FactoryPatternMethod.Products;
using AbstractFactory.Interfaces.AbstractFactory;


namespace FactoryPatternMethod.Factories
{
    abstract public class PizzaStore
    {
        Pizza pizza;
        protected abstract Pizza Create(PizzaType T);

        public void OrderPizza(PizzaType T)
        {
            pizza = Create(T);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }

    }
}
