using System;
using System.Collections.Generic;
using System.Text;

namespace CoachConsole
{
    class Coach
    {
        private Person[] contents;

        private int nextFreeLocation;
        private int coachSize;
        private int size;

        public Coach(int theCoachSize)
        {
            coachSize = theCoachSize;
            contents = new Person[theCoachSize];
        }

        public bool AddPerson(Person thePerson)
        {
            if (nextFreeLocation != size)
            {
                contents[nextFreeLocation] = thePerson;
                nextFreeLocation++;
                return true;
            }
            return false;
        }

        public int GetSeatByName(string passenger)
        {
            for (int i = 0; i < nextFreeLocation; i++)
            {
                if (passenger == contents[i].GetName())
                {
                    return i;
                }
            }
            return -1;
        }

        public bool RemovePerson(Person thePerson)
        {
            
        }

        public int GetNumOfPassengers()
        {

        }
    }
}