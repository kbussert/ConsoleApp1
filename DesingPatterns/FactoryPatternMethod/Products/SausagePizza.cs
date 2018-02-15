using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Interfaces.AbstractFactory;

namespace FactoryPatternMethod.Products
{
    class SausagePizza: Pizza
    {
        IngredientFactory factory;

        public SausagePizza(IngredientFactory factory)
        {
            this.factory = factory;
        }

        protected override void prepare()
        {
            throw new NotImplementedException();
        }
    }
}
