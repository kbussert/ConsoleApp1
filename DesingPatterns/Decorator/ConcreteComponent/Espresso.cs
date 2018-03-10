using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteComponent
{
    public class Espresso : Beverage
    {
        public override decimal GetPrice() => 1.99m;
    }
}
