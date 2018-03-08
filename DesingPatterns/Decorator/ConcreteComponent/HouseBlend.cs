using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Component;

namespace Decorator.ConcreteComponent
{
    public class HouseBlend : Beverage
    {
        public override decimal GetPrice() => 0.89m;

    }
}
