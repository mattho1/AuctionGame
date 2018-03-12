using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionGame
{
    class Computer : Gamer
    {
        /// <summary>
        /// Poziom trudności z jakim gra komputer.
        /// </summary>
        private int dificultyLevel;
        public Computer(int dificultyLevel, string name) : base(name)
        {
            this.dificultyLevel = dificultyLevel;
            wealth = 10000000;
        }
        /// <summary>
        /// Podejmowanie decyzji przez komputer czy zalicytowac czy nie i z jaką kwotą.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="actualPrice"></param>
        /// <returns></returns>
        public int licytuj(int value, int actualPrice)
        {
            Random randomNumber = new Random();
            int decision = 0;
            switch(dificultyLevel)
            {
                case 0:
                    decision = randomNumber.Next(0, 6);
                    break;
                case 1:
                    decision = randomNumber.Next(0, 5);
                    break;
                case 2:
                    decision = randomNumber.Next(0, 4);
                    break;
            }
            
            if (decision == 0 || decision == 1 || decision == 2)
            {
                if((100* actualPrice) < 160 * value)
                {
                    return randomNumber.Next(100 * actualPrice, 160 * value) / 100;
                }else
                {
                    return 0;
                }                
            }
            else
            {
                return 0;
            } 
        }
        /// <summary>
        /// Przywraca początkowe środki na konto. Komputer nie może zbankrutować.
        /// </summary>
        public void odnowPortfel()
        {
            wealth = 10000000;
        }
    }
}
