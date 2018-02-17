using System;

namespace Events
{
    public delegate void AccountValueDel(object sender, AccountChangeArgs a);

    public class Bank
    {
        private decimal _bal;
        public event EventHandler<AccountChangeArgs> BalanceChanged;

        public decimal Goal { get; set; } = 500;
        public decimal Balance {
            get
            {
                return _bal;
            }
            set
            {
                _bal += value;
                this.BalanceChanged(this, new AccountChangeArgs() { amount = Balance, goal = Goal });
            }
        }

        public void listener(object sender, AccountChangeArgs a)
        {
            Console.WriteLine("The balance amount is {0}", a.amount);
        }

        public void listener2(object sender, AccountChangeArgs a)
        {
            if(a.amount >= Goal)
                Console.WriteLine("The goal of {0} has been met", a.goal);
        }

    }

    public class AccountChangeArgs: EventArgs
    {
        public decimal amount;
        public decimal goal;
    }


    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Bank piggy = new Bank();
            piggy.BalanceChanged += piggy.listener;
            piggy.BalanceChanged += piggy.listener2;

            do
            {
                Console.WriteLine("How much to deposit?");
                input = Console.ReadLine();
                if(!input.Equals("exit"))
                    piggy.Balance = Convert.ToDecimal(input);

            } while (!input.Equals("exit"));
            
            Console.WriteLine("Goodbye!");
        }
    }
}
