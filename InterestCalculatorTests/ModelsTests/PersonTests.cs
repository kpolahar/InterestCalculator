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
    }
}