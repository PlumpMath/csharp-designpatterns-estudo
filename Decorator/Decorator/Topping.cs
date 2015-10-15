using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
    public abstract class Topping : IceCream
    {
        protected IceCream IceCream { get; set; }

        protected Topping(IceCream s)
        {
            IceCream = s;
        }
    }
}
