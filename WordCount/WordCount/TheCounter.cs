using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCounter
{
    public class TheCounter
    {
        private WordCountPair[] collection;
        private int nextFreeLocation = 0;

        public TheCounter(int maxSize)
        {
            collection = new WordCountPair[maxSize];
        }

        public int AddString(String newWord)
        {
            return 1;
        }

        public override string ToString()
        {
            String theString = "";
            return theString;
        }
    }
}
