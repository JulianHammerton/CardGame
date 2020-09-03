using System;
using System.Collections.Generic;
using System.Text;
using Snap.Classes;

namespace Snap.Strategy
{
    public class SuitStrategy : BaseStrategy, ISnapStrategy
    {
        public override int StrategyId => (int)Strategy.Suit;

        public override string Description => "the suit";

        public override bool Snap(Card card1, Card card2)
        {
            if (card1.Suit == card2.Suit)
                return true;
            else
                return false;
        }
    }
}
