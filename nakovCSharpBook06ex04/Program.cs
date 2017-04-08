﻿using System;

public class Factorial
{
    public static void Main()
    {
        CalculateFactorial();
    }

    private static void CalculateFactorial()
    {
        Console.WriteLine("You should to enter two numbers (N > K > 1)");

        Console.Write("-> K: ");
        int k = int.Parse(Console.ReadLine());

        Console.Write("-> N: ");
        int n = int.Parse(Console.ReadLine());

        if (n < k || n < 1 || k < 1)
        {
            Console.WriteLine("\nWrong input! Тhe condition(N > K > 1) is not met!\n");
            return;
        }

        long factorial = 1;
        for (int i = k + 1; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine("\nResult: {0}!/{1}! = {2}\n", k, n, factorial);
    }
}