using System;
using System.Collections;
using System.Collections.Generic;

namespace CS_ADV_A02;

internal class Program
{
    static void Main(string[] args)
    {

        #region Q01
        //// N : size of array :: Q Qnumber of queries
        //Console.Write("Enter Size of Array: ");
        //int n = int.TryParse(Console.ReadLine(), out n) ? n : 0;
        //Console.Write("Enter Number of Queries: ");
        //int q = int.TryParse(Console.ReadLine(), out q) ? q : 0;
        //// Read the array of integers from the console input
        //int[] arr = new int[n];
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write($"Arr[{i + 1}] value = ");
        //    arr[i] = int.TryParse(Console.ReadLine(), out int value) ? value : 0;
        //}
        //// Sort the array
        //Array.Sort(arr);
        //// read the queries from the console input
        //for (int i = 0; i < q; i++)
        //{
        //    Console.Write($"Query{i + 1} value =  ");
        //    int value = int.TryParse(Console.ReadLine(), out value) ? value : 0;
        //    int count = 0;
        //    foreach (int item in arr)
        //    {
        //        if (item > value)
        //        {
        //            count = n - Array.IndexOf(arr, item);
        //            break;
        //        }
        //    }
        //    Console.WriteLine($"Count = {count}");
        //}
        #endregion

        #region Q02 palindrome 
        //Console.Write("Enter Size of array: ");
        //int n = int.TryParse(Console.ReadLine(), out n) ? n : 0;

        //int[] array = new int[n];
        //// Read the array of integers
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write($"Array[{i + 1}] = ");
        //    array[i] = int.TryParse(Console.ReadLine(), out int value) ? value : 0;
        //}
        //// Check if the array is a palindrome
        //String isPalindrome = "Yes";
        //for (int i = 0; i < n / 2; i++)
        //{
        //    if (array[i] != array[n - 1 - i])
        //    {
        //        isPalindrome = "No";
        //        break;
        //    }
        //}

        //Console.WriteLine($"Is Palindrome? {isPalindrome}");

        #endregion

        #region Q03 Reverse Queue
        //Queue<int> queueNumbers = new Queue<int>([1, 2, 3, 4, 5]);

        //Console.WriteLine("Before: ");
        //Console.WriteLine("[" + string.Join(", ", queueNumbers) + "]");

        //ReverseQueue(queueNumbers);

        //Console.WriteLine("\nAfter ReverseQueue: ");
        //Console.WriteLine("[" + string.Join(", ", queueNumbers) + "]");

        #endregion

        #region Q04 parentheses is balanced
        //string str = "({[()]})";
        //bool isBalanced = IsBalanced(str);
        //Console.WriteLine($"{str} : is Balanced? {isBalanced}");

        #endregion

        #region Q05
        //int[] arr = { 1, 2, 3, 4, 4, 6, 7, 10, 9, 10 };
        //Console.WriteLine("Before: [" + string.Join(", ", arr) + "]");
        //RemoveDuplicates(ref arr);
        //Console.WriteLine("After : [" + string.Join(", ", arr) + "]");

        #endregion

        #region Q06
        //ArrayList arrayList = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        //Console.WriteLine("Before: [" + string.Join(", ", arrayList.ToArray()) + "]");
        //RemoveOddNumbers(arrayList);
        //Console.WriteLine("After : [" + string.Join(", ", arrayList.ToArray()) + "]");

        #endregion

        #region Q07 Queue
        //Queue queue = new Queue();
        //queue.Enqueue(1);
        //queue.Enqueue("Apple");
        //queue.Enqueue(5.28);
        //Console.WriteLine(queue.Dequeue());
        //Console.WriteLine(queue.Dequeue());
        //Console.WriteLine(queue.Dequeue());

        #endregion

        #region Q08
        //Stack<int> numbers = new Stack<int>([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);
        //Console.Write("Enter the target number: ");
        //int target = int.TryParse(Console.ReadLine(), out target)? target : 0;
        //SearchInStack(numbers, target);

        #endregion

        #region Q09
        //int[] arr1 = { 1, 2, 3, 4, 4 };
        //int[] arr2 = { 10, 4, 4 };

        //List<int> intersection = FindIntersection(arr1, arr2);

        //Console.WriteLine("[" + string.Join(", ", intersection) + "]");

        #endregion

        #region Q10
        //ArrayList list = new ArrayList() { 1, 2, 3, 7, 5, 9, 4 };
        //int target = 15;

        //FindSublistWithSum(list, target);

        #endregion

        #region Q11
        //Queue<int> numbers = new Queue<int>([1, 2, 3, 4, 5]);
        //int k = 4;
        //Console.WriteLine("Before: [" + string.Join(", ", numbers) + $"] :: K = {k}");
        //ReverseKElementsInQueue(ref numbers, k);
        //Console.WriteLine("After : [" + string.Join(", ", numbers) + "]");

        #endregion




        Console.ReadKey();
    }
    // Q03: Reverse a queue using a stack
    static void ReverseQueue<T>(Queue<T> queue)
    {
        if (queue.Count == 0) return;
        Stack<T> stackNumbers = new Stack<T>();
        while (queue.Count > 0)
            stackNumbers.Push(queue.Dequeue());

        while (stackNumbers.Count > 0)
            queue.Enqueue(stackNumbers.Pop());
    }

