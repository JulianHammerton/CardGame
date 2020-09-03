using System;
using System.Collections.Generic;
using System.Text;
using Snap.Classes;

namespace Snap.Strategy
{
    public abstract class BaseStrategy : ISnapStrategy
    {
        public abstract int StrategyId { get; }
        public abstract string Description { get; }

        public string OutputForSelection()
        {
            return StrategyId + "  -  " + Description;
        }

        public abstract bool Snap(Card card1, Card card2);
    }
}
