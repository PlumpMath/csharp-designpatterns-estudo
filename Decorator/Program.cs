using Decorator.Component;
using Decorator.ConcreteDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Que problema ele resolve?
            // Anexar responsabilidades adicionais a um objeto dinamicamente. 
            // Decoradores fornecem uma alternativa flexível para subclasse para ampliar a 
            // funcionalidade.

            //Fontes:
            // https://sourcemaking.com/design_patterns/decorator
            // https://www.youtube.com/watch?v=nk9Z1vwO3RI


            IceCream iceCream = new Chocolate();
            iceCream = new Sprinkle(iceCream);
            iceCream = new Fudge(iceCream);

            Console.WriteLine(iceCream.Cost());
            Console.ReadKey();
        }
    }
}
