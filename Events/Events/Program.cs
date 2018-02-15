using System;

namespace Events
{
    //////////////////2 when the goal has been met  WIRE IN EVENT HANDLER FOR GOAL BEING MET /////////////////////////////////////////////////////////////

    public delegate void AccountValueDel(object sender, AccountChangeArgs a);

    public class Bank
    {
        private decimal _bal;
        public event EventHandler<AccountChangeArgs> BalanceChanged;
        public event EventHandler<AccountChangeArgs> GoalMet;

        public decimal Goal { get; set; } = 500;
        public decimal Balance {
            get
            {
                return _bal;
            }
            set
            {
                _bal += value;
                this.BalanceChanged(this, new AccountChangeArgs() { amount = Balance});
            }
        }

    }

    public class AccountChangeArgs: EventArgs
    {
        public decimal amount;
    }


    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Bank piggy = new Bank();
            piggy.BalanceChanged += listener;

            do
            {
                Console.WriteLine("How much to deposit?");
                input = Console.ReadLine();
                if(!input.Equals("exit"))
                    piggy.Balance = Convert.ToDecimal(input);

            } while (!input.Equals("exit"));
            
            Console.WriteLine("Goodbye!");
        }

        static void listener(object sender, AccountChangeArgs a)
        {
            Console.WriteLine("The balance amount is {0}", a.amount);
        } 

        
    }
}
