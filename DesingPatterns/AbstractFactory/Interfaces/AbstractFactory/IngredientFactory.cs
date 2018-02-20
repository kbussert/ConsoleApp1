using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Interfaces.AbstractProducts;
using FactoryPatternMethod.Products;

namespace AbstractFactory.Interfaces.AbstractFactory
{
    public interface IngredientFactory
    {
        IDough createDough();
        ISauce createSauce();
        ICheese createCheese();
        IVeggies[] createVeggies(PizzaType t);
        IMeats[] createMeats(PizzaType t);
    }
}
