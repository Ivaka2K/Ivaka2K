using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_1_simple_ex
{
    internal class Program
    {
        //Write a program that given two sorted arrays, produces a third array which contain all elements of the first two, also sorted.
        //For example, if Arr1 is { 1, 2, 5, 8, 10 } and Arr2 is { 3, 4, 5, 9, 15 }, the program should produce { 1, 2, 3, 4, 5, 5, 8, 9, 10, 15 }.
        //The two input arrays can be of different length!

        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 5, 8, 10 };
            int[] array2 = { 3, 4, 5, 9, 15 };
            int[] array3 = new int[array1.Length + array2.Length];

           for (int j = 0, i = 0; i < array3.Length; i++)
            {
                if (i < array1.Length)
                {
                    array3[i] = array1[i];
                }
                if (i == array1.Length || i > array1.Length)
                {
                    array3[i] = array2[j];
                    j++;
                }
            }
            foreach (int element in array3)
            {
                Console.WriteLine(element);
                Array.Sort(array3);
            }           
            Console.ReadKey();
            
        }
        
        
    }
}
