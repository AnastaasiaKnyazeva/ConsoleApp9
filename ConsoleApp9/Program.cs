using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, -2, 3, -4, 5 };

            Console.WriteLine("Исходный массив:");
            PrintArray(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    arr[i] *= 2;
                }
                else if (arr[i] < 0)
                {
                    arr[i] *= 3;
                }
            }

            Console.WriteLine("Массив после умножения:");
            PrintArray(arr);

            Console.ReadKey();
        }

        static void PrintArray(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }



       
    }
}
