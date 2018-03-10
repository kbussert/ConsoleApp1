using Decorator.Component;
using Decorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteDecorators
{
    public class Whip : CondimentDecorator
    {
        private Beverage _bev;

        public Whip(Beverage bev)
        {
            _bev = bev;
        }

        public override decimal GetPrice()
        {
            return _bev.GetPrice() + 0.10m;
        }
    }
}
