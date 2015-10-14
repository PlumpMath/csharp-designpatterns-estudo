using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Iterator
{
    public class TwitterIterator : IIterator
    {
        private string[] Users;
        private int Position;

        public TwitterIterator(string[] users)
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
            return Position >= Users.Length;
        }

        public string CurrentItem()
        {
            return Users.ElementAt(Position);
        }
    }
}
