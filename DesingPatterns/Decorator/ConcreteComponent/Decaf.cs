using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteComponent
{
    public class Decaf : Beverage
    {
        public override decimal GetPrice() => 1.05m;
    }
}
