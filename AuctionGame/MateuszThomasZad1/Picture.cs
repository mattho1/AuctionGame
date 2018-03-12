using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionGame
{
    public class Picture : Thing
    {
        /// <summary>
        /// Zmienna określająca rodzaj malarskiego w jakim wykonany jest obraz.
        /// </summary>
        public string paintingStyle { get; }
        /// <summary>
        /// Zmienna określająca wiek z jakiego pochodzi obraz. 
        /// </summary>
        public string century { get; }
        public Picture(string nameImage, int pictureValue, string paintingStyle, string century)
        {
            setImage(nameImage);
            name = nameImage.Replace(".png", "");
            value = pictureValue;
            this.paintingStyle = paintingStyle;
            this.century = century;
            
        }
        /// <summary>
        /// Zwraca dane informacyjne o cechach szczególnych danego obrazu.
        /// </summary>
        public override string getSpecialFeatures()
        {
            return paintingStyle + ", " + century;
        }
        /// <summary>
        /// Funkcja tworzy opis przedmiotu.
        /// </summary>
        /// <returns></returns>
        public override string getDescription()
        {
            return name.Replace(".png", "") + "\r\n" + "Styl malowania: " + paintingStyle + "\r\n" + "Wiek: " + century ;
        }
    }
}
