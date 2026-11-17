using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<int, int> memo = new Dictionary<int, int>();

    static int Fibonacci(int n)
    {

        if (memo.ContainsKey(n))
            return memo[n];

        if (n <= 1)
            return n;

        memo[n] = Fibonacci(n - 1) + Fibonacci(n - 2);
        return memo[n];
    }

    static void Main()
    {
        int n = 10;
        Console.WriteLine($"Fibonacci({n}) (Memoization) = {Fibonacci(n)}");
    }
}