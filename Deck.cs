using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    class Deck
    {
        public List<Card> DeckofCards {get ;set;}
        public List<Player> Party { get; set; }


        public Deck()
        {
            this.DeckofCards = DeckCreation();
            this.Party = new List<Player>();
            
        }
        public List<Card> DeckCreation() //I initialized the 56 cards
        {



            Card twospade = new Card(2, "spade");
            Card threespade = new Card(3, "spade");
            Card fourspade = new Card(4, "spade");
            Card fivespade = new Card(5, "spade");
            Card sixspade = new Card(6, "spade");
            Card sevenspade = new Card(7, "spade");
            Card eightspade = new Card(8, "spade");
            Card ninespade = new Card(9, "spade");
            Card tenspade = new Card(10, "spade");
            Card jackspade = new Card(11, "spade");
            Card queenspade = new Card(12, "spade");
            Card kingspade = new Card(13, "spade");
            Card aspade = new Card(14, "spade");

            Card twoheart = new Card(2, "heart");
            Card threeheart = new Card(3, "heart");
            Card fourheart = new Card(4, "heart");
            Card fiveheart = new Card(5, "heart");
            Card sixheart = new Card(6, "heart");
            Card sevenheart = new Card(7, "heart");
            Card eightheart = new Card(8, "heart");
            Card nineheart = new Card(9, "heart");
            Card tenheart = new Card(10, "heart");
            Card jackheart = new Card(11, "heart");
            Card queenheart = new Card(12, "heart");
            Card kingheart = new Card(13, "heart");
            Card asheart = new Card(14, "heart");


            Card twodiamond = new Card(2, "diamond");
            Card threediamond = new Card(3, "diamond");
            Card fourdiamond = new Card(4, "diamond");
            Card fivediamond = new Card(5, "diamond");
            Card sixdiamond = new Card(6, "diamond");
            Card sevendiamond = new Card(7, "diamond");
            Card eighthdiamond = new Card(8, "diamond");
            Card ninediamond = new Card(9, "diamond");
            Card tendiamond = new Card(10, "diamond");
            Card jackdiamond = new Card(11, "diamond");
            Card queendiamond = new Card(12, "diamond");
            Card kingdiamond = new Card(13, "diamond");
            Card asdiamond = new Card(14, "diamond");


            Card twoclub = new Card(2, "club");
            Card threeclub = new Card(3, "club");
            Card fourclub = new Card(4, "club");
            Card fiveclub = new Card(5, "club");
            Card sixclub = new Card(6, "club");
            Card sevenclub = new Card(7, "club");
            Card eighthclub = new Card(8, "club");
            Card nineclub = new Card(9, "club");
            Card tenclub = new Card(10, "club");
            Card jackclub = new Card(11, "club");
            Card queenclub = new Card(12, "club");
            Card kingclub = new Card(13, "club");
            Card asclub = new Card(14, "club");

            List<Card> deck = new List<Card> { twospade, threespade, fourspade, fivespade, sixspade, sevenspade, eightspade, ninespade, tenspade, jackspade, queenspade, kingspade, aspade, twoclub, threeclub, fourclub, fiveclub, sixclub, sevenclub, eighthclub, nineclub, tenclub, jackclub, queenclub, kingclub, asclub, twodiamond, threediamond, fourdiamond, fivediamond, sixdiamond, sevendiamond, eighthdiamond, ninediamond, tendiamond, jackdiamond, queendiamond, kingdiamond, asdiamond, twoheart, threeheart, fourheart, fiveheart, sixheart, sevenheart, eightheart, nineheart, tenheart, jackheart, queenheart, kingheart, asheart };

            return deck;
        }

        public void Shuffle() //Shuffle a deck randomly
        {
            
            Random generator = new Random();
            for (int i = 0; i < DeckofCards.Count; i++)
            {
                int num = generator.Next(0, 51);
                Card transition = DeckofCards[num];
                DeckofCards[num] = DeckofCards[i];
                DeckofCards[i] = transition;

            }
            
        }
         
        public void Distribute()//Distribute a card to each player
        {
            
            int nbcards = 0;
            while (nbcards <2)
            {

                for (int i = 0; i < Party.Count; i++)
                {
                    Random generator = new Random();
                    int chosen = generator.Next(0, DeckofCards.Count-1);
                    
                    Party[i].Hand[nbcards] = DeckofCards[chosen];
                    DeckofCards.RemoveAt(chosen);
                    
                   
                }
                nbcards++;
            }
        }
        public string ToString()
        {
            Console.WriteLine(DeckofCards.Count);
            string deck = "";
            for (int i = 0; i < DeckofCards.Count; i++)
            {
                deck+=($"{DeckofCards[i].value}     {DeckofCards[i].color}\n");

            }
            return deck;
        }
        public void Test()
        {
            DeckofCards.RemoveAt(0);
        }

        public List<Card> CreateRiver() //Creation of the river
        {
            List<Card> river = new List<Card>();
            Console.WriteLine(DeckofCards.Count);
            
            for (int i = 0; i < 3; i++)
            {
                Random generator = new Random();
                int chosen = generator.Next(0, DeckofCards.Count - 1);
               
               river.Add(DeckofCards[chosen]);
              
                DeckofCards.RemoveAt(chosen);
            }
           
            return river;
        }


    }
}
