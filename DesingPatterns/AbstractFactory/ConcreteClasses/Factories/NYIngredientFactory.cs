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

        

        public IMeats[] createMeats(PizzaType t)
        {
            IMeats[] meats;

            switch (t)
            {
                case PizzaType.PEPPERONI:
                    meats = new IMeats[] { new Sausage(), new Pepperoni(),
                                         new CanadianBacon()};
                    break;
                case PizzaType.DELUXE:
                    meats = new IMeats[] { new Sausage(), new Pepperoni() };
                    break;
                case PizzaType.CLAM:
                    meats = new IMeats[] { new FreshClams()};
                    break;
                default:
                    meats = null;
                    break;
            }
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
                    veggies = new IVeggies[] { new Onion(), new GreenPepper(),
                                         new RoastedRedPepper(), new Mushroom(),
                                         new GreenOlive()
                                             };
                    break;
                case PizzaType.DELUXE:
                    veggies = new IVeggies[] { new Onion(), new Mushroom(),
                                            new GreenPepper(), new GreenOlive() };
                    break;
                default:
                    veggies = null;
                    break;
            }
            return veggies;
        }
    }
}
