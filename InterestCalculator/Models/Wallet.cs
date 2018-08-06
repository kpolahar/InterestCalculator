using System.Collections.Generic;

namespace InterestCalculator.Models
{
    public class Wallet
    {
        public List<Card> cards { get; set; }

        public Wallet(List<Card> cards)
        {
            this.cards = cards;
        }

        public decimal calculateBalanceWithInterest()
        {
            decimal result = 0;
            return result;
        }
    }
}