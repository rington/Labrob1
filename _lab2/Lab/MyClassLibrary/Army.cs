using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    
    public class Army
    {
        private List<Component> army = new List<Component>();
        public Army()
        {
            Console.WriteLine("\t\tФАНТАСТИЧЕСКАЯ АРМИЯ");
        }
        public void Add(Component component)
        {
            army.Add(component);
        }
        public void Remove(Component component)
        {
            army.Remove(component);
        }
        public void Display()
        {
            for (int i = 0; i < army.Count; i++)
            {
                army[i].Display();
            }

        }

    }
}