    // Q04: function to check if a string of parentheses is balanced 
    static bool IsBalanced(string str)
    {
        Stack<char> stack = new Stack<char>();
        foreach (char c in str)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            else if (c == ')' || c == '}' || c == ']')
            {
                if (stack.Count == 0) return false;
                char top = stack.Pop();
                if (c == ')') // )-( = 1 , }-{ = 2 , ]-[ = 2
                    return (int)c - (int)top == 1; // using asscii values to check balance
                else return (int)c - (int)top == 2;
            }

        }
        return stack.Count == 0;
    }

    // Q05: function to remove duplicates from an array
    static void RemoveDuplicates<T>(ref T[] arr)
    {
        HashSet<T> uniqueElements = [.. arr];
        arr = [.. uniqueElements];
    }

    // Q06: function to remove odd numbers from an ArrayList
    static void RemoveOddNumbers(ArrayList list)
    {
        for (int i = list.Count - 1; i >= 0; i--)
            if ((int)list[i]! % 2 != 0)
                list.RemoveAt(i);
    }

    // Q08 
    static void SearchInStack(Stack<int> stack, int target)
    {
        Stack<int> tempStack = new();
        int count = 0;
        bool found = false;

        while (stack.Count > 0)
        {
            int current = stack.Pop();
            tempStack.Push(current);
            count++;

            if (current == target)
            {
                found = true;
                break;
            }
        }
        while (tempStack.Count > 0)
        {
            stack.Push(tempStack.Pop());
        }

        if (found)
            Console.WriteLine($"Target was found successfully and the count = {count}");
        else
            Console.WriteLine("Target was not found");
    }

    // Q09
    static List<int> FindIntersection(int[] arr1, int[] arr2)
    {
        Dictionary<int, int> counts = new();
        List<int> result = new();

        foreach (int num in arr1)
        {
            if (counts.ContainsKey(num))
                counts[num]++;
            else
                counts[num] = 1;
        }

        foreach (int num in arr2)
        {
            if (counts.ContainsKey(num) && counts[num] > 0)
            {
                result.Add(num);
                counts[num]--;
            }
        }

        return result;
    }

    // Q10
    static void FindSublistWithSum(ArrayList list, int target)
    {
        for (int start = 0; start < list.Count; start++)
        {
            int sum = 0;
            for (int end = start; end < list.Count; end++)
            {
                sum += (int)list[end]!;

                if (sum == target)
                {
                    Console.Write("[");
                    for (int i = start; i <= end; i++)
                    {
                        Console.Write(list[i]);
                        if (i != end) Console.Write(", ");
                    }
                    Console.WriteLine("]");
                    return;
                }
            }
        }

        Console.WriteLine("No sublist found");
    }

    // Q11
    static void ReverseKElementsInQueue(ref Queue<int> queue, int k)
    {
        if (k <= 0 || k > queue.Count) return;
        int[] temp = new int[k];
        for (int i = 0; i < k; i++)
            temp[i] = queue.Dequeue();
        Array.Reverse(temp);
        queue = new Queue<int>([.. temp, ..queue]);
    }
}


// Q07: Queue
class Queue
{
    private LinkedList<object> _items = new LinkedList<object>();
    public void Enqueue(object item) => _items.AddLast(item);
    public object Dequeue()
    {
        if (_items.Count == 0) throw new InvalidOperationException("Queue is empty.");
        object value = _items.First!.Value;
        _items.RemoveFirst();
        return value;
    }
    public int Count => _items.Count;
}
