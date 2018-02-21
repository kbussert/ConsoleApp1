////====================================================================================================================
//// IMPLEMENTING 3 STACKS USING ONE ARRAY
//// WOULD CONSIDER MAKING THIS ITS OWN CLASS WITH CTOR, BUT THIS STRUCTURE ACCOMPLISHED MY PURPOSE
////
//// Assuming a fixed size array of a size that is equally
//// divisible by 3 and equal size stacks


////Array to house the stacks, using ints in this case
//int stackSize = 100;
//int[] stackKeeper = new int[stackSize * 3];
//int[] stackPointer = { -1, -1, -1 };

////PUSH
////Adds a value to the top position of the stack indicated
//void push(int value, int stackNumber)
//{
//    if (stackPointer[stackNumber] >= stackSize)
//    {
//        Console.WriteLine("Stack is at capacity, new item cannot be added.");
//        return;
//    }

//    stackPointer[stackNumber] += 1;
//    stackKeeper[getKeeperIndex(stackNumber)] = value;

//}

////pop
//int pop(int stackNum)
//{
//    if (stackPointer[stackNum] < 0)
//    {
//        throw new Exception(message: "Trying to pop and empty stack");
//    }

//    //get the value of the number being returned
//    int value = stackKeeper[getKeeperIndex(stackNum)];

//    //reset the index returned above, if needed
//    //stackKeeper[getKeeperIndex(stackNum)] = 0;

//    //decrement the stack index
//    stackPointer[stackNum]--;

//    return value;
//}

//int peek(int stackNum)
//{
//    return stackKeeper[getKeeperIndex(stackNum)];
//}

////takes the stackNumber and returns the index in the array container
//int getKeeperIndex(int stackNum)
//{
//    return stackSize * stackNum + stackPointer[stackNum];
//}

////count
//int count(int stackNum)
//{
//    return stackPointer[stackNum] + 1;
//}

////isEmpty
//bool isEmpty(int stackNum)
//{
//    return stackPointer[stackNum] == -1;
//}



////====================================================================================================================
//// IMPLEMENTING A STACK THAT KEEPS TRACK OF THE MINIMUM VALUE IN THE STACK
//// ASSUMING ITS OKAY TO USE THE .NET STACK CLASS TO KEEP TRACK OF THE MINIMUM VALUES.
//class Program
//{
//    static void Main(string[] args)
//    {
//        MyStack stack1 = new MyStack(12);
//        stack1.printStack();
//        stack1.push(14);
//        Console.WriteLine("The minimum value of the stack is: {0}\n", stack1.min());
//        stack1.pop();
//        stack1.pop();
//        stack1.min();

//        stack1.push(14);
//        stack1.push(24);
//        Console.WriteLine("The minimum value of the stack is: {0}\n", stack1.min());
//        stack1.push(11);
//        Console.WriteLine("The minimum value of the stack is: {0}\n", stack1.min());
//        stack1.push(2);
//        Console.WriteLine("The minimum value of the stack is: {0}\n", stack1.min());
//        stack1.push(30);
//        Console.WriteLine("The minimum value of the stack is: {0}\n", stack1.min());
//        stack1.push(49);
//        Console.WriteLine("The minimum value of the stack is: {0}\n", stack1.min());
//        stack1.push(37);
//        Console.WriteLine("The minimum value of the stack is: {0}\n", stack1.min());
//        stack1.push(48);
//        Console.WriteLine("The minimum value of the stack is: {0}\n", stack1.min());
//        stack1.push(7);
//        Console.WriteLine("The minimum value of the stack is: {0}\n", stack1.min());
//        stack1.push(153);
//        Console.WriteLine("The minimum value of the stack is: {0}\n", stack1.min());
//        stack1.push(88);
//        Console.WriteLine("The minimum value of the stack is: {0}\n", stack1.min());
//        stack1.push(2);
//        Console.WriteLine("The minimum value of the stack is: {0}\n", stack1.min());
//        stack1.push(1);
//        Console.WriteLine("The minimum value of the stack is: {0}\n", stack1.min());

//        stack1.printStack();
//        stack1.pop();
//        stack1.push(1);
//        Console.WriteLine("The minimum value of the stack is: {0}\n", stack1.min());

//        stack1.printStack();

//        stack1.pop();
//        Console.WriteLine("The minimum value of the stack is: {0}\n", stack1.min());

//        stack1.printStack();

//        stack1.pop();
//        Console.WriteLine("The minimum value of the stack is: {0}\n", stack1.min());

//        stack1.printStack();

//        Console.ReadKey();

//    }
//}

//class MyStack
//{
//    private int[] stackArray;
//    private Stack<int> minStack;
//    private int stackIndex;

//    public MyStack(int size)
//    {
//        stackArray = new int[size];
//        minStack = new Stack<int>();
//        stackIndex = -1;
//    }

//    public void push(int value)
//    {
//        if (stackIndex == -1) //empty stack
//        {
//            minStack.Push(value); // any value added will be a minimum
//        }
//        else if (stackIndex == (stackArray.Length - 1))
//        {
//            Console.WriteLine("Stack is at capacity, item could not be added.");
//            return;
//        }
//        else if (value <= minStack.Peek()) // incoming value is less than or equal to top value on the minStack
//        {
//            minStack.Push(value);  //added value is the new minimum
//        }

//        // Incoming value greater than the top value on the minStack.
//        // Nothing needs to be done with minStack. Only add incoming value to the stackArray

//        stackArray[++stackIndex] = value;

//    }

//    public int pop()
//    {
//        //deal with popping from empty stack
//        if (stackIndex == -1)
//        {
//            Console.WriteLine("Trying to pop from an empty stack");
//            return Int32.MinValue;
//        }

//        int returnVal = stackArray[stackIndex];

//        // Compare value being popped with the top element on the minStack.
//        if (returnVal == minStack.Peek())
//        {
//            minStack.Pop();  //remove top element from minstack
//        }

//        //decrement stack index and return the popped value
//        stackIndex--;

//        return returnVal;
//    }

//    public int min()
//    {
//        try
//        {
//            return minStack.Peek();
//        }
//        catch (Exception)
//        {
//            Console.WriteLine("Trying to peek on an empty stack");
//            return Int32.MaxValue;
//        }
//    }

//    public int count()
//    {
//        return stackIndex + 1;
//    }

//    public void printStack()
//    {
//        if (stackIndex == -1)
//        {
//            Console.WriteLine("Stack is empty, nothing to print!\n");
//            return;
//        }

//        Console.WriteLine("The stack currently contains:\n");
//        for (int i = stackIndex; i >= 0; i--)
//        {
//            Console.WriteLine(stackArray[i]);
//        }
//    }

//}



////====================================================================================================================