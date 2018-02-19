using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Interfaces.AbstractFactory;
using AbstractFactory.ConcreteClasses.Products;
using AbstractFactory.Interfaces.AbstractProducts;
using FactoryPatternMethod.Products;

namespace AbstractFactory.ConcreteClasses.Factories
{
    public class NYIngredientFactory : IngredientFactory
    {
        public ICheese createCheese()
        {
            return new Reggiano();
        }

        public IDough createDough()
        {
            return new ThinCrustDough();
        }

        public IMeats[] createMeats(IMeats[] meats)
        {
            return meats;
        }

        public ISauce createSauce()
        {
            return new PlumTomatoSauce();
        }

        public IVeggies[] createVeggies(PizzaType t)
        {
            IVeggies[] veggies;

            switch (t)
            {
                case PizzaType.VEGGIE:
                    //pizza = new VeggiePizza(factory);
                    //pizza.Name = "Chicago Style Veggie Pizza";
                    veggies = null;
                    break;
                case PizzaType.DELUXE:
                    veggies = new IVeggies[] { new Onion(), new Mushroom(),
                                            new GreenPepper(), new BlackOlive() };
                    break;
                default:
                    veggies = null;
                    break;
            }

            return veggies;
        }
    }
}
