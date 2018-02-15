using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Interfaces.AbstractProducts;
using AbstractFactory.Interfaces.AbstractFactory;

namespace FactoryPatternMethod.Products
{
    public enum PizzaType { CHEESE, PEPPERONI, CLAM, VEGGIE, SAUSAGE, DELUXE };

    public abstract class Pizza
    {
        public string Name { get; set; }
        IDough dough;
        ISauce sauce;
        ICheese cheese;
        IVeggies veggies;
        IMeats meats;
        IngredientFactory factory;

        protected abstract void prepare();

        void bake()
        {

        }

        void cut()
        {

        }

        void box()
        {

        }

    }
}
