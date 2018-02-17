using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Interfaces.AbstractFactory;

namespace FactoryPatternMethod.Products
{
    class VeggiePizza : Pizza
    {
        IngredientFactory factory;

        public VeggiePizza(IngredientFactory factory)
        {
            this.factory = factory;
        }

        internal override void prepare()
        {
            throw new NotImplementedException();
        }
    }
}
