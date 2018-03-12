using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionGame
{
    public abstract class Thing
    {
        /// <summary>
        /// Pole zawierajace nazwę przedmiotu.
        /// </summary>
        protected string name; 
        /// <summary>
        /// Pole zawierajace wartośc przedmiotu.
        /// </summary>
        public int value { get; set; }
        /// <summary>
        /// Pole zawierajace zdjęcie przedmiotu.
        /// </summary>
        public Image image { get; set; }
        public void setImage(string imageName)
        {
            image = Image.FromFile(imageName);
        }
        /// <summary>
        /// Dane szczególne przedmiotów.
        /// </summary>
        /// <returns></returns>
        abstract public string getSpecialFeatures();
        /// <summary>
        /// Opis przedmiotów.
        /// </summary>
        /// <returns></returns>
        abstract public string getDescription();
        public string getName()
        {
            return name;
        }
    }
}
