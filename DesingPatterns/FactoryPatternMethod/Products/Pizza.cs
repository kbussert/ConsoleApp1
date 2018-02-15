using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Interfaces.AbstractProducts;
using AbstractFactory.Interfaces.AbstractFactory;

namespace FactoryPatternMethod.Products
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        IDough dough;
        ISauce sauce;
        ICheese cheese;
        IVeggies veggies;
        IMeats meats;
        IngredientFactory factory;

        public Pizza()
        {
            
        }



    }
}
