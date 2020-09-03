using Snap.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snap.Strategy
{
    public interface ISnapStrategy
    {
        string OutputForSelection();
        bool Snap(Card card1, Card card2);

        int StrategyId
        {
            get;
        }
    }
}
