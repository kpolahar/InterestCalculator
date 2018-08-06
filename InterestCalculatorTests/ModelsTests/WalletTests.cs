using System.Collections.Generic;
using InterestCalculator.Data;
using InterestCalculator.Models;
using Xunit;

namespace InterestCalculatorTests.ModelsTests
{
    public class WalletTest
    {
        #region ConstructorTests

        /// <summary>
        ///   Test
        ///     - Constructor creates a non-null Wallet
        /// </summary>
        [Fact]
        public void testConstructor_WalletIsNotNull()
        {
            // Attempt to construct new InterestData
            InterestData interestData = new InterestData();

            // Construct a set of Cards to put in the Wallet
            List<Card> cards = new List<Card>();
            Card card = new Card("Test Test", "0000 1111 2222 3333", "0101", "000", 100, "Discover");
            cards.Add(card);

            // Attempt to construct new Wallet
            Wallet wallet = new Wallet(cards);

            // Wallet object should not be null
            Assert.NotNull(wallet);
        }

        /// <summary>
        ///   Test
        ///     - Constructor creates a non-null Wallet which
        ///      is assigned a non-null cards property
        /// </summary>
        [Fact]
        public void testConstructor_CardsIsNotNull()
        {
            // Attempt to construct new InterestData
            InterestData interestData = new InterestData();

            // Construct a set of Cards to put in the Wallet
            List<Card> cards = new List<Card>();
            Card card = new Card("Test Test", "0000 1111 2222 3333", "0101", "000", 100, "Discover");
            cards.Add(card);

            // Attempt to construct new Wallet
            Wallet wallet = new Wallet(cards);

            // cards property should not be null
            Assert.NotNull(wallet.cards);
        }

        #endregion ConstructorTests
    }
}