using System;
using System.Collections.Generic;

namespace Lab_4_Alg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("a");
            list.Add("aaafc");
            list.Add("aaad");
            list.Add("aDsba");
            list.Add("ca");
            list.Add("aaa");
            list.Add("aaafd");
            list.Add("a");
            list.Add("c");

            Algorithms.BubbleSort(list);
            Checker.GetAverageTime();
            foreach (var item in Checker.ResultTime)
            {
                Console.WriteLine(item);
            }
            Checker.ResultTime.Clear();
            Console.WriteLine("------");
            PyramidSorting.Sorting(list);
            Checker.GetAverageTime();
            foreach (var item in Checker.ResultTime)
            {
                Console.WriteLine(item);
            }
            Checker.ResultTime.Clear();

            //int n = 1;
            //while (n <= 11)
            //{
            //    for (int i = 0; i < 5; i++)
            //    {
            //        //Algorithms.BubbleSort(Checker.GetWordsList(n));
            //        //Algorithms.InsertionSort(Checker.GetWordsList(n));  ////исключила
            //        PyramidSorting.Sorting(Checker.GetWordsList(n));
            //    }
            //Checker.GetAverageTime();
            //    n++;

            //}
            //foreach (var item in Checker.ResultTime)
            //{
            //    Console.WriteLine(item);
            //}
            //Checker.ResultTime.Clear();


        }



        
    }
}
