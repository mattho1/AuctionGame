using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionGame
{
    public abstract class Gamer
    {
        /// <summary>
        /// Liczba pieniędzy gracza.
        /// </summary>
        protected int wealth;
        /// <summary>
        /// Nazwa gracza.
        /// </summary>
        public string name { get; }
        public Gamer(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// Obniżenie wartości portfela ze wzgledu na naliczony koszt.
        /// </summary>
        /// <param name="cost"></param>
        public void decreaseWealth(int cost)
        {
            wealth -= cost;
        }
        /// <summary>
        /// Zwiększenie wartości portfela ze względu na otrzymaną korzyść.
        /// </summary>
        /// <param name="profit"></param>
        public void increaseWealth(int profit)
        {
            wealth += profit;
        }
        /// <summary>
        /// Zwrócenie wartosci portfela.
        /// </summary>
        /// <returns></returns>
        public int getWealth()
        {
            return wealth;
        }
    }
}
