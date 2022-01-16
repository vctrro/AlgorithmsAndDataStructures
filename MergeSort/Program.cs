using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] intData = { 1, 2, 5, 7, 12, 24, 76, 0, 23, 56, 7, 44, 3, 22, 1, 34 };
            string[] stringData = { "1", "2", "asd5", "7sd", "qwe'12", "_24" };

            var result = Sort.MergeSort(intData);

            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
        }
    }
}
