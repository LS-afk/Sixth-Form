using System;
using System.Collections.Generic;
using System.Text;

namespace CoachConsole
{
    class Person
    {
        private String name = "";

        private int age = 0;

        public void SetName(String theName)
        {
            name = theName;
        }

        public String GetName()
        {
            return name;
        }

        public void SetAge(int theAge)
        {
            age = theAge;
        }

        public int GetAge()
        {
            return age;
        }
    }
}
