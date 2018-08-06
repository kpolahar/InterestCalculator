using InterestCalculator.Data;
using System.Linq;
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

        public Card(string cardHolderName, string cardNumber, string expirationDate, string securityCode, decimal balance, string cardTypeName)
        {
            this.cardHolderName = cardHolderName;
            this.cardNumber = cardNumber;
            this.expirationDate = expirationDate;
            this.securityCode = securityCode;
            this.balance = balance;

            // Use InterestData method GetCardType to get the correct CardType to assign to this Card
            CardType cardTypeLookup = GetCardType(cardTypeName);

            // If a valid CardType is found for the provided cardTypeName, set the cardType for this Card
            if (cardTypeLookup != null)
                this.cardType = cardTypeLookup;
        }

        public decimal CalculateBalanceWithInterest()
        {
            decimal result = 0;
            decimal interestRate = 0;

            bool parsed = decimal.TryParse(this.cardType.InterestRate, out interestRate);
            if (parsed)
                result = this.balance + (this.balance * interestRate);

            return result;
        }
    }
}