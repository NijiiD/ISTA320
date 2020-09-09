using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace Exercise08
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] numRange = { 1, 2, 3, 4, 5, 6, 8, 9, 10 };

            List<int> numlist = new List<int>(numRange);
            //double val1 = Math.Log2(10);

            //Console.WriteLine(val1);

            int enteredNum = Convert.ToInt32(Console.ReadLine());
            bisectionMethod(enteredNum, numRange);
            
        }
        public static bool bisectionMethod(int value, int[] sortednumRange)
        {
            //check the length

            int middle = (int)sortednumRange.Length / 2;
            var middleNumber = sortednumRange[middle];
            if (middleNumber == value)
            {
                return true;
            }

            var halfofNumrange = new List<int>();
            for (int j = 0; value <= middle; middle--)
            {
                
                Console.WriteLine(value);
            }
            //return bisectionMethod(value, halfofNumrange);
            return false;
        }
        //public static bool ContainsNumber(List<int> sortedInts, int value)
        //{
        //    //do something to split list into 2 lists
        //    //use Console.WriteLine(); to print out your steps
        //    //var lowerHalfOfInts
        //    //var upperHalfOfInts

        //    //check to see what list would contain the value

        //    //make sure you have a way to break out of the recursion


        //    //this is the recursion part
        //    ContainsNumber(sortedInts, value);
        //}

    }
}
