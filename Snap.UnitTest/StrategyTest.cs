using Snap.Classes;
using Snap.Strategy;
using Xunit;

namespace Snap.UnitTest
{
    public class StrategyTest
    {
        [Fact]
        public void CombinedStrategy_SuitAndFaceValueDifferent_NotASnap()
        {
            //Arrange
            var strategy = new CombinedStrategy();
            var card1 = new Card(SuitEnum.Heart, FaceValueEnum.Ace);
            var card2 = new Card(SuitEnum.Spade, FaceValueEnum._5);

            //Act
            var result = strategy.Snap(card1, card2);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void CombinedStrategy_SuitEqualFaceValueDifferent_NotASnap()
        {
            //Arrange
            var strategy = new CombinedStrategy();
            var card1 = new Card(SuitEnum.Heart, FaceValueEnum.Ace);
            var card2 = new Card(SuitEnum.Heart, FaceValueEnum._5);

            //Act
            var result = strategy.Snap(card1, card2);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void CombinedStrategy_FaceValueEqualSuitDifferent_NotASnap()
        {
            //Arrange
            var strategy = new CombinedStrategy();
            var card1 = new Card(SuitEnum.Heart, FaceValueEnum.Ace);
            var card2 = new Card(SuitEnum.Spade, FaceValueEnum.Ace);

            //Act
            var result = strategy.Snap(card1, card2);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void CombinedStrategy_AllEqual_NotASnap()
        {
            //Arrange
            var strategy = new CombinedStrategy();
            var card = new Card(SuitEnum.Heart, FaceValueEnum.Ace);

            //Act
            var result = strategy.Snap(card, card);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void FaceStrategy_SuitAndFaceValueDifferent_NotASnap()
        {
            //Arrange
            var strategy = new FaceStrategy();
            var card1 = new Card(SuitEnum.Heart, FaceValueEnum.Ace);
            var card2 = new Card(SuitEnum.Spade, FaceValueEnum._5);

            //Act
            var result = strategy.Snap(card1, card2);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void FaceStrategy_SuitEqualFaceValueDifferent_NotASnap()
        {
            //Arrange
            var strategy = new FaceStrategy();
            var card1 = new Card(SuitEnum.Heart, FaceValueEnum.Ace);
            var card2 = new Card(SuitEnum.Heart, FaceValueEnum._5);

            //Act
            var result = strategy.Snap(card1, card2);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void FaceStrategy_FaceValueEqualSuitDifferent_NotASnap()
        {
            //Arrange
            var strategy = new FaceStrategy();
            var card1 = new Card(SuitEnum.Heart, FaceValueEnum.Ace);
            var card2 = new Card(SuitEnum.Spade, FaceValueEnum.Ace);

            //Act
            var result = strategy.Snap(card1, card2);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void FaceStrategy_AllEqual_NotASnap()
        {
            //Arrange
            var strategy = new FaceStrategy();
            var card = new Card(SuitEnum.Heart, FaceValueEnum.Ace);

            //Act
            var result = strategy.Snap(card, card);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void SuitStrategy_SuitAndFaceValueDifferent_NotASnap()
        {
            //Arrange
            var strategy = new SuitStrategy();
            var card1 = new Card(SuitEnum.Heart, FaceValueEnum.Ace);
            var card2 = new Card(SuitEnum.Spade, FaceValueEnum._5);

            //Act
            var result = strategy.Snap(card1, card2);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void SuitStrategy_SuitEqualFaceValueDifferent_NotASnap()
        {
            //Arrange
            var strategy = new SuitStrategy();
            var card1 = new Card(SuitEnum.Heart, FaceValueEnum.Ace);
            var card2 = new Card(SuitEnum.Heart, FaceValueEnum._5);

            //Act
            var result = strategy.Snap(card1, card2);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void SuitStrategy_FaceValueEqualSuitDifferent_NotASnap()
        {
            //Arrange
            var strategy = new SuitStrategy();
            var card1 = new Card(SuitEnum.Heart, FaceValueEnum.Ace);
            var card2 = new Card(SuitEnum.Spade, FaceValueEnum.Ace);

            //Act
            var result = strategy.Snap(card1, card2);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void SuitStrategy_AllEqual_NotASnap()
        {
            //Arrange
            var strategy = new SuitStrategy();
            var card = new Card(SuitEnum.Heart, FaceValueEnum.Ace);

            //Act
            var result = strategy.Snap(card, card);

            //Assert
            Assert.True(result);
        }
    }
}
