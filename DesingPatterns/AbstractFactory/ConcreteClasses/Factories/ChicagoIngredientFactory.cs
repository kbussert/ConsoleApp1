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

        public IMeats[] createMeats(IMeats[] meats)
        {
            

            return meats;
        }

        public ISauce createSauce()
        {
            return new MarinaraSauce();
        }

        public IVeggies[] createVeggies(PizzaType t)
        {
            return new IVeggies[4];
        }
    }
}
