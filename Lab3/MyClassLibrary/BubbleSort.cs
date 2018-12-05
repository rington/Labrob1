using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary

{// Класс который  реализует алгоритм BubbkeSort(сортировка пузырьком)
    public class BubbleSort : ISortStrategy
    {
        public void Sort(int[] arr)
        {
            for (int i = 1; i <= arr.Length - 1; ++i)
            {

                for (int j = 0; j < arr.Length - i; ++j)
                {

                    if (arr[j] > arr[j + 1])
                        Swap(ref arr[j], ref arr[j + 1]);
                }
            }
            Console.WriteLine("\nThe result of bubble sort working is: ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        public static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
