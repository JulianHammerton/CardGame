using System;
using System.Collections.Generic;
using System.Text;
using Snap.Classes;

namespace Snap.Strategy
{
    public class CombinedStrategy : BaseStrategy, ISnapStrategy
    {
        public override int StrategyId => (int) Strategy.Combined;

        public override string Description => "both the suit and the face value of the card";

        public override bool Snap(Card card1, Card card2)
        {
            if (card1.FaceValue == card2.FaceValue && card1.Suit == card2.Suit)
                return true;
            else
                return false;
        }
    }
}
