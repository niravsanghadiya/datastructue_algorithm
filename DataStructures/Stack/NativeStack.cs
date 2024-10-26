using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Stack
{
    public static class NativeStack
    {
        public static string ReverseStringUsingStack(string str)
        {
            if(str.Length == 0)
            {
                Console.WriteLine($"Input string in empty");
            }

            Stack<char> stack = new Stack<char>();
            StringBuilder reversedString = new StringBuilder();
            var charArrays = str.ToCharArray();

            for(int i = 0; i < charArrays.Length; i++)
            {
                stack.Push(charArrays[i]);
            }

            while(stack.Count > 0)
            {
                reversedString.Append(stack.Pop());               
            }
            return reversedString.ToString();
        }

        public static bool IsValidParenthesis(string str)
        {
            if (string.IsNullOrEmpty(str)) return false;

            bool isValid = true;

            var inputStringChars = str.ToCharArray();
            Stack<char> charStack = new Stack<char>();

            for (int i = 0; i < inputStringChars.Length; i++)
            {
                if (inputStringChars[i] == '[' || inputStringChars[i] == '(' || inputStringChars[i] == '{')
                {
                    charStack.Push(inputStringChars[i]);
                }
                else
                {
                    if(charStack.Count > 0)
                    {
                        var topChar = charStack.Peek();
                        if ((inputStringChars[i] == ']' && topChar == '[')
                            || (inputStringChars[i] == ')' && topChar == '(')
                            || (inputStringChars[i] == '}' && topChar == '{'))
                        {
                            charStack.Pop();
                        }
                        else
                        {
                            isValid = false;                           
                        }
                    }
                    else
                    {
                        isValid = false;
                    }                   
                }
            }
            if(charStack.Count > 0)
            {
                isValid = false;
            }
            else
            {
                isValid = true;
            }
            return isValid;
        }

        public static Stack<int> InsertElementAtEnd(Stack<int> stack,int inputElement)
        {

            InsertAtEnd(stack, inputElement);
            return stack;
           
        }

        private static void InsertAtEnd(Stack<int> stack, int inputElement)
        {
            if(stack.Count == 0)
            {
                stack.Push(inputElement);
            }
            
            // Get top element and keep it aside. Then pop one element. Again keep the top aside and pop next element
            var top = stack.Peek();

            stack.Pop();
            // recursive call 
            InsertAtEnd(stack, inputElement);

            stack.Push(top);

        }



    }
}
