using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Interfaces.AbstractProducts;
using AbstractFactory.Interfaces.AbstractFactory;

namespace FactoryPatternMethod.Products
{
    public enum PizzaType { CHEESE, PEPPERONI, CLAM, VEGGIE, SAUSAGE, DELUXE, MEATLOVERS };

    public abstract class Pizza
    {
        public string Name { get; set; }
        protected IDough dough;
        protected ISauce sauce;
        protected ICheese cheese;
        protected IVeggies[] veggies;
        protected IMeats[] meats;

        internal abstract void Prepare();

        internal void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350 degrees");
        }

        internal void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        internal void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

    }
}
