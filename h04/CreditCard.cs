
namespace h04
{
    public class CreditCard
    {
        string? cardNumber;
        int cvcCode;
        double balance;
        public string? CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }
        public int CvcCode
        {
            get { return cvcCode; }
            set { cvcCode = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value < 0 ? 0 : value; }
        }
        public CreditCard(string cardNumber, int cvcCode, double balance)
        {
            CardNumber = cardNumber;
            CvcCode = cvcCode;
            Balance = balance;
        }
        // + || -
        public static CreditCard operator +(CreditCard card, double amount)
        {
            card.Balance += amount;
            return card;
        }
        public static CreditCard operator -(CreditCard card, double amount)
        {
            card.Balance -= amount;
            return card;
        }
        // == || != 
        public static bool operator ==(CreditCard card1, CreditCard card2)
        {
            if ( ReferenceEquals(card1, card2) ) return true;
            if ( ReferenceEquals(card1, null) || ReferenceEquals(card2, null) ) return false;
            return card1.CvcCode == card2.CvcCode;
        }
        public static bool operator !=(CreditCard card1, CreditCard card2)
        {
            return !( card1 == card2 );
        }
        // > || < 
        public static bool operator <(CreditCard card1, CreditCard card2)
        {
            return card1.Balance < card2.Balance;
        }
        public static bool operator >(CreditCard card1, CreditCard card2)
        {
            return card1.Balance > card2.Balance;
        }

        // Equals
        public override bool Equals(object? obj)
        {
            if ( !(obj is CreditCard) ) return false;
            return this == (CreditCard)obj;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + CardNumber?.GetHashCode() ?? 0;
                hash = hash * 23 + CvcCode.GetHashCode();
                hash = hash * 23 + Balance.GetHashCode();
                return hash;
            }
        }
    }
}