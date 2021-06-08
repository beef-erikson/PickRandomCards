using System;
using System.Collections.Generic;
using System.Text;

namespace PickRandomCards
{
    class CardPicker
    {
        static Random random = new Random();

        /// <summary>
        /// Picks a number of cards based on the value provided
        /// </summary>
        /// <param name="numberOfCards">Number of cards to draw</param>
        /// <returns>String array of cards</returns>
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }

            return pickedCards;
        }

        /// <summary>
        /// Gets a random card suit
        /// </summary>
        /// <returns>String representing card suit ("Hearts", "Diamonds", etc)</returns>
        private static string RandomSuit()
        {
            // get random number between one and four 
            int value = random.Next(1, 5);

            // returns suit
            switch (value)
            {
                case 1:
                    return "Spades";
                case 2:
                    return "Hearts";
                case 3:
                    return "Clubs";
                case 4:
                    return "Diamonds";
                default:
                    return "Out of intended range";
            }
        }

        /// <summary>
        /// Gets a random card value
        /// </summary>
        /// <returns>String based on card value (2-10, Jack-Ace)</returns>
        private static string RandomValue()
        {
            // gets random number between 1 and 13
            int value = random.Next(1, 14);

            // returns appropriate card value
            switch (value)
            {
                case 1:
                    return "Ace";
                case 11:
                    return "Jack";
                case 12:
                    return "Queen";
                case 13:
                    return "King";
                default:
                    return value.ToString();
            }
        }
    }
}
