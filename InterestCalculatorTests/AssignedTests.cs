using System.Collections.Generic;
using InterestCalculator.Data;
using InterestCalculator.Models;
using Xunit;

namespace InterestCalculatorTests
{
    public class TestCase1
    {
        public Person person;
        public Wallet wallet;
        public Card card1;
        public Card card2;
        public Card card3;

        /// <summary>
        ///   Scenario
        ///     - Person has a Wallet with three Cards
        ///       - A Discover with a balance of $100
        ///       - A MasterCard with a balance of $100
        ///       - A Visa with a balance of $100
        /// </summary>
        public TestCase1()
        {
            // Attempt to construct new InterestData
            InterestData interestData = new InterestData();

            // Construct a set of Wallets to assign to the Person
            List<Wallet> wallets = new List<Wallet>();

            // Construct a set of Cards to put in the Wallet
            List<Card> cards = new List<Card>();
            card1 = new Card("Test Test", "0000 1111 2222 3333", "0101", "000", 100, "Discover");
            card2 = new Card("Test Test", "0000 1111 2222 3333", "0101", "000", 100, "MasterCard");
            card3 = new Card("Test Test", "0000 1111 2222 3333", "0101", "000", 100, "Visa");
            cards.Add(card1);
            cards.Add(card2);
            cards.Add(card3);

            // Attempt to construct new Wallet
            wallet = new Wallet(cards);
            wallets.Add(wallet);

            // Attempt to construct new Person
            person = new Person("Test", "Test", wallets);
        }

        /// <summary>
        ///   Test
        ///     - When provided with the above scenario,
        ///       Person.CalculateInterest correctly calculates
        ///       the correct expected interest for the sum of
        ///       the interests of all three Cards in the 
        ///       Person's Wallet
        /// </summary>
        [Fact]
        public void testCase1_TotalInterestForPersonCalculatedCorrectly()
        {
            // Attempt to calculate the total interest of the Person
            decimal interest = person.CalculateInterest();
            decimal expectedInterest = (decimal)16;

            // interest should be equal to expectedInterest
            Assert.Equal(interest, expectedInterest);
        }

        /// <summary>
        ///   Test
        ///     - When provided with the above scenario,
        ///       Card.CalculateInterest correctly calculates the 
        ///       correct expected interest for card1 (the Discover)
        /// </summary>
        [Fact]
        public void testCase1_InterestForCard1CalculatedCorrectly()
        {
            // Attempt to calculate the total interest of the Card
            decimal interest = card1.CalculateInterest();
            decimal expectedInterest = (decimal)1;

            // interest should be equal to expectedInterest
            Assert.Equal(interest, expectedInterest);
        }

        /// <summary>
        ///   Test
        ///     - When provided with the above scenario,
        ///       Card.CalculateInterest correctly calculates the 
        ///       correct expected interest for card2 (the MasterCard)
        /// </summary>
        [Fact]
        public void testCase1_InterestForCard2CalculatedCorrectly()
        {
            // Attempt to calculate the total interest of the Card
            decimal interest = card2.CalculateInterest();
            decimal expectedInterest = (decimal)5;

            // interest should be equal to expectedInterest
            Assert.Equal(interest, expectedInterest);
        }

        /// <summary>
        ///   Test
        ///     - When provided with the above scenario,
        ///       Card.CalculateInterest correctly calculates the 
        ///       correct expected interest for card3 (the Visa)
        /// </summary>
        [Fact]
        public void testCase1_InterestForCard3CalculatedCorrectly()
        {
            // Attempt to calculate the total interest of the Card
            decimal interest = card3.CalculateInterest();
            decimal expectedInterest = (decimal)10;

            // interest should be equal to expectedInterest
            Assert.Equal(interest, expectedInterest);
        }
    }

    public class TestCase2
    {
        public Person person;
        public Wallet wallet1;
        public Wallet wallet2;
        public Card card1;
        public Card card2;
        public Card card3;

