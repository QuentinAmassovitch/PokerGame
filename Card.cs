using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    class Card
    {
        public int value { get; set; }
        public string color { get; set; }

        public Card(int value, string color) //defined with value and color(spade, heart etc)
        {
            this.value=value;
            this.color=color;
        }
        
        public string ToString()
        {
          string card = ($"{value}     {color}");
            return card;
        }
       
    }
}
