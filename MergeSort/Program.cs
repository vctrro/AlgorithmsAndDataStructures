using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intData = { 1, 2, 5, 7, 12, 24, 76, 0, 23, 56, 7, 44, 3, 22, 1, 34, 809, 3};
            double[] doubData = { 1.4, 2.13, 5.3, 7.42431, 12.12, 12.24, 12.121276, 0.1,
                12.121223, 12.121256, 12.12127, 12.1244, 3, 12.1222, 1, 12.1234, 12.809, 3.14};
            string[] strData = { "1", "2", "asd5", "7sd", "qwe'12", " qwe'1 2", "qwe '12", "_24", "qwe'1 2", "qwe '12", "q we'12" };

            Console.WriteLine("Sort Int data");

            foreach (var item in Sort.MergeSort(intData))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Sort Double data");

            foreach (var item in Sort.MergeSort(doubData))
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine();
            Console.WriteLine("Sort String data");

            foreach (var item in Sort.MergeSort(strData))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Sort String data by length");

            foreach (var item in Sort.MergeSortByLength(strData))
            {
                Console.WriteLine(item);
            }
        }
    }
}
