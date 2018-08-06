using InterestCalculator.Data;
using Xunit;

namespace InterestCalculatorTests.DataTests
{
    public class InterestDataTest
    {
        #region ConstructorTests

        /// <summary>
        ///   Test
        ///     - Default constructor creates a non-null InterestData
        /// </summary>
        [Fact]
        public void testConstructor_Default_InterestDataIsNotNull()
        {
            // Attempt to construct new InterestData
            InterestData interestData = new InterestData();

            // InterestData object should not be null
            Assert.NotNull(interestData);
        }

        /// <summary>
        ///   Test
        ///     - Default constructor creates a non-null static
        ///       dataSet property on the InterestData class
        /// </summary>
        [Fact]
        public void testConstructor_Default_DataSetIsNotNull()
        {
            // Attempt to construct new InterestData
            InterestData interestData = new InterestData();

            // dataSet property should not be null
            Assert.NotNull(InterestData.dataSet);
        }

        // Could possibly test to make sure dataSet is able to
        //   be reserialized back into xml, but this seems like
        //   overkill at the moment. May come back for this later.

        #endregion ConstructorTests

        #region MethodTests
        /// <summary>
        ///   Test
        ///     - When provided with a valid cardTypeName parameter,
        ///       GetCardType method returns a non-null CardType
        /// </summary>
        [Fact]
        public void testGetCardType_ValidCardTypeName_CardTypeIsNotNull()
        {
            // Attempt to construct new InterestData
            InterestData interestData = new InterestData();

            // Attempt to get a CardType by a valid cardTypeName
            InterestData.CardType cardType = InterestData.GetCardType("Discover");

            // cardType should not be null
            Assert.NotNull(cardType);
        }
        #endregion MethodTest
    }
}