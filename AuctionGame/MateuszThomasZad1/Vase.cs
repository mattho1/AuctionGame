using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionGame
{
    public class Vase: Thing
    {
        /// <summary>
        /// Zmienna określająca rodzaj materiału z jakiego zrobiona jest waza.
        /// </summary>
        string material { get; }
        /// <summary>
        /// Zmienna określająca jakiego typu jest waza. Rola informacyjna.
        /// </summary>
        string type { get; }
        public Vase(string nameImage, int vaseValue, string material, string type) 
        {
            setImage(nameImage);
            name = nameImage.Replace(".png", "");
            value = vaseValue;
            this.material = material;
            this.type = type;
            
        }
        /// <summary>
        /// Zwraca dane informacyjne o cechach szczególnych danej wazy.
        /// </summary>
        public override string getSpecialFeatures()
        {
            return material + ", " + type;
        }
        /// <summary>
        /// Funkcja tworzy opis przedmiotu.
        /// </summary>
        /// <returns></returns>
        public override string getDescription()
        {
            return name.Replace(".png","") + "\r\n" + "Materiał: " + material + "\r\n" + "Rodzaj: " + type;
        }
    }
}
