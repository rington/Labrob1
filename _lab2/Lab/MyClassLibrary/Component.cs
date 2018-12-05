using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    // Абстрактный класс Component хранит ключевые виртуальные методы, которые переопределяются в последующих классах
    // которые реализуют даный абстрактный класс. 
    // Структура программы состоит из следующих классов :
    // Component -> Soldier -> Squad ->Army
    // Каждый последующий класс хранит список объектов предыдущего класса

    public enum Race { elf, orc, minotaur, centaur, cyclops, dragon, hydra, knight }
    public abstract class Component
    {
        public Race SoldierRace;

        public Component(Race SoldierRace)
        {
            this.SoldierRace = SoldierRace;
        }
        public Component()
        {

        }
        public virtual void Add(Component soldier) { }

        public virtual void Remove(Component soldier) { }

        public virtual void Display() { }
        public void AddAll(IEnumerable<Component> components)
        {
            foreach (var cmpnt in components)
            {
                Add(cmpnt);
            }
        }

    }
}
