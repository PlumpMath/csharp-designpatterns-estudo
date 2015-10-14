using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Observer
{
    public class Moderator : ISubscriber
    {
        public void Notify()
        {
            Console.WriteLine("Hey moderator, watch the new video!");
        }
    }
}
