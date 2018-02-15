using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Interfaces.AbstractFactory;
using AbstractFactory.ConcreteClasses.Products;
using AbstractFactory.Interfaces.AbstractProducts;

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

        public IMeats[] createMeats()
        {
            //additional logic needed here DEPENDENT on the type of pizza
            return new IMeats[8];
        }

        public ISauce createSauce()
        {
            return new PlumTomatoSauce();
        }

        public IVeggies[] createVeggies()
        {
            //additional logic needed here DEPENDENT on the type of pizza
            return new IVeggies[8]; throw new NotImplementedException();
        }
    }
}
