using System;
using System.Collections.Generic;
using System.Text;
using FactoryPatternMethod.Products;
using AbstractFactory.Interfaces.AbstractFactory;


namespace FactoryPatternMethod.Factories
{
    abstract class PizzaStore
    {
        IngredientFactory factory;
        Pizza pizza;

        public void orderPizza()
        {

        }

        protected void prepare()
        {

        }

        protected void bake()
        {

        }

        protected void cut()
        {

        }

        protected void box()
        {

        }

        protected abstract Pizza create();

    }
}
