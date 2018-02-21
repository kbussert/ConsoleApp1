using System;
using FactoryPatternMethod.Products;
using FactoryPatternMethod.Factories;

namespace DesingPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore ps = new NYPizzaStore();

            ps.OrderPizza(PizzaType.CHEESE);
            

            Console.ReadKey();
        }
    }
}
