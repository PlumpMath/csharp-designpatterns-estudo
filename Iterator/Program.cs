using Iterator.Aggregate;
using Iterator.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ISocialNetWorking fb = new Facebook();
            ISocialNetWorking tt = new Twitter();

            IIterator fbIterator = fb.CreateIterator();
            IIterator ttIterator = fb.CreateIterator();

            Console.WriteLine("Facebook: ");
            PrintUsers(fbIterator);

            Console.WriteLine("Twitter: ");
            PrintUsers(ttIterator);

            Console.ReadKey();
        }

        private static void PrintUsers(IIterator iterate)
        {
            while (!iterate.IsDone())
            {
                Console.WriteLine(iterate.Next());
            }
        }
    }
}
