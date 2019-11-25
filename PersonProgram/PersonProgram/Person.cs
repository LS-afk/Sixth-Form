using System;
using System.Collections.Generic;
using System.Text;

namespace PersonProgram
{
    public class Person

    {

        private String name = "";

        private int age = 0;

        private Address livesAt;


        public void SetName(String theName)
        {
            name = theName;
        }

        public String getName()
        {
            return name;
        }

        public void SetAge(int theAge)
        {
            age = theAge;
        }

        public int getAge()
        {
            return age;
        }
    }
}
