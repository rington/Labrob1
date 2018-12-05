using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    // Класс который  реализует алгоритма поиска минимального
    // элемента в массиве
    public class FindMinimalElement : ISortStrategy
    {
        public void Sort(int[] arr)
        {
            Array.Sort(arr);
            Console.WriteLine("\nMinimal element in this array is:\n" + arr[0]);

        }
    }
}
