using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Interfaces.AbstractFactory;

namespace FactoryPatternMethod.Products
{
    class DeluxePizza : Pizza
    {
        IngredientFactory factory;

        public DeluxePizza(IngredientFactory factory)
        {
            this.factory = factory;
        }

        protected override void prepare()
        {
            throw new NotImplementedException();
        }
    }
}
