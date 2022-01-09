using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    class Player
    {
        public string Name { get; set; }
        public Card [] Hand { get; set; }
        public int Money { get; set; }

        public Player() //each players is defined by a hand a name and an amount of money
        {
            
            this.Hand = new Card[2];
            this.Money = 100;
        }

        public string ToString()
        {
            string player = $"{Name} : {Hand[0].ToString()}  {Hand[1].ToString()}";
            return player;
        }
    }
}
