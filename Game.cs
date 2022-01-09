using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    class Game
    {
        public List<Card> River { get; set; } //List of cards composing the river
        
       
        public List<Player> Party { get; set; }//List of Players
        public Deck Deck {get;set;} 

        public Game()
        {
            

            this.Deck = new Deck();
            
            this.Party = CreateParty();
            

        }
        public List<Player> CreateParty() //Creating a new game
        {
            Console.WriteLine("How many players? (between 2 and 4)");
            int answer = Convert.ToInt32(Console.ReadLine());
            List<Player> Party = new List<Player>();
            switch(answer)
            {
                case 2:
                    Player one = new Player();
                    Player two = new Player();

                    Console.WriteLine($"Name of the Player one");
                    string nameone = Console.ReadLine();
                    one.Name = nameone;

                    Console.WriteLine($"Name of the Player two");
                    string nametwo = Console.ReadLine();
                    two.Name=nametwo;

                    Party.Add(one);
                    Party.Add(two);
                    break;

                case 3:
                    one = new Player();
                    two = new Player();
                    Player three = new Player();

                    Console.WriteLine($"Name of the Player one");
                    nameone = Console.ReadLine();
                    one.Name = nameone;

                    Console.WriteLine($"Name of the Player two");
                    nametwo = Console.ReadLine();
                    two.Name = nametwo;


                    Console.WriteLine($"Name of the Player three");
                    string namethree = Console.ReadLine();
                    three.Name = namethree;

                    Party.Add(one);
                    Party.Add(two);
                    Party.Add(three);
                    
                    break;

                case 4:
                     one = new Player();
                    two = new Player();
                    three = new Player();
                    Player four = new Player();

                    Console.WriteLine($"Name of the Player one");
                    nameone = Console.ReadLine();
                    one.Name = nameone;

                    Console.WriteLine($"Name of the Player two");
                    nametwo = Console.ReadLine();
                    two.Name = nametwo;


                    Console.WriteLine($"Name of the Player three");
                    namethree = Console.ReadLine();
                    three.Name = namethree;

                    Console.WriteLine($"Name of the Player four");
                    string namefour = Console.ReadLine();
                    four.Name = namefour;

                    Party.Add(one);
                    Party.Add(two);
                    Party.Add(three);
                    Party.Add(four);
                    break;

            }
            return Party;
          
        }

        public void Rankings()
        {
            for(int i=0;i<Party.Count;i++)

            {
                List<Card> fin = new List<Card>();
                for(int j =0;j<2;j++)
                {
                    fin.Add(Party[i].Hand[j]);

                    for(int h=0;h<River.Count;h++)
                    {
                        fin.Add(River[h]);
                    }
                }

                for(int l =0;l<fin.Count;l++)
                {
                    
                }
            }
        }
        public void LaunchGame()
        {
            Deck.Shuffle();
            Deck.Party = Party;
            Deck.Distribute();
            for(int i=0;i<Party.Count;i++)
            {
                Console.WriteLine(Party[i].ToString());
            }
            List<Card> river =Deck.CreateRiver();
            List<Card> complete = new List<Card>();
            for (int j = 0; j < Party.Count; j++)
            {
                for (int i = 0; i < river.Count; i++)
                {
                    complete.Add(river[i]);
                }
                for (int i = 0; i < 2; i++)
                {
                    complete.Add(Party[j].Hand[i]);
                }

                for(int i=0;i<complete.Count;i++)
                {
                    Console.WriteLine(complete[i].ToString());
                }
                complete.Clear();

                Console.WriteLine("");
            }
        }
       



    }
}
