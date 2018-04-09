using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<string> students = new List<string>();
            //students.Add("Sue");
            //students.Add("Bill");
            //students.Add("Allen");

            //students.Count
            ////3
            //students[0];
            ////"Sue"
            //students[students.Count - 1];
            ////"Allen"
            //students.Capacity
            ////4
            // When a list runs out of room it instantiates a new list with twice the capacity
            //students.Add("Beth");
            //students.Add("Mary");
            //students.Count
            ////5
            //students.Capacity
            ////8
            //List<string> studentsTwo = new List<string>(500);
            //students.Capacity
            ////500


            //-----------------------------------------------------------

            //List<string> students = new List<string>();
            //students.Add("Sue");
            //students.Add("Bill");
            //students.Add("Allen");
            //studnets.Count



            //students.Count
            ////3
            //students[0];
            ////   "Sue"
            //students[students.Count - 1];
            ////   "Allen"
            //students.Capacity
            ////4


            //List<string> students = new List<string>(5) { "sue", "BIll", "allen", "beth", "mary" }
            //students.Capacity
            ////5
            //string[] studentArray = students.ToArray();
            //studentArray
            ////{ "sue", "BIll", "allen", "beth", "mary" }
            //students.Insert(1, "frank");
            //students
            //{ "sue", "Frank", "BIll", "allen", "beth", "mary" }

            //students.RemoveAt(2); ///removes at index
        }

        public static void SearchingLists()
        {
            List<string> students = new List<string>() { "Sue", "Frank", "Allen", "Beth", "Mary" };

            Console.WriteLine(students);
            students.Remove("Frank");
            ////true   //if frank found and removed
            // more than one, removes first
            //calls IndexOf, then RemoveAt


        }

        public static List<int> GetPowersOf2(int input)
        {
            var powers = new List<int>();

            for (int i = 0; i < input + 1; i++)
            {
                powers.Add((int)System.Math.Pow(2, i));
            }

            return powers;
        }


    }

    public class SortingLists
    {

        public static void Notes()
        {
            List<string> students = new List<string>() { "Sue", "Frank", "Allen", "Beth", "Mary" };
            students.Sort();
            //students
            //// { "Allen", "Beth"....


        }
    }
}

