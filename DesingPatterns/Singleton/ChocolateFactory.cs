using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Singleton
{
    class ChocolateFactory
    {
        private bool Empty { get; set; }
        private bool Boiled { get; set; }
        //private static ChocolateFactory _instance;  //CLASSIC IMPLEMENTATION + SYNCHRONIZED SOLUTIONS
        //private static ChocolateFactory _instance = new ChocolateFactory(); //EAGER INSTANTIATION
        private volatile static ChocolateFactory _instance;  //DOUBLE-CHECKED LOCKING

        private ChocolateFactory()
        {
            Empty = true;
            Boiled = false;
        }

        //DOUBLE-CHECKED LOCKING
        public static ChocolateFactory GetInstance()
        {
            if (_instance == null)
            {
                lock(typeof(ChocolateFactory))
                {
                    if (_instance == null)
                        _instance = new ChocolateFactory();
                }
            }

            return _instance;
        }


        //ALTERNATIVE IMPLEMENTATIONS

        //EAGER INSTANTIATION
        //public ChocolateFactory GetInstance()
        //{
        //    return _instance;
        //}


        //SYNCHRONIZING THE METHOD TO PREVENT MULTIPLE INSTANCES BY DIFFERENT THREADS
        //[MethodImpl(MethodImplOptions.Synchronized)]
        //public static ChocolateFactory GetInstance()
        //{
        //    if (_instance == null)
        //    {
        //        _instance = new ChocolateFactory();
        //    }

        //    return _instance;
        //}
        

        //CLASSIC IMPLEMENTATION
        //public static ChocolateFactory GetInstance()
        //{
        //    if (_instance == null)
        //    {
        //        _instance = new ChocolateFactory();
        //    }

        //    return _instance;
        //}

        public void Fill()
        {
            if (Empty)
            {
                Empty = false;
                Boiled = false;
                //fill the boiler with milk/chocolate mixture
            }
        }

        public void Drain()
        {
            if (!Empty && Boiled)
            {
                //drain the boiled milk/chocolate mixture
                Empty = true;
            }
        }

        public void Boil()
        {
            if (!Empty && !Boiled)
            {
                //bring contents to a boil
                Boiled = true;
            }
        }

    }
}
