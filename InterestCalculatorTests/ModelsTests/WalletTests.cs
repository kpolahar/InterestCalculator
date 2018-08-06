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

        #region MethodTests

        /// <summary>
        ///   Test
        ///     - When provided with two Cards of different CardTypes,
        ///       CalculateInterest correctly calculates the correct
        ///       expected interest for the sum of the interests
        ///       of all Cards in the Wallet
        /// </summary>
        [Fact]
        public void testCalculateInterest_InterestCalculatedCorrectly()
        {
            // Attempt to construct new InterestData
            InterestData interestData = new InterestData();

            // Construct a set of Cards to put in the Wallet
            List<Card> cards = new List<Card>();
            Card card1 = new Card("Test Test", "0000 1111 2222 3333", "0101", "000", 300, "Visa");
            Card card2 = new Card("Test Test", "0000 1111 2222 3333", "0101", "000", 250, "MasterCard");
            cards.Add(card1);
            cards.Add(card2);

            // Attempt to construct new Wallet
            Wallet wallet = new Wallet(cards);

            // Attempt to calculate the current interest of the Wallet
            decimal interest = wallet.CalculateInterest();
            decimal expectedInterest = (decimal)42.5;

            // interest should be equal to expectedInterest
            Assert.Equal(interest, expectedInterest);
        }

        /// <summary>
        ///   Test
        ///     - When provided with two Cards of different CardTypes,
        ///       CalculateBalanceWithInterest correctly calculates the
        ///       correct expected balance for the sum of the balances
        ///       of all Cards in the Wallet
        /// </summary>
        [Fact]
        public void testCalculateBalanceWithInterest_BalanceCalculatedCorrectly()
        {
            // Attempt to construct new InterestData
            InterestData interestData = new InterestData();

            // Construct a set of Cards to put in the Wallet
            List<Card> cards = new List<Card>();
            Card card1 = new Card("Test Test", "0000 1111 2222 3333", "0101", "000", 300, "Visa");
            Card card2 = new Card("Test Test", "0000 1111 2222 3333", "0101", "000", 250, "MasterCard");
            cards.Add(card1);
            cards.Add(card2);

            // Attempt to construct new Wallet
            Wallet wallet = new Wallet(cards);

            // Attempt to calculate the current balance of the Wallet, with interest
            decimal balance = wallet.CalculateBalanceWithInterest();
            decimal expectedBalance = (decimal)592.5;

            // balance should be equal to expectedBalance
            Assert.Equal(balance, expectedBalance);
        }

        #endregion MethodTests
    }
}