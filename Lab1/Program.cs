using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab1.Builder;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {       //Создание меню завтрака
            var breakfastBuilder = new MyMealBuilder(MyMealBuilder.TypeOfMeal.breakfast);
            breakfastBuilder.AddCoffee();
            breakfastBuilder.AddCoffee();
            breakfastBuilder.AddBuckweat();
            breakfastBuilder.AddSausages();
            breakfastBuilder.AddSausages();
            breakfastBuilder.AddCookies();
            breakfastBuilder.GetMeal();

            //Создание меню обеда
            var lunchBuilder = new MyMealBuilder(MyMealBuilder.TypeOfMeal.lunch);
            lunchBuilder.AddTea();
            lunchBuilder.AddPotato();
            lunchBuilder.AddBoiledFish();
            lunchBuilder.AddBoiledFish();
            lunchBuilder.AddBorsch();
            lunchBuilder.GetMeal();

            //Создание меню ужина
            var dinnerBuilder = new MyMealBuilder(MyMealBuilder.TypeOfMeal.dinner);
            dinnerBuilder.AddKefir();
            dinnerBuilder.AddFruits();
            dinnerBuilder.AddFruits();
            dinnerBuilder.AddCookies();
            dinnerBuilder.AddFruits();
            dinnerBuilder.GetMeal();

            Console.ReadKey();
        }
    }


}
