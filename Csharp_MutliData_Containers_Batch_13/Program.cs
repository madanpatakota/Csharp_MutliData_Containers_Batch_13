using System;   //Array : FixedSize(Sametype) cannot add the new values
using System.Collections;  //ArrayList   //List Add dynamic values with can differenct daatatypes
using System.Collections.Generic; //List Add dynamic values with same daatatype
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_MutliData_Containers_Batch_13
{
    internal class Program
    {

        static int[] GetArrayNumbers()
        {
            int[] numbers = new int[4]; //fixed size
            numbers[0] = 100000;
            numbers[1] = 10;
            numbers[2] = 20;
            numbers[3] = 30;  // upto 4 values
                              //I crossed the limit
                              //numbers[4] = 40;
                              //numbers[5] = 50;
                              //numbers[6] = 50;


            Console.WriteLine($"number at 3 rd {numbers[3]} -- {numbers[2]}"); //30

            return numbers;
        }


        static List<string> GetLocationsList()
        {
            List<int> listint = new List<int>() { 100 };

            listint.Add(0);
            listint.Add(10);
            listint.Add(20);
            //listint[0] = 0;
            //listint[1] = 10;
            //listint[2] = 20;
            //listint[3] = 30;  // upto 4 values

            listint.Add(40);
            listint.Add(50);
            listint.Add(60);

            listint.Add(50);
            //listint.Add("Madan");



            // 10 , "Hyderabad"

            List<string> listLocations = new List<string>() { "Hyderbad", "Delhi" };

            listLocations.Add("Bangolore");
            listLocations.Add("Madras");

            foreach (string location in listLocations)
            {
                Console.WriteLine($"{location}");
            }

            return listLocations;
        }







        static void Main()
        {
            // int[] ints = { 1, 2, 3 }; // Assignment

            int[] result = GetArrayNumbers();

            //Console.WriteLine("number at 3 rd" + numbers[3]); //30
            //Console.WriteLine($"number at 3 rd {numbers[10]}"); //30

            //A List, on the other hand, is a dynamic, ordered collection of elements of the same type.

            List<string> result1 = GetLocationsList();

            //int[] numbers = new int[4]; //fixed size
            ArrayList arrayList = new ArrayList() { 10.90 , 11 , 12, 13 };



            arrayList[0] = 100000;
            arrayList[1] = 209876;
            arrayList[3] = "Madan"; // Assigning the value..

            arrayList.Add(false);  // Add new value
            arrayList.Add(false);  // Add new value

            int range = arrayList.Count;

            arrayList.Add("Madras");

            int range1 = arrayList.Count;



            //arrayList.Add(1);
            //arrayList.Add("Hyderabad");
            //arrayList.Add(true);

            Console.WriteLine(arrayList[1]); //10 Hyderabad









            //  ArrayList

            //10, "Hyderabad"

            Console.ReadLine();

        }


    }
}
