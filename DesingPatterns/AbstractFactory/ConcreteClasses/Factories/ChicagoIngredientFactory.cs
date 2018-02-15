using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Interfaces.AbstractFactory;
using AbstractFactory.Interfaces.AbstractProducts;
using AbstractFactory.ConcreteClasses.Products;

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

        public IMeats[] createMeats()
        {
            //additional logic needed here DEPENDENT on the type of pizza
            return new IMeats[8];
        }

        public ISauce createSauce()
        {
            return new MarinaraSauce();
        }

        public IVeggies[] createVeggies()
        {
            //additional logic needed here DEPENDENT on the type of pizza
            return new IVeggies[8];
        }
    }
}
