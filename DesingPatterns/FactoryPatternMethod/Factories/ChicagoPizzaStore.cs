using System;
using System.Collections.Generic;
using System.Text;
using FactoryPatternMethod.Products;
using AbstractFactory.ConcreteClasses.Factories;
using AbstractFactory.Interfaces.AbstractFactory;

namespace FactoryPatternMethod.Factories
{
    class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza create(PizzaType T)
        {
            Pizza pizza = null;
            IngredientFactory factory = new ChicagoIngredientFactory();

            switch (T)
            {
                case PizzaType.CHEESE:
                    pizza = new CheesePizza(factory);
                    pizza.Name = "Chicago Style Cheese Pizza";
                    break;
                case PizzaType.PEPPERONI:
                    pizza = new PepperoniPizza(factory);
                    pizza.Name = "Chicago Style Pepperoni Pizza";
                    break;
                case PizzaType.CLAM:
                    pizza = new ClamPizza(factory);
                    pizza.Name = "Chicago Style Clam Pizza";
                    break;
                case PizzaType.VEGGIE:
                    pizza = new VeggiePizza(factory);
                    pizza.Name = "Chicago Style Veggie Pizza";
                    break;
                case PizzaType.SAUSAGE:
                    pizza = new SausagePizza(factory);
                    pizza.Name = "Chicago Style Sausage Pizza";
                    break;
                case PizzaType.DELUXE:
                    pizza = new DeluxePizza(factory);
                    pizza.Name = "Chicago Style Deluxe Pizza";
                    break;
                default:
                    break;
            }

            return pizza;
        }
    }
}
