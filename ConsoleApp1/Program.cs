using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SetOfStacks ss = new SetOfStacks(10);

            for (int i = 0; i < 40; i++)
            {
                ss.push(i * 2);
            }
           
            Console.ReadKey();
        }

        class SetOfStacks
        {
            List<Stack> master;
            int stackSize;
            int masterIndex;

            public SetOfStacks(int stackSize)
            {
                master = new List<Stack>();
                this.stackSize = stackSize;
                masterIndex = 0;
                master[0] = new Stack(stackSize);
            }

            public void push(int value)
            {
                if (master[masterIndex].size() >= stackSize)
                {
                    //left off here
                }
            }

            int pop()
            {
                return -1;
            }


        }

        class Stack
        {
            private int[] stack { get; set; }
            private int index;


            public Stack(int size)
            {
                stack = new int[size];
                index = 0;
            }

            public int size()
            {
                return index + 1;
            }

            void push(int value)
            {

            }

            int pop()
            {
                return -1;
            }
        }
    }
}