        /// <summary>
        ///   Scenario
        ///     - Person has a two Wallets
        ///       - Wallet 1 has two Cards
        ///         - A Discover with a balance of $100
        ///         - A Visa with a balance of $100
        ///       - Wallet 2 has one Card
        ///         - A MasterCard with a balance of $100
        /// </summary>
        public TestCase2()
        {
            // Attempt to construct new InterestData
            InterestData interestData = new InterestData();

            // Construct a set of Wallets to assign to the Person
            List<Wallet> wallets = new List<Wallet>();

            // Construct a set of Cards to put in the Wallet
            List<Card> cards1 = new List<Card>();
            card1 = new Card("Test Test", "0000 1111 2222 3333", "0101", "000", 100, "Discover");
            card2 = new Card("Test Test", "0000 1111 2222 3333", "0101", "000", 100, "Visa");
            cards1.Add(card1);
            cards1.Add(card2);

            // Attempt to construct new Wallet
            wallet1 = new Wallet(cards1);
            wallets.Add(wallet1);

            // Construct a set of Cards to put in the Wallet
            List<Card> cards2 = new List<Card>();
            card3 = new Card("Test Test", "0000 1111 2222 3333", "0101", "000", 100, "MasterCard");
            cards2.Add(card3);

            // Attempt to construct new Wallet
            wallet2 = new Wallet(cards2);
            wallets.Add(wallet2);

            // Attempt to construct new Person
            person = new Person("Test", "Test", wallets);
        }

        /// <summary>
        ///   Test
        ///     - When provided with the above scenario,
        ///       Person.CalculateInterest correctly calculates
        ///       the correct expected interest for the sum of
        ///       the interests of all Cards in the both of
        ///       the Person's Wallets
        /// </summary>
        [Fact]
        public void testCase2_TotalInterestForPersonCalculatedCorrectly()
        {
            // Attempt to calculate the total interest of the Person
            decimal interest = person.CalculateInterest();
            decimal expectedInterest = (decimal)16;

            // interest should be equal to expectedInterest
            Assert.Equal(interest, expectedInterest);
        }

        /// <summary>
        ///   Test
        ///     - When provided with the above scenario,
        ///       Wallet.CalculateInterest correctly calculates
        ///       the correct expected interest for the sum of
        ///       the interests of all Cards in wallet1
        /// </summary>
        [Fact]
        public void testCase2_TotalInterestForWallet1CalculatedCorrectly()
        {
            // Attempt to calculate the total interest of the Wallet
            decimal interest = wallet1.CalculateInterest();
            decimal expectedInterest = (decimal)11;

            // interest should be equal to expectedInterest
            Assert.Equal(interest, expectedInterest);
        }

        /// <summary>
        ///   Test
        ///     - When provided with the above scenario,
        ///       Wallet.CalculateInterest correctly calculates
        ///       the correct expected interest for the sum of
        ///       the interests of all Cards in wallet2
        /// </summary>
        [Fact]
        public void testCase2_TotalInterestForWallet2CalculatedCorrectly()
        {
            // Attempt to calculate the total interest of the Wallet
            decimal interest = wallet2.CalculateInterest();
            decimal expectedInterest = (decimal)5;

            // interest should be equal to expectedInterest
            Assert.Equal(interest, expectedInterest);
        }
    }

    public class TestCase3
    {
        public Person person1;
        public Person person2;
        public Wallet wallet1;
        public Wallet wallet2;
        public Card card1;
        public Card card2;
        public Card card3;
        public Card card4;
        public Card card5;

