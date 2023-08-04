
namespace h02
{
    public class Money
    {
        protected int money;
        protected int coins;
        public Money()
        {
            money = 52;
            coins = 75;
        }
        public Money(int value1, int value2)
        {
            this.money = value1;
            this.coins = value2;
        }
        // setting the values ​​of the parts
        public void EnterSum(int value1, int value2)
        {
            this.money = value1;
            this.coins = value2;
        }
        // displaying the amount on the screen
        public void DisplaySum() => Console.WriteLine($"Your amount of money is {money}.{coins}");
    }

    public class Product : Money
    {
        private string _name;
        public Product(int money, int coins, string name) : base(money, coins)
        {
            _name = name;
        }
        // reducing the price by a given number
        public void PriceReduction(int re_value1, int re_value2)
        {
            if ( re_value1 > 0 && money >= re_value1 && re_value2 > 0 && coins >= re_value2)
            {
                int re_all_in_coins = re_value1 * 100 + re_value2;
                coins = money * 100 + coins - re_all_in_coins;
                money = 0;
                while ( coins >= 100 )
                {
                    coins -= 100;
                    money++;
                }
                Console.WriteLine($"Your reduced price for the product is {money}.{coins}");
            } 
            else 
            {
                Console.WriteLine("Error. Too large a number to subtract.");
            }
        }
    }
}