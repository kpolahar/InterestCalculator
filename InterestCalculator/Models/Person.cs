using System.Collections.Generic;

namespace InterestCalculator.Models
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public List<Wallet> wallets { get; set; }

        public Person(string firstName, string lastName, List<Wallet> wallets)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.wallets = wallets;
        }

        public decimal calculateBalanceWithInterest()
        {
            decimal result = 0;
            return result;
        }
    }
}