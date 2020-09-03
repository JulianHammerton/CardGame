using System;
using System.Collections.Generic;
using System.Linq;
using ListExtension;
using Snap.Classes;

namespace Snap.Game
{
    public class Deck: IDeck
    {
        public List<Card> Cards { get; set; }

        public void CreateDecks(int DeckAmount)
        {
            var combinedDecks = new List<Card>();
            foreach(SuitEnum suit in SuitEnum.GetValues(typeof(SuitEnum)))
            {
                foreach(FaceValueEnum faceValue in FaceValueEnum.GetValues(typeof(FaceValueEnum)))
                {
                    combinedDecks.AddRange(Enumerable.Repeat(new Card(suit, faceValue), DeckAmount));
                }
            }
            Cards = combinedDecks;
        }

        public Card DealCard()
        {
            return Cards.Pop();
        }

        public void Shuffle()
        {
            var shuffledCards = new List<Card>();

            while(Cards.Count  != 0)
            {
                shuffledCards.Add(Cards.RemoveRandom());
            }

            Cards = shuffledCards;
        }
    }
}
