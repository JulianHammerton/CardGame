using Snap.Classes;
using Snap.Game;
using System;
using System.Collections.Generic;
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

        [Fact]
        public void DealCard_OneDecks_FiftyTwoCardsDrainsTheDeck()
        {
            //Arrange
            var deck = new Deck();
            deck.CreateDecks(1);

            //Act
            var recievedCards = new List<Card>();
            for(int x = 1; x <= 52; x++)
            {
                recievedCards.Add(deck.DealCard());
            }

            //Assert
            Assert.Equal(52, recievedCards.Count);
            Assert.Empty(deck.Cards);
        }

        [Fact]
        public void CreateDeck_OneDeckTwice_DecksAreEqual()
        {
            //Arrange
            var deck1 = new Deck();
            var deck2 = new Deck();

            //Act
            deck1.CreateDecks(1);
            deck2.CreateDecks(1);

            //Assert
            Assert.Equal(deck1.Cards, deck2.Cards);
        }

        [Fact]
        public void Shuffle_OneDeck_CardsAreInADifferentOrder()
        {
            //Arrange
            var unshuffledDeck = new Deck();
            unshuffledDeck.CreateDecks(1);
            var shuffledDeck = new Deck();
            shuffledDeck.CreateDecks(1);

            //Act
            shuffledDeck.Shuffle();  //Note: there is a chance that shuffle will return the pack in the same order, but that is 1 / 52 Factorial

            //Assert
            Assert.NotEqual(unshuffledDeck.Cards, shuffledDeck.Cards);
        }
    }
}
