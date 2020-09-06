using Snap.Classes;
using Snap.Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snap.Game
{
    public class GameRunner
    {
        readonly ISnapStrategy _strategy;
        readonly Deck _deck;
        readonly Player _player1;
        readonly Player _player2;
        Player _currentPlayer;

        public GameRunner(ISnapStrategy strategy, Deck deck)
        {
            _strategy = strategy;
            _deck = deck;
            _player1 = new Player();
            _player2 = new Player();
            _currentPlayer = _player1;
        }

        public void Execute()
        {
            var previousCard = _deck.DealCard();
            var currentCard = _deck.DealCard();

            while (_deck.Cards.Count > 0)
            {
                if (_strategy.Snap(previousCard, currentCard))
                {
                    Console.WriteLine("SNAP!");
                    _currentPlayer.Score += 1;
                }
                NextPlayer();
                previousCard = currentCard;
                currentCard = _deck.DealCard();
            }
        }

        private void NextPlayer()
        {
            if (_currentPlayer == _player1)
                _currentPlayer = _player2;
            else
                _currentPlayer = _player1;
        }
    }
}
