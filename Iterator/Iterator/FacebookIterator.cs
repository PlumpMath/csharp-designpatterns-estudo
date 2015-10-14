using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Iterator
{
    public class FacebookIterator : IIterator
    {

        private LinkedList<string> Users;
        private int Position;

        public FacebookIterator(LinkedList<string> users)
        {
            Users = users;
            Position = 0;
        }

        public void First()
        {
            Position = 0;
        }

        public string Next()
        {
            return Users.ElementAt(Position++);
        }

        public bool IsDone()
        {
            return Position >= Users.Count;
        }

        public string CurrentItem()
        {
            return Users.ElementAt(Position);
        }
    }
}
