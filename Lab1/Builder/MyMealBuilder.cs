using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1.Builder
{
    // Класс MyMealBuilder наследует абстрактный класс MealBuilder и переопределяет его абстрактные методы.
    // В каждом методе устанавливается значение для каждого поля класса Meal.
    // Словарь Dictionary<> используется для подсчета количества вызовов каждого метода. Это число является количеством порций еды,
    // выбранных клиентом
    class MyMealBuilder : MealBuilder
    {
        public enum Meals { tea, kefir, coffee, borshch, boiledFish, mushroomSoup, buckweat, fruits, steak, potato, sausages, cookies }
        public enum TypeOfMeal { breakfast, lunch, dinner }
        protected Dictionary<Meals, int> counter = new Dictionary<Meals, int>();

        public MyMealBuilder(TypeOfMeal meal)
        {
            DictionaryBuilder();
            Console.WriteLine("\tYour {0} menu :", meal);
        }

        public Dictionary<Meals, int> DictionaryBuilder()
        {
            counter = new Dictionary<Meals, int>();
            counter.Add(Meals.kefir, 0);
            counter.Add(Meals.tea, 0);
            counter.Add(Meals.coffee, 0);
            counter.Add(Meals.borshch, 0);
            counter.Add(Meals.fruits, 0);
            counter.Add(Meals.steak, 0);
            counter.Add(Meals.boiledFish, 0);
            counter.Add(Meals.mushroomSoup, 0);
            counter.Add(Meals.potato, 0);
            counter.Add(Meals.sausages, 0);
            counter.Add(Meals.buckweat, 0);
            counter.Add(Meals.cookies, 0);
            return this.counter;

        }

        public override void AddBoiledFish()
        {
            counter[Meals.boiledFish]++;
            Meal.BoiledFish = counter[Meals.boiledFish].ToString() + " portion boiled fish";
        }

        public override void AddBorsch()
        {

            counter[Meals.borshch]++;
            Meal.Borsch = counter[Meals.borshch].ToString() + " portion of ukrainian borsch";
        }

        public override void AddBuckweat()
        {
            counter[Meals.buckweat]++;
            Meal.Buckwheat = counter[Meals.buckweat].ToString() + " portion of buckweat";
        }

        public override void AddCoffee()
        {
            counter[Meals.coffee]++;
            Meal.Coffee = counter[Meals.coffee].ToString() + " portion  of coffee";
        }

        public override void AddFruits()
        {
            counter[Meals.fruits]++;
            Meal.Fruits = counter[Meals.fruits].ToString() + " portion of fruits ";
        }

        public override void AddKefir()
        {
            counter[Meals.kefir]++;
            Meal.Kefir = counter[Meals.kefir].ToString() + " portion of kefir";
        }

        public override void AddMushroomSoup()
        {
            counter[Meals.mushroomSoup]++;
            Meal.MushroomSoup = counter[Meals.mushroomSoup].ToString() + " portion of mushroom soup";
        }

        public override void AddPotato()
        {
            counter[Meals.potato]++;
            Meal.Potato = counter[Meals.potato].ToString() + " portion of boiled potato";
        }

        public override void AddSausages()
        {
            counter[Meals.sausages]++;
            Meal.Sausages = counter[Meals.sausages].ToString() + " portion of sausages";
        }

        public override void AddSteak()
        {
            counter[Meals.steak]++;
            Meal.Steak = counter[Meals.steak].ToString() + " portion beef steak";
        }

        public override void AddTea()
        {
            counter[Meals.tea]++;
            Meal.Tea = counter[Meals.tea].ToString() + " portion of black tea";
        }

        public override void AddCookies()
        {
            counter[Meals.cookies]++;
            Meal.Cookies = counter[Meals.cookies].ToString() + " portion of cookies";
        }
    }
}
