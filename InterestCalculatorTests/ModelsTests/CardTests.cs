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

        #region MethodTests
        /// <summary>
        ///   Test
        ///     - When provided with "Discover" cardTypeName parameter,
        ///       CalculateBalanceWithInterest method calculates the
        ///       correct expected interest for the card with one month's
        ///       interest at the rate specified for a "Discover" card
        ///       by the dataSet of CardTypes provided from InterestData 
        /// </summary>
        [Fact]
        public void testCalculateInterest_Discover_InterestCalculatedCorrectly()
        {
            // Attempt to construct new InterestData
            InterestData interestData = new InterestData();

            // Attempt to construct new Card
            Card card = new Card("Test Test", "0000 1111 2222 3333", "0101", "000", 100, "Discover");

            // Attempt to calculate the interest of the Card
            decimal interest = card.CalculateInterest();
            decimal expectedInterest = 1;

            // interest should be equal to expectedInterest
            Assert.Equal(interest, expectedInterest);
        }

        /// <summary>
        ///   Test
        ///     - When provided with "Discover" cardTypeName parameter,
        ///       CalculateBalanceWithInterest method calculates the
        ///       correct expected balance for the card with one month's
        ///       interest at the rate specified for a "Discover" card
        ///       by the dataSet of CardTypes provided from InterestData 
        /// </summary>
        [Fact]
        public void testCalculateBalanceWithInterest_Discover_BalanceCalculatedCorrectly()
        {
            // Attempt to construct new InterestData
            InterestData interestData = new InterestData();

            // Attempt to construct new Card
            Card card = new Card("Test Test", "0000 1111 2222 3333", "0101", "000", 100, "Discover");

            // Attempt to calculate the current balance of the Card, with interest
            decimal balance = card.CalculateBalanceWithInterest();
            decimal expectedBalance = 101;

            // balance should be equal to expectedBalance
            Assert.Equal(balance, expectedBalance);
        }

        /// <summary>
        ///   Test
        ///     - When provided with "MasterCard" cardTypeName parameter,
        ///       CalculateBalanceWithInterest method calculates the
        ///       correct expected balance for the card with one month's
        ///       interest at the rate specified for a "MasterCard" card
        ///       by the dataSet of CardTypes provided from InterestData 
        /// </summary>
        [Fact]
        public void testCalculateBalanceWithInterest_MasterCard_BalanceCalculatedCorrectly()
        {
            // Attempt to construct new InterestData
            InterestData interestData = new InterestData();

            // Attempt to construct new Card
            Card card = new Card("Test Test", "0000 1111 2222 3333", "0101", "000", 200, "MasterCard");

            // Attempt to calculate the current balance of the Card, with interest
            decimal balance = card.CalculateBalanceWithInterest();
            decimal expectedBalance = 210;

            // balance should be equal to expectedBalance
            Assert.Equal(balance, expectedBalance);
        }

        /// <summary>
        ///   Test
        ///     - When provided with "Visa" cardTypeName parameter,
        ///       CalculateBalanceWithInterest method calculates the
        ///       correct expected balance for the card with one month's
        ///       interest at the rate specified for a "Visa" card
        ///       by the dataSet of CardTypes provided from InterestData 
        /// </summary>
        [Fact]
        public void testCalculateBalanceWithInterest_Visa_BalanceCalculatedCorrectly()
        {
            // Attempt to construct new InterestData
            InterestData interestData = new InterestData();

            // Attempt to construct new Card
            Card card = new Card("Test Test", "0000 1111 2222 3333", "0101", "000", 300, "Visa");

            // Attempt to calculate the current balance of the Card, with interest
            decimal balance = card.CalculateBalanceWithInterest();
            decimal expectedBalance = 330;

            // balance should be equal to expectedBalance
            Assert.Equal(balance, expectedBalance);
        }
        #endregion MethodTests
    }
}