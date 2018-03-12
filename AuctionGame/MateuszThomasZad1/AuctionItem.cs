using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AuctionGame
{
    class AuctionItem
    {
        /// <summary>
        /// Przedmiot jaki reprezentuje dana aukcja.
        /// Zawiera wszystkie informacje o przedmiocie aukcji.
        /// </summary>
        private Thing thing;
        public AuctionItem( Thing thing)
        {
            this.thing = thing;
        }
        /// <summary>
        /// Zwraca zdjęcie przedmiotu aukcji.
        /// </summary>
        /// <returns></returns>
        public Image getPicture()
        {
            return thing.image;
        }
        /// <summary>
        /// Zwraca nazwę przedmiotu aukcji.
        /// </summary>
        /// <returns></returns>
        public string getName()
        {
            return thing.getName();
        }
        /// <summary>
        /// Zwraca wartość przedmiotu aukcji.
        /// </summary>
        /// <returns></returns>
        public int getValue()
        {
            return thing.value;
        }
        /// <summary>
        /// Zwraca opis cech szczególnych aukcji.
        /// </summary>
        /// <returns></returns>
        public string getSpecialFeaturesItems()
        {
            return thing.getSpecialFeatures();
        }
        /// <summary>
        /// Zwraca przedmiot aukcji.
        /// </summary>
        /// <returns></returns>
        public Thing getThing()
        {
            return thing;
        }
        /// <summary>
        /// Zwraca cene wywoławczą aukcji.
        /// </summary>
        /// <returns></returns>
        public int initialPriceAuction()
        {
            return (50 * thing.value / 100);
        }
        /// <summary>
        /// Zwraca opis przedmiotu aukcji.
        /// </summary>
        /// <returns></returns>
        public string getDescriptionThingAuction()
        {
            return thing.getDescription();
        }
    }
}
