using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionGame
{
    class Sculpture : Thing
    {
        /// <summary>
        /// Zmienna określająca rodzaj materiału z jakiego zrobiona jest rzeźba.
        /// </summary>
        public string material { get; }
        /// <summary>
        /// Zmienna określająca wiek danej rzeźby. 
        /// </summary>
        public string century { get; }
        public Sculpture(string nameImage, int sculptureValue , string material, string century)
        {
            setImage(nameImage);
            name = nameImage.Replace(".png", ""); ;
            value = sculptureValue;
            this.material = material;
            this.century = century;
            
        }
        /// <summary>
        /// Zwraca dane informacyjne o cechach szczególnych danej rzeźby.
        /// </summary>
        /// <returns></returns>
        public override string getSpecialFeatures()
        {
            return material + ", " + century;
        }
        /// <summary>
        /// Funkcja tworzy opis przedmiotu.
        /// </summary>
        /// <returns></returns>
        public override string getDescription()
        {
            return name.Replace(".png", "") + "\r\n" + "Materiał: " + material + "\r\n" + "Wiek: " + century;
        }
    }
}
