using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;

namespace Program
{
    //Программа выводит дерево войс и общее количество
    class Program
    {
        static void Main(string[] args)
        {
            Run();
            Console.Read();
        }
        static public void Run()
        {
            int armyQuantity = 0;
            Army army = new Army();

            Squad elfSquad = new Squad(Race.elf);
            Squad minotaurSquad = new Squad(Race.minotaur);
            Squad centaurSquad = new Squad(Race.centaur);
            Squad knightSquad = new Squad(Race.knight);
            Squad orcSquad = new Squad(Race.orc);
            Squad cyclopsSquad = new Squad(Race.cyclops);
            Squad cyclopsSquad2 = new Squad(Race.cyclops);
            Squad elfSquad2 = new Squad(Race.elf);
            Soldier hydra = new Soldier(Race.hydra);
            Soldier dragon = new Soldier(Race.dragon);

            //Создание войс и добавление количества воинов каждой расы в состав армии
            var orcSoldiers = Enumerable.Range(1, 4).Select(x => new Soldier(Race.orc));
            orcSquad.AddAll(orcSoldiers);
            armyQuantity += Enumerable.Range(1, 4).Select(x => new Soldier(Race.orc)).Count();


            var elfSoldiers = Enumerable.Range(1, 12).Select(x => new Soldier(Race.elf));
            elfSquad.AddAll(elfSoldiers);
            armyQuantity += Enumerable.Range(1, 12).Select(x => new Soldier(Race.elf)).Count();

            var elfSoldiers2 = Enumerable.Range(1, 6).Select(x => new Soldier(Race.elf));
            elfSquad2.AddAll(elfSoldiers2);
            elfSquad.Add(elfSquad2);
            armyQuantity += Enumerable.Range(1, 6).Select(x => new Soldier(Race.elf)).Count();


            var minotaurSoldiers = Enumerable.Range(1, 5).Select(x => new Soldier(Race.minotaur));
            minotaurSquad.AddAll(minotaurSoldiers);
            armyQuantity += Enumerable.Range(1, 5).Select(x => new Soldier(Race.minotaur)).Count();

            var centaurSoldiers = Enumerable.Range(1, 5).Select(x => new Soldier(Race.centaur));
            centaurSquad.AddAll(centaurSoldiers);
            armyQuantity += Enumerable.Range(1, 5).Select(x => new Soldier(Race.centaur)).Count();

            var knightSoldiers = Enumerable.Range(1, 20).Select(x => new Soldier(Race.knight));
            knightSquad.AddAll(knightSoldiers);
            armyQuantity += Enumerable.Range(1, 10).Select(x => new Soldier(Race.knight)).Count();

            var cyclopsSoldiers = Enumerable.Range(1, 8).Select(x => new Soldier(Race.cyclops));
            cyclopsSquad.AddAll(cyclopsSoldiers);
            armyQuantity += Enumerable.Range(1, 8).Select(x => new Soldier(Race.cyclops)).Count();

            var cyclopsSoldiers2 = Enumerable.Range(1, 4).Select(x => new Soldier(Race.cyclops));
            cyclopsSquad2.AddAll(cyclopsSoldiers2);
            cyclopsSquad.Add(cyclopsSquad2);
            armyQuantity += Enumerable.Range(1, 4).Select(x => new Soldier(Race.cyclops)).Count();


            army.Add(hydra);
            army.Add(dragon);
            army.Add(elfSquad);
            army.Add(minotaurSquad);
            army.Add(centaurSquad);
            army.Add(knightSquad);
            army.Add(orcSquad);
            army.Add(cyclopsSquad);
            army.Display();
            Console.WriteLine("\n\n\tОбщее количество войск : {0} ", armyQuantity);
        }
    }
}
