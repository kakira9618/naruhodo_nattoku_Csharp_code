using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p11_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var king = new Card(CardSuit.Spade, 13);
            Console.WriteLine($"Suit:{king.Suit}, Number:{king.Number}");
            ChangeToAce(king);

            Console.WriteLine($"Suit:{king.Suit}, Number:{king.Number}");
        }

        private static void ChangeToAce(Card card)
        {
            card.Number = 1;
            // card = new Card(CardSuit.Club, 1);
        }
    }
    enum CardSuit
    {
        Club, Spade, Heart, Diamond
    }

    
    struct Card
    // struct Card
    {
        public CardSuit Suit { get; set; }
        public int Number { get; set; }
        public Card(CardSuit suit, int number)
        {
            Suit = suit;
            Number = number;
        }
    }
}
