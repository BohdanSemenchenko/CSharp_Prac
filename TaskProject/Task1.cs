using System.Linq;
using System;

public class Task1 : ITask
{
    private int[] numbers;
    private int lowerBound;
    private int upperBound;

    public Task1(int num1, int num2, int num3, int lastDigit)
    {
        numbers = new int[] { num1, num2, num3 };
        lowerBound = 1;
        upperBound = 10 + lastDigit;
    }

    public void Execute()
    {
        Console.WriteLine("Task 1:");
        var selectedNumbers = numbers.Where(n => n >= lowerBound && n <= upperBound).ToArray();
        Console.WriteLine($"Numbers in range [{lowerBound}, {upperBound}]: {string.Join(", ", selectedNumbers)}");
    }
}
