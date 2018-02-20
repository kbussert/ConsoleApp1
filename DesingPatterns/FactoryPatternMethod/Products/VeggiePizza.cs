using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Interfaces.AbstractFactory;

namespace FactoryPatternMethod.Products
{
    class VeggiePizza : Pizza
    {
        IngredientFactory factory;
        private PizzaType t;

        public VeggiePizza(IngredientFactory factory, PizzaType t)
        {
            this.factory = factory;
            this.t = t;
            
        }

        internal override void prepare()
        {
            throw new NotImplementedException();
        }
    }
}
