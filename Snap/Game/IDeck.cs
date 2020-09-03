using Snap.Classes;
using System.Collections.Generic;

namespace Snap.Game
{
    public interface IDeck
    {
        void CreateDecks(int DeckAmount);
        void Shuffle();
        Card DealCard();
    }
}
