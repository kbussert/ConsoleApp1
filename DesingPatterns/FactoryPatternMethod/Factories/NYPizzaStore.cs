using System;
using System.Collections.Generic;
using System.Text;
using FactoryPatternMethod.Products;
using AbstractFactory.Interfaces.AbstractFactory;
using AbstractFactory.ConcreteClasses.Factories;

namespace FactoryPatternMethod.Factories
{
    class NYPizzaStore : PizzaStore
    {
        protected override Pizza create(PizzaType T)
        {
            Pizza pizza = null;
            IngredientFactory factory = new NYIngredientFactory();

            switch (T)
            {
                case PizzaType.CHEESE:
                    pizza = new CheesePizza(factory);
                    pizza.Name = "New York Style Cheese Pizza";
                    break;
                case PizzaType.PEPPERONI:
                    pizza = new PepperoniPizza(factory);
                    pizza.Name = "New York Style Pepperoni Pizza";
                    break;
                case PizzaType.CLAM:
                    pizza = new ClamPizza(factory);
                    pizza.Name = "New York Style Clam Pizza";
                    break;
                case PizzaType.VEGGIE:
                    pizza = new VeggiePizza(factory);
                    pizza.Name = "New York Style Veggie Pizza";
                    break;
                case PizzaType.SAUSAGE:
                    pizza = new SausagePizza(factory);
                    pizza.Name = "New York Style Sausage Pizza";
                    break;
                case PizzaType.DELUXE:
                    pizza = new DeluxePizza(factory);
                    pizza.Name = "New York Style Deluxe Pizza";
                    break;
                default:
                    break;
            }

            return pizza;
        }

    }
}
