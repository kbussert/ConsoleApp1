using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Interfaces.AbstractProducts;

namespace AbstractFactory.Interfaces.AbstractFactory
{
    public interface IngredientFactory
    {
        IDough createDough();
        ISauce createSauce();
        ICheese createCheese();
        IVeggies[] createVeggies(IVeggies[] veggies);
        IMeats[] createMeats(IMeats[] meats);
    }
}
