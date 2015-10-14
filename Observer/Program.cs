using Observer.Observer;
using Observer.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            YoutubeChannel muriloxkChannel = new YoutubeChannel();

            ISubscriber joey = new User();
            ISubscriber alex = new User();
            ISubscriber gai = new Moderator();

            muriloxkChannel.Subscribe(joey);
            muriloxkChannel.Subscribe(alex);
            muriloxkChannel.Subscribe(gai);

            muriloxkChannel.NotifySubscribers();
            Console.ReadKey();
        }
    }
}
