using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Interfaces.AbstractFactory;

namespace FactoryPatternMethod.Products
{
    class ClamPizza : Pizza
    {
        IngredientFactory factory;

        public ClamPizza(IngredientFactory factory)
        {
            this.factory = factory;
        }

        protected override void prepare()
        {
            throw new NotImplementedException();
        }
    }
}
