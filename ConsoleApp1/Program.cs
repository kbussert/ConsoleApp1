using System;
using System.Collections.Generic;
using System.Collections;

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

            for (int i = 0; i < 40; i++)
            {
                ss.pop();
            }

            Console.ReadKey();
        }

        class SetOfStacks
        {
            List<MyStack> master;
            int stackSize;
            int masterIndex;

            public SetOfStacks(int stackSize)
            {
                master = new List<MyStack>(7);
                this.stackSize = stackSize;
                masterIndex = 0;
                master.Add(new MyStack(stackSize));
            }

            public void push(int value)
            {
                //check if the current stack is full
                if (master[masterIndex].Count == stackSize)
                {
                    //no room on current stack, create a new one at the next master index
                    master.Add(new MyStack(stackSize));
                    masterIndex++;
                }
                master[masterIndex].push(value);
            }

            public int pop()
            {
                if(master[masterIndex].isEmpty())
                {
                    Console.WriteLine("Error thrown - Somthing bad happened. Trying to pop from an empty stack.");
                    return Int32.MinValue;
                }

                int value = master[masterIndex].pop();

                if (master[masterIndex].isEmpty())
                {
                    masterIndex--;
                }

                return value;
            }
        }

        public class MyStack
        {
            private int[] stack { get; set; }
            private int index;
            private int maxSize;
            public int Count { get; private set; } = 0;

            public MyStack(int size)
            {
                maxSize = size;
                stack = new int[maxSize];
                index = 0;
            }

            public void push(int value)
            {
                if (index == maxSize)
                {
                    Console.WriteLine("Error - Stack is full, item was not pushed.");
                }

                stack[index++] = value;
                Count++;
            }

            public int pop()
            {
                if (isEmpty())
                {
                    Console.WriteLine("Error - Trying to pop from an empty stack.");
                    return Int32.MinValue;
                }

                int retVal = stack[--index];
                stack[index] = 0;
                Count--;

                return retVal;
            }

            public bool isEmpty()
            {
                return Count == 0;
            }
        }
    }
}
