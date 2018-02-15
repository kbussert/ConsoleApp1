using System;

namespace Events
{
    //there are two events to notify
    //1 when the balance has changed
    //2 when the goal has been met

    //public delegate void accountValueDel(decimal input);

    class Bank
    {
        public event EventHandler<AccountChangeArgs> BalanceChanged;
        public event EventHandler<AccountChangeArgs> GoalMet;

        public decimal Goal { get; set; }
        public decimal Balance { get; set; }

    }

    class AccountChangeArgs: EventArgs
    {
        decimal value;
    }


    class Program
    {
        static void Main(string[] args)
        {




            Console.WriteLine("Hello World!");
        }
    }
}
