using System.Collections.Generic;
using InterestCalculator.Data;
using InterestCalculator.Models;
using Xunit;

namespace InterestCalculatorTests.ModelsTests
{
    public class PersonTest
    {
        #region ConstructorTests

        /// <summary>
        ///   Test
        ///     - Constructor creates a non-null Person
        /// </summary>
        [Fact]
        public void testConstructor_PersonIsNotNull()
        {
            // Attempt to construct new InterestData
            InterestData interestData = new InterestData();

            // Construct a set of Wallets to assign to the Person
            List<Wallet> wallets = new List<Wallet>();

            // Construct a set of Cards to put in the Wallet
            List<Card> cards = new List<Card>();
            Card card = new Card("Test Test", "0000 1111 2222 3333", "0101", "000", 100, "Discover");
            cards.Add(card);

            // Attempt to construct new Wallet
            Wallet wallet = new Wallet(cards);
            wallets.Add(wallet);

            // Attempt to construct new Person
            Person person = new Person("Test", "Test", wallets);

            // Person object should not be null
            Assert.NotNull(person);
        }

        /// <summary>
        ///   Test
        ///     - Constructor creates a non-null Person which
        ///      is assigned a non-null wallets property
        /// </summary>
        [Fact]
        public void testConstructor_WalletsIsNotNull()
        {
            // Attempt to construct new InterestData
            InterestData interestData = new InterestData();

            // Construct a set of Wallets to assign to the Person
            List<Wallet> wallets = new List<Wallet>();

            // Construct a set of Cards to put in the Wallet
            List<Card> cards = new List<Card>();
            Card card = new Card("Test Test", "0000 1111 2222 3333", "0101", "000", 100, "Discover");
            cards.Add(card);

            // Attempt to construct new Wallet
            Wallet wallet = new Wallet(cards);
            wallets.Add(wallet);

            // Attempt to construct new Person
            Person person = new Person("Test", "Test", wallets);

            // Person object should not be null
            Assert.NotNull(person.wallets);
        }

        // Could possibly test to make sure all properties are
        //   mapped correctly to the object, but this seems like
        //   overkill at the moment. May come back for this later.

        #endregion ConstructorTests

        #region MethodTests

        /// <summary>
        ///   Test
        ///     - When provided with two Wallets which each contain
        ///       three different Cards of different CardTypes,
        ///       CalculateInterest correctly calculates the
        ///       correct expected interest for the sum of the interests
        ///       of all Cards in each Wallet belonging to the Person
        /// </summary>
        [Fact]
        public void testCalculateInterest_InterestCalculatedCorrectly()
        {
            // Attempt to construct new InterestData
            InterestData interestData = new InterestData();

            // Construct a set of Wallets to assign to the Person
            List<Wallet> wallets = new List<Wallet>();

            // Construct a set of Cards to put in the Wallet
            List<Card> cards1 = new List<Card>();
            Card card1 = new Card("Test Test", "0000 1111 2222 3333", "0101", "000", 125, "Discover");
            Card card2 = new Card("Test Test", "0000 1111 2222 3333", "0101", "000", 250, "MasterCard");
            Card card3 = new Card("Test Test", "0000 1111 2222 3333", "0101", "000", 300, "Visa");
            cards1.Add(card1);
            cards1.Add(card2);
            cards1.Add(card3);

            // Attempt to construct new Wallet
            Wallet wallet1 = new Wallet(cards1);
            wallets.Add(wallet1);

            // Construct a set of Cards to put in the Wallet
            List<Card> cards2 = new List<Card>();
            Card card4 = new Card("Test Test", "0000 1111 2222 3333", "0101", "000", 330, "Discover");
            Card card5 = new Card("Test Test", "0000 1111 2222 3333", "0101", "000", 450, "MasterCard");
            Card card6 = new Card("Test Test", "0000 1111 2222 3333", "0101", "000", 120, "Visa");
            cards2.Add(card4);
            cards2.Add(card5);
            cards2.Add(card6);

            // Attempt to construct new Wallet
            Wallet wallet2 = new Wallet(cards2);
            wallets.Add(wallet2);

            // Attempt to construct new Person
            Person person = new Person("Test", "Test", wallets);

            // Attempt to calculate the current interest of the Person
            decimal interest = person.CalculateInterest();
            decimal expectedInterest = (decimal)81.55;

            // interest should be equal to expectedInterest
            Assert.Equal(interest, expectedInterest);
        }

        /// <summary>
        ///   Test
        ///     - When provided with two Wallets which each contain
        ///       three different Cards of different CardTypes,
        ///       CalculateBalanceWithInterest correctly calculates the
        ///       correct expected balance for the sum of the balances
        ///       of all Cards in each Wallet belonging to the Person
        /// </summary>
        [Fact]
        public void testCalculateBalanceWithInterest_BalanceCalculatedCorrectly()
        {
            // Attempt to construct new InterestData
            InterestData interestData = new InterestData();

            // Construct a set of Wallets to assign to the Person
            List<Wallet> wallets = new List<Wallet>();

            // Construct a set of Cards to put in the Wallet
            List<Card> cards1 = new List<Card>();
            Card card1 = new Card("Test Test", "0000 1111 2222 3333", "0101", "000", 125, "Discover");
            Card card2 = new Card("Test Test", "0000 1111 2222 3333", "0101", "000", 250, "MasterCard");
            Card card3 = new Card("Test Test", "0000 1111 2222 3333", "0101", "000", 300, "Visa");
            cards1.Add(card1);
            cards1.Add(card2);
            cards1.Add(card3);

            // Attempt to construct new Wallet
            Wallet wallet1 = new Wallet(cards1);
            wallets.Add(wallet1);

            // Construct a set of Cards to put in the Wallet
            List<Card> cards2 = new List<Card>();
            Card card4 = new Card("Test Test", "0000 1111 2222 3333", "0101", "000", 330, "Discover");
            Card card5 = new Card("Test Test", "0000 1111 2222 3333", "0101", "000", 450, "MasterCard");
            Card card6 = new Card("Test Test", "0000 1111 2222 3333", "0101", "000", 120, "Visa");
            cards2.Add(card4);
            cards2.Add(card5);
            cards2.Add(card6);

            // Attempt to construct new Wallet
            Wallet wallet2 = new Wallet(cards2);
            wallets.Add(wallet2);

            // Attempt to construct new Person
            Person person = new Person("Test", "Test", wallets);

            // Attempt to calculate the current balance of the Person, with interest
            decimal balance = person.CalculateBalanceWithInterest();
            decimal expectedBalance = (decimal)1656.55;

            // balance should be equal to expectedBalance
            Assert.Equal(balance, expectedBalance);
        }

        #endregion MethodTests
    }
}