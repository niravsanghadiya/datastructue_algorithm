// See https://aka.ms/new-console-template for more information
using DataStructures.ArrayDataStructure;
using DataStructures.Stack;
using DataStructures.StringDataStructure;

var arr = new int[] { 1, 5, 2, 4, 7, 3 };
var maxArrayItem = Arrays.GetMaxElementOfArray(arr);
Console.WriteLine($"maximum element in the array is: {maxArrayItem}");


int x = int.MaxValue;
int y = int.MaxValue;

try
{
    //int z = checked(x + y); // It will thorw an outofflow exception. unchecked will bypass the overflow exception
    int z = (x + 1);
}
catch(OverflowException ex)
{
    Console.WriteLine(ex.Message);
}

checked
{

}

unchecked
{

}


Arrays.LeftRotateArray(arr);

Arrays.SwapNumbersWithoutTemp(7, 6);

var checkAnagrams = StringProblems.CheckAnagrams("car", "rca");

Console.WriteLine(checkAnagrams);

var resultArray = Arrays.ReverseArray(new int[] { 1, 2, 3,5,7,6 });

Console.WriteLine(resultArray);

var uniqueElement = Arrays.FindUniqueElement(new int[] { 1, 2, 3, 2, 3 });

Console.WriteLine(uniqueElement);

//var array1 = new int[] { 1, 2, 3, 4, 3, 2 };
//var array2 = new int[] { 2, 3, 1, 5, 6 };

//var array1 = new int[] { 1, 2, 2, 2, 3, 4 };
var array1 = new int[] { 2, 2, 2,6, 3, 4,6,5,2 };
var array2 = new int[] { 2, 2, 3, 3};
var array3 = new int[] { 1,2,4,3,5,6};
var result = Arrays.FindMultipleDuplicates(array1);
var commonArray = Arrays.FindInterSectionOfArray(array1, array2);

var removeDuplicates = Arrays.RemiveDuplicatesFromArray(array1);
Console.WriteLine($"After demoving duplicates");
for (int i= 0; i < removeDuplicates;i++)
{
    Console.Write(array1[i]);
}

Console.WriteLine();
var pairSum = Arrays.FindPairSum(array3, 5);

Arrays.SortZeorsOnes(new int[] { 0, 1, 1, 0, 0, 1, 0 });

//Console.WriteLine(commonArray);

StackWithArray stack = new StackWithArray(4);

stack.Push(2);
stack.Push(3);
stack.Push(5);
stack.Push(7);

Console.WriteLine($"BEfore");
stack.DisplayStack();

Console.WriteLine();
Console.WriteLine($"Stack's Top element  {stack.Top()}");

Console.WriteLine($"Stack Size {stack.Size()}");
Console.WriteLine($"Removed data  { stack.Pop()}");

Console.WriteLine($"Stack Data");

Console.WriteLine($"Stack Size {stack.Size()}");

stack.Push(6);
Console.WriteLine();
Console.WriteLine($"Before second");
Console.WriteLine();
stack.DisplayStack();
Console.WriteLine();
Console.WriteLine($"Stack Size {stack.Size()}");
Console.WriteLine($"Poped element {stack.Pop()}");
Console.WriteLine($"Poped element {stack.Pop()}");
Console.WriteLine($"Poped element {stack.Pop()}");
Console.WriteLine($"Poped element {stack.Pop()}");


Console.WriteLine($"Stack Size {stack.Size()}");
stack.DisplayStack();

string inputString = "India";
var resultString = NativeStack.ReverseStringUsingStack(inputString);
Console.WriteLine($"Reversed string is {resultString}");

string inputParenthesis = "{([]";
var IsValidString = NativeStack.IsValidParenthesis(inputParenthesis);
Console.WriteLine($"Valid parenthesis : {IsValidString}");


