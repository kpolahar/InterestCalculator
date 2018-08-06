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

        public decimal CalculateBalanceWithInterest()
        {
            decimal result = 0;

            foreach (Card card in this.cards)
                result += card.CalculateBalanceWithInterest();

            return result;
        }
    }
}