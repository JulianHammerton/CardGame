using Snap.Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snap.Game
{
    public class Game
    {
        readonly ISnapStrategy _strategy;
        readonly Deck _deck;

        public Game(ISnapStrategy strategy, Deck deck)
        {
            _strategy = strategy;
            _deck = deck;
        }

        //public Execute()
        //{

        //}
    }

}
