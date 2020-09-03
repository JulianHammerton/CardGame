using Snap.Classes;
using Snap.Game;
using System;
using Xunit;

namespace Snap.UnitTest
{
    public class DeckTest
    {
        [Fact]
        public void CreateDecks_ZeroDecksUsed_ZeroCardTotal()
        {
            //Arrange
            var deck = new Deck();

            //Act
            deck.CreateDecks(0);

            //Assert
            Assert.Empty(deck.Cards);
        }

        [Fact]
        public void CreateDecks_OneDecksUsed_FiftyTwoCardTotal()
        {
            //Arrange
            var deck = new Deck();

            //Act
            deck.CreateDecks(1);

            //Assert
            Assert.Equal(52, deck.Cards.Count);
        }

        [Fact]
        public void CreateDecks_TwoDecksUsed_OneHundredAndFourCardTotal()
        {
            //Arrange
            var deck = new Deck();

            //Act
            deck.CreateDecks(2);

            //Assert
            Assert.Equal(104, deck.Cards.Count);
        }

        [Fact]
        public void DealCard_UnshuffledSingleDeck_TopCardReturned()
        {
            //Arrange
            var deck = new Deck();
            deck.CreateDecks(1);

            //Act
            var card = deck.DealCard();


            //Assert
            Assert.Equal(new Card(SuitEnum.Heart, FaceValueEnum.Ace), card);
        }
    }
}
