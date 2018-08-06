using InterestCalculator.Data;
using InterestCalculator.Models;
using Xunit;

namespace InterestCalculatorTests.ModelsTests
{
    public class CardTest
    {
        #region ConstructorTests

        /// <summary>
        ///   Test
        ///     - Constructor creates a non-null Card
        /// </summary>
        [Fact]
        public void testConstructor_CardIsNotNull()
        {
            // Attempt to construct new InterestData
            InterestData interestData = new InterestData();

            // Attempt to construct new Card
            Card card = new Card("Test Test", "0000 1111 2222 3333", "0101", "000", 100, "Discover");

            // Card object should not be null
            Assert.NotNull(card);
        }

        /// <summary>
        ///   Test
        ///     - Constructor creates a non-null Card which
        ///      is assigned a non-null cardType property
        /// </summary>
        [Fact]
        public void testConstructor_CardTypeIsNotNull()
        {
            // Attempt to construct new InterestData
            InterestData interestData = new InterestData();

            // Attempt to construct new Card
            Card card = new Card("Test Test", "0000 1111 2222 3333", "0101", "000", 100, "Discover");

            // cardType property should not be null
            Assert.NotNull(card.cardType);
        }

        // Could possibly test to make sure all properties are
        //   mapped correctly to the object, but this seems like
        //   overkill at the moment. May come back for this later.

        #endregion ConstructorTests
    }
}