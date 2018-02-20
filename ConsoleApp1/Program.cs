using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implement 3 stacks from one array
            //Assuming a fixed size array of a size that is equally
            //divisible by 3 and equal size stacks

            //Array to house the stacks, using ints in this case
            int stackSize = 100;
            int[] stackKeeper = new int[stackSize * 3];
            int[] stackPointer = { -1, -1, -1 };

            //PUSH
            //Adds a value to the top position of the stack indicated
            void push(int value, int stackNumber)
            {
                if(stackPointer[stackNumber] >= stackSize)
                {
                    Console.WriteLine("Stack is at capacity, new item cannot be added.");
                    return;
                }

                stackPointer[stackNumber] += 1;
                stackKeeper[getKeeperIndex(stackNumber)] = value;
                
            }

            //pop
            int pop(int stackNum)
            {
                if (stackPointer[stackNum] < 0)
                {
                    throw new Exception(message: "Trying to pop and empty stack");
                }

                //get the value of the number being returned
                int value = stackKeeper[getKeeperIndex(stackNum)];

                //reset the index returned above, if needed
                //stackKeeper[getKeeperIndex(stackNum)] = 0;
                
                //decrement the stack index
                stackPointer[stackNum]--;

                return value;
            }

            int peek(int stackNum)
            {
                return stackKeeper[getKeeperIndex(stackNum)];
            }

            //takes the stackNumber and returns the index in the array container
            int getKeeperIndex(int stackNum)
            {
                return stackSize * stackNum + stackPointer[stackNum];
            }

            //count
            int count(int stackNum)
            {
                return stackPointer[stackNum] + 1;
            }

            //isEmpty
            bool isEmpty(int stackNum)
            {
                return stackPointer[stackNum] == -1;
            }
        }
    }
}
