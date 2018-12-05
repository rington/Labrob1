using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{   // Класс который  реализует алгоритма поиска максимального
    // элемента в массиве
    public class FindMaximalElement : ISortStrategy
    {
        public void Sort(int[] arr)
        {
            Array.Sort(arr);
            Console.WriteLine("\n\nMaximal element in this array is:\n" + arr[arr.Length - 1]);

        }

    }
}
