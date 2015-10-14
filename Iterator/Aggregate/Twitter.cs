using Iterator.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Aggregate
{
    public class Twitter : ISocialNetWorking
    {
        private string[] Users;

        public Twitter()
        {
            Users = new[] { "Kathy", "Lori", "Kristen", "Jasmine" };
        }

        public Iterator.IIterator CreateIterator()
        {
            return new TwitterIterator(Users);
        }
    }
}
