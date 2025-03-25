using System;
using System.Diagnostics;

Console.WriteLine($"Starting Stack Depth: {new StackTrace().FrameCount}");

Console.WriteLine("\nTesting Tail Recursion:");
var tailResult = TestExtensions.TailFactorial(5);
Console.WriteLine($"Tail Recursion Result: {tailResult}");

Console.WriteLine("\nTesting Non-Tail Recursion:");
var nonTailResult = TestExtensions.NonTailFactorial(5);
Console.WriteLine($"Non-Tail Recursion Result: {nonTailResult}");

public static class TestExtensions
{
    public static long TailFactorial(int n, long accumulator = 1)
    {
        Console.WriteLine($"Tail Recursion Stack Depth: {new StackTrace().FrameCount}");
        if (n == 0)
        {
            return accumulator;
        }
        return TailFactorial(n - 1, accumulator * n);
    }

    public static long NonTailFactorial(int n)
    {
        Console.WriteLine($"Non-Tail Recursion Stack Depth: {new StackTrace().FrameCount}");
        if (n == 0)
        {
            return 1;
        }
        return n * NonTailFactorial(n - 1);
    }
}
