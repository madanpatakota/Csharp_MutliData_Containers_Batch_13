using System;
using System.Collections.Generic;

class HashSetCollection
{
    public static void Main()
    {

        List<string> names = new List<string>();
        names.Add("Alice");
        names.Add("Alice");
        names.Add("Bob");

       // Dictionary<bool,string>
       


        HashSet<string> uniqueNames = new HashSet<string>();
        uniqueNames.Add("Alice");
        uniqueNames.Add("Alice1");
        uniqueNames.Add("Bob");
        uniqueNames.Add("bafdba;kjbfak;jb");


        Console.WriteLine(names);

        Console.ReadLine();






    }
}

