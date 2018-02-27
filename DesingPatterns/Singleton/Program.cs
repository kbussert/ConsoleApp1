using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            ChocolateFactory cf = ChocolateFactory.GetInstance();

            cf.Fill();

            ChocolateFactory cf2 = ChocolateFactory.GetInstance();

            cf.Boil();
            cf2.Fill();
            cf.Drain();
            cf2.Fill();
            cf2.Boil();
            cf2.Drain();


            Console.ReadKey();
        }
    }
}
