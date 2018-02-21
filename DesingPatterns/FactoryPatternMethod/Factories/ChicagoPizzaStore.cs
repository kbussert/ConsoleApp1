using System;
using System.Collections.Generic;
using System.Text;
using FactoryPatternMethod.Products;
using AbstractFactory.ConcreteClasses.Factories;
using AbstractFactory.Interfaces.AbstractFactory;

namespace FactoryPatternMethod.Factories
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza Create(PizzaType T)
        {
            Pizza pizza = null;
            IngredientFactory factory = new ChicagoIngredientFactory();

            switch (T)
            {
                case PizzaType.CHEESE:
                    pizza = new CheesePizza(factory, T)
                    {
                        Name = "Chicago Style Cheese Pizza"
                    };
                    break;
                case PizzaType.PEPPERONI:
                    pizza = new PepperoniPizza(factory, T)
                    {
                        Name = "Chicago Style Pepperoni Pizza"
                    };
                    break;
                case PizzaType.CLAM:
                    pizza = new ChicagoClamPizza(factory, T)
                    {
                        Name = "Chicago Style Clam Pizza"
                    };
                    break;
                case PizzaType.VEGGIE:
                    pizza = new VeggiePizza(factory, T)
                    {
                        Name = "Chicago Style Veggie Pizza"
                    };
                    break;
                case PizzaType.SAUSAGE:
                    pizza = new SausagePizza(factory, T)
                    {
                        Name = "Chicago Style Sausage Pizza"
                    };
                    break;
                case PizzaType.DELUXE:
                    pizza = new DeluxePizza(factory, T)
                    {
                        Name = "Chicago Style Deluxe Pizza"
                    };
                    break;
                default:
                    break;
            }

            return pizza;
        }
    }
}
