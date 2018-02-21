using System;
using System.Collections.Generic;
using System.Text;
using FactoryPatternMethod.Products;
using AbstractFactory.Interfaces.AbstractFactory;
using AbstractFactory.ConcreteClasses.Factories;

namespace FactoryPatternMethod.Factories
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza Create(PizzaType T)
        {
            Pizza pizza = null;
            IngredientFactory factory = new NYIngredientFactory();

            switch (T)
            {
                case PizzaType.CHEESE:
                    pizza = new CheesePizza(factory, T)
                    {
                        Name = "New York Style Cheese Pizza"
                    };
                    break;
                case PizzaType.PEPPERONI:
                    pizza = new PepperoniPizza(factory, T)
                    {
                        Name = "New York Style Pepperoni Pizza"
                    };
                    break;
                case PizzaType.CLAM:
                    pizza = new NYClamPizza(factory, T)
                    {
                        Name = "New York Style Clam Pizza"
                    };
                    break;
                case PizzaType.VEGGIE:
                    pizza = new VeggiePizza(factory, T)
                    {
                        Name = "New York Style Veggie Pizza"
                    };
                    break;
                case PizzaType.SAUSAGE:
                    pizza = new SausagePizza(factory, T)
                    {
                        Name = "New York Style Sausage Pizza"
                    };
                    break;
                case PizzaType.DELUXE:
                    pizza = new DeluxePizza(factory, T)
                    {
                        Name = "New York Style Deluxe Pizza"
                    };
                    break;
                default:
                    break;
            }

            return pizza;
        }

    }
}
