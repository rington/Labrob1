using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    // Даный класс имплементирует класс Component
    // Каждый солдат имеет свою расу
    public class Soldier : Component
    {

        public Soldier(Race SoldierRace) : base(SoldierRace)
        {

        }
        public Soldier()
        {

        }
        public override void Display()
        {
            Console.WriteLine("Солдат расы : {0}", SoldierRace);

        }


    }
}
