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
        ///     - Default constructor creates a non-null InterestData
        ///       which is assigned a non-null dataSet property
        /// </summary>
        [Fact]
        public void testConstructor_Default_DataSetIsNotNull()
        {

            // Attempt to construct new InterestData
            InterestData interestData = new InterestData();

            // dataSet property should not be null
            Assert.NotNull(interestData.dataSet);
        }

        // Could possibly test to make sure dataSet is able to
        //   be reserialized back into xml, but this seems like
        //   overkill at the moment. May come back for this later.

        #endregion ConstructorTests
    }
}