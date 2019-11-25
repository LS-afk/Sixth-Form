using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ListExercises

{
    private string[] names = new string[10];

    private int nextFreeLocation = 0;

    public int AddNameToList(string theName)
    {
        if (nextFreeLocation > names.Length) return -1;
        int position = 0;
        while ((position < nextFreeLocation) && (theName.CompareTo(names[position]) > 0))
        {
            position = position + 1;
        }

        for int 

        return -1;
    }

    public int FindPositionOfName(string theName)
    {
        return -1;
    }

    public bool RemoveByPosition(int thePosition)
    {
        return true;
    }

    public String GetListAsString()
    {
        string temp = "";

        for (int i = 0; i < nextFreeLocation; i++)
        {

            temp = temp + names[i] + "\n";

        }

        return temp;
    }
}