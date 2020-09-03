using System;
using System.Collections.Generic;
using System.Text;

namespace Snap.Classes
{
    public class Card : IEquatable<Card>
    {
        public Card(SuitEnum suit, FaceValueEnum faceValue)
        {
            Suit = suit;
            FaceValue = faceValue;
        }

        public SuitEnum Suit { get; }
        public FaceValueEnum FaceValue { get; }

        public bool Equals(Card other)
        {
            return other.FaceValue == this.FaceValue && other.Suit == other.Suit ? true : false;
        }
    }
}
