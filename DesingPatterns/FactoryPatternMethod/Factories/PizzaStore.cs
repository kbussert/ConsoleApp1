using System;
using System.Collections.Generic;
using System.Text;
using FactoryPatternMethod.Products;
using AbstractFactory.Interfaces.AbstractFactory;


namespace FactoryPatternMethod.Factories
{
    abstract class PizzaStore
    {
        protected abstract Pizza create(PizzaType T);

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

    }
}
