using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
     //Класс который заполняет и хранит массив числовых объктов, в конструкторе которого
     // можно менять имплементацию алгоритма той или инной сортировки или поиска
    public class MyArray
    {
        public int[] array;
        protected int quantity = 0;
        public ISortStrategy SortStrategy { get; set; }
        public MyArray(int _quantity, ISortStrategy strategy)
        {
            array = new int[_quantity];
            this.quantity = _quantity;
            SortStrategy = strategy;
            Random rand = new Random();
            Console.WriteLine("Our array of elements:");
            for (int i = 0; i < _quantity; i++)
            {
                array[i] = rand.Next(1, 100);
                Console.Write(array[i] + " ");
            }

        }
        public void Sort()
        {
            SortStrategy.Sort(array);
        }
    }
}
