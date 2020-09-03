using System;
using System.Collections.Generic;
using System.Text;
using Snap.Classes;

namespace Snap.Strategy
{
    public class FaceStrategy : BaseStrategy, ISnapStrategy
    {
        public override int StrategyId => (int) Strategy.Face;

        public override string Description => "the face value of the card";
        
        public override bool Snap(Card card1, Card card2)
        {
            if (card1.FaceValue == card2.FaceValue)
                return true;
            else
                return false;
        }
    }
}
