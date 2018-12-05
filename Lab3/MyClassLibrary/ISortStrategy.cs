using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    //Общий интерфейс стратегий сортировки, который будет изменять и
    //добавлять новые виды алгоритмов, не трогая код контекста.


    public interface ISortStrategy
    {
        void Sort(int[] arr);
    }
}
