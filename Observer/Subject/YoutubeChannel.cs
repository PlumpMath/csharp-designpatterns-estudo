using Observer.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Subject
{
    public class YoutubeChannel
    {
        private IList<ISubscriber> subscribers = new List<ISubscriber>();

        public void Subscribe(ISubscriber s)
        {
            subscribers.Add(s);
        }

        public void Unsubscribe(ISubscriber s)
        {
            subscribers.Remove(s);
        }

        public void NotifySubscribers()
        {
            foreach(ISubscriber s in subscribers)
            {
                s.Notify();
            }
        }
    }
}
