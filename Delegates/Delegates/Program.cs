using System;

namespace Delegates
{
    

    class Program
    {

        public delegate double RateCalc(double cost, bool isHighRisk);

        static void Main(string[] args)
        {
            RateCalc rateCalc;
            bool isRisky;
            bool programRun = true;

            while (programRun)
            {
                Console.WriteLine("What is the destination zone?");
                var input1 = Console.ReadLine();

                switch (input1)
                {
                    case "zone1":
                        rateCalc = zone1Shipping;
                        isRisky = false;
                        break;
                    case "zone2":
                        rateCalc = zone2Shipping;
                        isRisky = true;
                        break;
                    case "zone3":
                        rateCalc = zone3Shipping;
                        isRisky = false;
                        break;
                    case "zone4":
                        rateCalc = zone4Shipping;
                        isRisky = true;
                        break;
                    case "exit":
                        rateCalc = null;
                        isRisky = false;
                        programRun = false;
                        break;
                    default:
                        rateCalc = null;
                        isRisky = false;
                        break;
                }

                if (programRun && rateCalc != null)
                {
                    Console.WriteLine("What is the item price?");
                    var input2 = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("The shipping fees are: {0}\n\n", rateCalc(input2, isRisky));
                }
                else if (!programRun)
                {
                    Console.WriteLine("Program ended");
                }
                else
                {
                    Console.WriteLine("Invalid input data. \n\n");
                }
            }
            //Console.ReadKey();
        }

        public static double zone1Shipping(double cost, bool isHighRisk)
        {
            double shippingRate = 0.25;

            if (isHighRisk)
            {
                return ((cost * shippingRate) + 25);
            }

            return (cost * shippingRate);
        }

        public static double zone2Shipping(double cost, bool isHighRisk)
        {
            double shippingRate = 0.12;

            if (isHighRisk)
            {
                return ((cost * shippingRate) + 25);
            }

            return (cost * shippingRate);
        }

        public static double zone3Shipping(double cost, bool isHighRisk)
        {
            double shippingRate = 0.08;

            if (isHighRisk)
            {
                return ((cost * shippingRate) + 25);
            }

            return (cost * shippingRate);
        }

        public static double zone4Shipping(double cost, bool isHighRisk)
        {
            double shippingRate = 0.04;

            if (isHighRisk)
            {
                return ((cost * shippingRate) + 25);
            }

            return (cost * shippingRate);
        }
    }
}