        /// <summary>
        ///   Scenario
        ///     - Person 1 has a Wallet with three Cards
        ///       - A Discover with a balance of $100
        ///       - A MasterCard with a balance of $100
        ///       - A Visa with a balance of $100
        ///     - Person 2 has a Wallet with two Cards
        ///       - A MasterCard with a balance of $100
        ///       - A Visa with a balance of $100
        /// </summary>
        public TestCase3()
        {
            // Attempt to construct new InterestData
            InterestData interestData = new InterestData();

            // Construct a set of Wallets to assign to the Person
            List<Wallet> wallets1 = new List<Wallet>();

            // Construct a set of Cards to put in the Wallet
            List<Card> cards1 = new List<Card>();
            card1 = new Card("Test Test", "0000 1111 2222 3333", "0101", "000", 100, "Discover");
            card2 = new Card("Test Test", "0000 1111 2222 3333", "0101", "000", 100, "MasterCard");
            card3 = new Card("Test Test", "0000 1111 2222 3333", "0101", "000", 100, "Visa");
            cards1.Add(card1);
            cards1.Add(card2);
            cards1.Add(card3);

            // Attempt to construct new Wallet
            wallet1 = new Wallet(cards1);
            wallets1.Add(wallet1);

            // Attempt to construct new Person
            person1 = new Person("Test", "Test", wallets1);

            // Construct a set of Wallets to assign to the Person
            List<Wallet> wallets2 = new List<Wallet>();

            // Construct a set of Cards to put in the Wallet
            List<Card> cards2 = new List<Card>();
            card4 = new Card("Test Test", "0000 1111 2222 3333", "0101", "000", 100, "MasterCard");
            card5 = new Card("Test Test", "0000 1111 2222 3333", "0101", "000", 100, "Visa");
            cards2.Add(card4);
            cards2.Add(card5);

            // Attempt to construct new Wallet
            wallet2 = new Wallet(cards2);
            wallets2.Add(wallet2);

            // Attempt to construct new Person
            person2 = new Person("Test", "Test", wallets2);
        }

        /// <summary>
        ///   Test
        ///     - When provided with the above scenario,
        ///       Person.CalculateInterest correctly calculates
        ///       the correct expected interest for the sum of the
        ///       interests of all Cards in each person1's Wallet
        /// </summary>
        [Fact]
        public void testCase2_TotalInterestForPerson1CalculatedCorrectly()
        {
            // Attempt to calculate the current interest of the Person
            decimal interest = person1.CalculateInterest();
            decimal expectedInterest = (decimal)16;

            // interest should be equal to expectedInterest
            Assert.Equal(interest, expectedInterest);
        }

        /// <summary>
        ///   Test
        ///     - When provided with the above scenario,
        ///       Wallet.CalculateInterest correctly calculates
        ///       the correct expected interest for the sum of the
        ///       interests of all Cards in each person1's Wallet
        /// </summary>
        [Fact]
        public void testCase2_TotalInterestForWallet1CalculatedCorrectly()
        {
            // Attempt to calculate the current interest of the Wallet
            decimal interest = wallet1.CalculateInterest();
            decimal expectedInterest = (decimal)16;

            // interest should be equal to expectedInterest
            Assert.Equal(interest, expectedInterest);
        }

        /// <summary>
        ///   Test
        ///     - When provided with the above scenario,
        ///       Person.CalculateInterest correctly calculates
        ///       the correct expected interest for the sum of the
        ///       interests of all Cards in each person2's Wallet
        /// </summary>
        [Fact]
        public void testCase2_TotalInterestForPerson2CalculatedCorrectly()
        {
            // Attempt to calculate the current interest of the Person
            decimal interest = person2.CalculateInterest();
            decimal expectedInterest = (decimal)15;

            // interest should be equal to expectedInterest
            Assert.Equal(interest, expectedInterest);
        }

        /// <summary>
        ///   Test
        ///     - When provided with the above scenario,
        ///       Wallet.CalculateInterest correctly calculates
        ///       the correct expected interest for the sum of the
        ///       interests of all Cards in each person2's Wallet
        /// </summary>
        [Fact]
        public void testCase2_TotalInterestForWallet2CalculatedCorrectly()
        {
            // Attempt to calculate the current interest of the Wallet
            decimal interest = wallet2.CalculateInterest();
            decimal expectedInterest = (decimal)15;

            // interest should be equal to expectedInterest
            Assert.Equal(interest, expectedInterest);
        }
    }
}