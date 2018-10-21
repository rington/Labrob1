using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1
{
    // Класс Meal хранит поля всех блюд
    class Meal
    {
        public string Buckwheat { get; set; }
        public string Potato { get; set; }
        public string MushroomSoup { get; set; }
        public string Borsch { get; set; }
        public string Steak { get; set; }
        public string Sausages { get; set; }
        public string BoiledFish { get; set; }
        public string Tea { get; set; }
        public string Coffee { get; set; }
        public string Fruits { get; set; }
        public string Kefir { get; set; }
        public string Cookies { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Buckwheat: {0}\n", Buckwheat);
            sb.AppendFormat("Potato: {0}\n", Potato);
            sb.AppendFormat("MushroomSoup: {0}\n", MushroomSoup);
            sb.AppendFormat("Borsch: {0}\n", Borsch);
            sb.AppendFormat("Steak: {0}\n", Steak);
            sb.AppendFormat("Sausages: {0}\n", Sausages);
            sb.AppendFormat("BoliedFish: {0}\n", BoiledFish);
            sb.AppendFormat("Tea: {0}\n", Tea);
            sb.AppendFormat("Coffee: {0}\n", Coffee);
            sb.AppendFormat("Fruits: {0}\n", Fruits);
            sb.AppendFormat("Kefir: {0}\n", Kefir);
            sb.AppendFormat("Cookies: {0}\n", Cookies);

            return sb.ToString();
        }

    }
}
