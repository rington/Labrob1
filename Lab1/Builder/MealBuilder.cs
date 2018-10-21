using System;

namespace Lab1
{
    // Абстрактный класс строителя. В конструкторе абстрактного класса MealBuilder создается объект класса Meal, тут создаются абстрактные методы
    // для добавления той или инной позиции еды в кастомное меню
    abstract class MealBuilder
    {
        protected Meal Meal;
        protected MealBuilder()
        {
            Meal = new Meal();
        }

        public void GetMeal()
        {
            Console.WriteLine(Meal);
        }

        public abstract void AddBuckweat();
        public abstract void AddPotato();
        public abstract void AddMushroomSoup();
        public abstract void AddBorsch();
        public abstract void AddSteak();
        public abstract void AddSausages();
        public abstract void AddBoiledFish();
        public abstract void AddTea();
        public abstract void AddCoffee();
        public abstract void AddFruits();
        public abstract void AddKefir();
        public abstract void AddCookies();
    }
}