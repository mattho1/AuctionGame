using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AuctionGame
{
    public class Human: Gamer
    {
        /// <summary>
        /// Lista rzeczy wylicytowanych przez gracza.
        /// </summary>
        private List<Thing> listThings;
        /// <summary>
        /// Poziom gracza.
        /// </summary>
        private int level { get; set; }

        public Human(string name) : base(name)
        {
            level = 1;
            listThings = new List<Thing>();
            wealth = 5000;
        }
        /// <summary>
        /// Dodanie przedmiotu do listy przedmiotów gracza po wygraniu licytacji.
        /// </summary>
        /// <param name="thing"></param>
        public void addThing(Thing thing)
        {
            listThings.Add(thing);
        }
        /// <summary>
        /// Usunięcie przedmiotu z listy przedmiotów gracza.
        /// </summary>
        /// <param name="name"></param>
        public void removeThing(string name)
        {
            listThings.RemoveAt(findItem(name));
        }
        /// <summary>
        /// Zmiana poziomu gracza na podstawie kwoty zakupu i sprzedaży przedmiotu.
        /// </summary>
        /// <param name="sellingPrice"></param>
        /// <param name="price"></param>
        public void changeLevel(int sellingPrice, int price)
        {
            if(sellingPrice - price < 0)
            {
                level--;
                if(level <= 0)
                {
                    level = 1;
                }
            }else if(sellingPrice - price > 0)
            {
                level++;
            }
        }
        /// <summary>
        /// Zwraca liste przedmiotów gracza.
        /// </summary>
        /// <returns></returns>
        //public List<Thing> getListThings()
        //{
        //    return listThings;
        //}
        /// <summary>
        /// zwraca przedmiot o nazwie podanej jako argument.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Thing getItem(string name)
        {
            return listThings[findItem(name)];
        }
        public Image getImageThing(string name)
        {
            return listThings[findItem(name)].image;
        }
        /// <summary>
        /// Zwraca numer przedmiotu o nazwie podanej jako argument na liście przedmiotów gracza.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private int findItem(string name)
        {
            int numberFindThing = 0;
            for (int i = 0; i < listThings.Count; i++)
            {
                if (listThings[i].getName().Equals(name))
                {
                    numberFindThing = i;
                    break;
                }
            }
            return numberFindThing;
        }
        public int getLevel()
        {
            return level;
        }
    }
}
