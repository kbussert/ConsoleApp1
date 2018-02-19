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
        private PizzaType pType;

        public DeluxePizza(IngredientFactory factory, PizzaType t)
        {
            this.factory = factory;
            pType = t;
        }

        internal override void prepare()
        {
            dough = factory.createDough();
            sauce = factory.createSauce();
            cheese = factory.createCheese();
            meats = factory.createMeats(new IMeats[] { new Sausage(), new Pepperoni() });
            //veggies = factory.createVeggies(new IVeggies[] { new Onion(), new Mushroom(),
           //                                 new GreenPepper(), new BlackOlive() });

            veggies = factory.createVeggies(pType);
        }
    }
}
