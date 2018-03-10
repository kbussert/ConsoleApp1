using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteDecorators
{
    public class Mocha : Beverage
    {
        private Beverage _bev;

        public Mocha(Beverage bev)
        {
            _bev = bev;
        }

        public override decimal GetPrice()
        {
            return _bev.GetPrice() + 0.20m;
        }
    }
}
