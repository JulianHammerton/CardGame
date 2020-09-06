using Snap.Game;
using Snap.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Snap
{
    class Program
    {
        static void Main(string[] args)
        {
            IntroText();
            var DecksToUse = DeckInput();
            var StrategyToUse = StrategySelection();

            var deck = new Deck();
            deck.CreateDecks(DecksToUse);
            deck.Shuffle();

            var game = new GameRunner(StrategyToUse, deck);
            game.Execute();
        }

        private static void IntroText()
        {
            Console.WriteLine("Snap Game!");
        }

        private static int DeckInput()
        {
            Console.WriteLine("How  many decks of cards would you like to use?");
            string userInput = Console.ReadLine();
            while (true == true)
            {
                if (int.TryParse(userInput, out int dummy))
                {
                    break;
                }
                else
                { 
                    Console.WriteLine("Number not recognised.  Please enter a valid number");
                    userInput = Console.ReadLine();
                }
            }
            return Convert.ToInt32(userInput);
        }


        private static ISnapStrategy StrategySelection()
        {
            Console.WriteLine("Please select one of the following strategies");
            var StrategyList = new List<ISnapStrategy>()
            {
                new FaceStrategy(),
                new SuitStrategy(),
                new CombinedStrategy()
            };

            foreach (var strategy in StrategyList)
            {
                Console.WriteLine(strategy.OutputForSelection());
            }

            string userInput = Console.ReadLine();
            while (true == true)
            {
                if (int.TryParse(userInput, out int stratedgyId))
                {
                    if (StrategyList.Any(x =>  x.StrategyId == stratedgyId))
                        break;
                    else 
                        Console.WriteLine("Strategynot recongnised. ");
                }
            }

            return StrategyList.Single(x => x.StrategyId == Convert.ToInt32(userInput));
        }

    }
}
