using System;
using System.Collections.Generic;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tstack left_Tower = new Tstack(10);

            left_Tower.Push(5);
            left_Tower.Push(4);
            left_Tower.Push(6);

            Console.ReadKey();
        }

    }

    public class Tstack
    {
        private int _size;
        private int index = -1;
        private int count = 0;
        private int[] stack;

        public Tstack(int size)
        {
            _size = size;
            stack = new int[_size];
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public void Push(int value)
        {
            
            if (this.IsEmpty())             //check for an empty stack
            {
                stack[++index] = value;
                count++;
            }
            else if (this.count == _size)   //check if the stack is full
            {
                throw new Exception("stack is full, no additional items can be added.");
            }
            else if (this.Peek() <= value)  //throw exception if peeked value is less than the incoming "value"
            {
                throw new Exception("can not add a larger disk onto a smaller disk.");
            }
            else                            //push the value
            {
                stack[++index] = value;
                count++;
            }
        }

        public int Pop()
        {
            if (this.IsEmpty())
            {
                throw new Exception("cannot pop from an empty stack");
            }

            int temp = stack[index];
            stack[index--] = 0;
            count--;

            return temp;
        }

        public int Peek()
        {
            if (count == 0)
            {
                throw new Exception("cannot peek the top value of an empty stack");   
            }

            return stack[index];
        }

    }
}
