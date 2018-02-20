using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Interfaces.AbstractFactory;
using AbstractFactory.Interfaces.AbstractProducts;
using AbstractFactory.ConcreteClasses.Products;
using FactoryPatternMethod.Products;

namespace AbstractFactory.ConcreteClasses.Factories
{
    public class ChicagoIngredientFactory : IngredientFactory
    {
        public ICheese createCheese()
        {
            return new Mozzarella();
        }

        public IDough createDough()
        {
            return new ThickCrustDough();
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
                    meats = new IMeats[] { new FrozenClams()};
                    break;
                default:
                    meats = null;
                    break;
            }
            return meats;
        }

        public ISauce createSauce()
        {
            return new MarinaraSauce();
        }

        public IVeggies[] createVeggies(PizzaType t)
        {
            IVeggies[] veggies;

            switch (t)
            {
                case PizzaType.VEGGIE:
                    veggies = new IVeggies[] { new Onion(), new GreenPepper(),
                                         new RoastedRedPepper(), new Mushroom(),
                                         new BlackOlive()
                                             };
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
