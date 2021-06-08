﻿using System;

namespace PickRandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of cards to pick: ");
            string line = Console.ReadLine();

            // Converts to int successfully, picks cards and loops through each, displaying the values.
            if (int.TryParse(line, out int numberOfCards))
            {
                foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card);       
                }
            } 
            else 
            {
                Console.WriteLine("You have not entered a valid number.");
            }
        }
    }
}