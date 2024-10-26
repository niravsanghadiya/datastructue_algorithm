using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Stack
{
    public class StackWithArray
    {
        private int[] stack;
        private int top;
        private int maxSize;

        public StackWithArray(int size)
        {
            this.stack = new int[size];
            top = -1;
            maxSize = size;
        }
        public void Push(int item)
        {
            top++;
            stack[top] = item;          
        }

        public int Pop() 
        {

            if (IsEmpty())
            {
                Console.WriteLine($"Stack is Empty");
                return -1;
            }
            return stack[top--]; 
        }

        public int Top()
        {
            if (IsEmpty())
            {
                Console.WriteLine($"Stack is Empty");
                return -1;
            }
            return stack[top];
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top == maxSize - 1;
        }

        public int Size()
        {
            return top+1;
        }

        public void DisplayStack()
        {
            if (top == -1)
            {
                Console.WriteLine($"Stack is Empty");

            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.Write($"{stack[i]}");
                }
            }           
        }

    }
}
