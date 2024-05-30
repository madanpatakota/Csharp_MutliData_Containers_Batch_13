using System;
using System.Collections.Generic;

class Dictionary_Collection
{

    //I want the key not like [0] [1] [2]
    //                        Firstname , Salary , Location
    static void Main()
    {
        List<int> ints = new List<int>();
        ints.Add(10);
        ints.Add(20);
        ints.Add(30);

        Console.WriteLine(ints[0]);

        //Console.ReadLine();

        Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();

        //                   key     value
        keyValuePairs.Add("RamuAge", 10);
        keyValuePairs.Add("SankarAge", 20);
        keyValuePairs.Add("ChinnaAge", 30);

        try
        {
            keyValuePairs.Add("ChinnaAge", 40);
        }
        catch (Exception e)
        {
            {
                Console.WriteLine("Something is wrong");
            }

            Console.WriteLine(keyValuePairs["ChinnaAge"]);   // 10

            bool isKey = keyValuePairs.ContainsKey("SankarAge");

            if (isKey)
            {
                Console.WriteLine(keyValuePairs["SankarAge"]);
            }
            else
            {
                Console.WriteLine("Key is not available");
            }


            //you can design any kind of value in var and value would be decide before execution of the code 
            var item1 = "Csharp";
            var item2 = 10;
            var item3 = 40;
            var item4 = 50;


            //Tomoto[] Tomototoitems = new Tomoto[] { "Tomot1" , "tomoto2" , "tomoto3" };
            //foreach (tomoto item in Tomototoitems)
            //{
            //      if(tomoto == "")
            //{
            //     items.add(tomtor)
            //}
            //    //Console.WriteLine(item);
            //}

            var item5 = new int[] { 1, 2, 3, 4, 5 };

            var item6 = new string[] { "1", "2", "3" };

            int number;  //Why ???

            //Console.WriteLine(number); 0

            //Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
            foreach (KeyValuePair<string, int> keyvalue in keyValuePairs)
            {
                Console.WriteLine($"By KeyValuePair :  Key is {keyvalue.Key} , value is {keyvalue.Value}");
            }

            foreach (var keyvalue in keyValuePairs)
            {
                Console.WriteLine($"By var : Key is {keyvalue.Key} , value is {keyvalue.Value}");
            }

            //object is a key value pair
            //string , int , bool , int[]

            //foreach(keyValuePairs)
            Console.ReadLine();

        }
    }
}

//Home work:

//-------------------------| 
//   Key       | value     |
//-------------|-----------|
//  Alice      | 90        |
//  Bob        | 85        |
//  Charlie    | 92        |

