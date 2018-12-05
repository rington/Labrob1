using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {

            var _myarray = new MyArray(25, new FindMaximalElement());
            _myarray.Sort();
            //смена реализации алгоритма
            _myarray.SortStrategy = new FindMinimalElement();
            _myarray.Sort();
            _myarray.SortStrategy = new BubbleSort();
            _myarray.Sort();
            _myarray.SortStrategy = new MergeSort();
            _myarray.Sort();
            Console.ReadKey();
        }
    }
} 
