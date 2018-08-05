using static InterestCalculator.Data.InterestData;

namespace InterestCalculator.Models
{
    public class Card
    {
        public string cardHolderName { get; set; }
        public string cardNumber { get; set; }
        public string expirationDate { get; set; }
        public string securityCode { get; set; }
        public decimal balance { get; set; }
        public CardType cardType { get; set; }

        public Card(string cardHolderName, string cardNumber, string expirationDate, string securityCode, decimal balance, CardType cardType)
        {
            
        }

        public decimal calculateBalanceWithInterest()
        {
            decimal result = 0;
            return result;
        }
    }
}