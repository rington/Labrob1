using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{   
    //Даный класс импементирует класс Component
    //Хранит список солдатов определенной расы
    
    public class Squad : Component
    {
        private List<Component> soldiers = new List<Component>();
        public Squad(Race SoldierRace) : base(SoldierRace)
        {

        }
        public Squad()
        {

        }
        public override void Add(Component soldier)
        {
            soldiers.Add(soldier);

        }
        public override void Remove(Component soldier)
        {
            soldiers.Remove(soldier);
        }
        public override void Display()
        {
            Console.WriteLine("\tОтряд расы : " + SoldierRace);


            for (int i = 0; i < soldiers.Count; i++)
            {
                Console.WriteLine();
                if (soldiers[i] is Squad)
                {
                    Console.WriteLine("\tПодотряд главного отряда: ");
                }
                soldiers[i].Display();
            }


        }

    }
}
