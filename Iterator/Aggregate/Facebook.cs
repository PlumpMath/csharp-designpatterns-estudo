using Iterator.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Aggregate
{
    public class Facebook : ISocialNetWorking
    {
        private LinkedList<string> Users;

        public Facebook()
        {
            // Sign up for an facebook account
            Users = new LinkedList<string>();
            Users.AddLast("Mike");
            Users.AddLast("Jason");
            Users.AddLast("Asad");
            Users.AddLast("Sen");
            Users.AddLast("Vish");
            Users.AddLast("Senthu");
        }

        public Iterator.IIterator CreateIterator()
        {
            return new FacebookIterator(Users);
        }
    }
}
