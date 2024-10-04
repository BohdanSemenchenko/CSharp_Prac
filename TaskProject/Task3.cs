using System.Linq;
using System;

public class Task3 : ITask
{
    private int[] array;

    public Task3(int lastDigit)
    {
        Random random = new Random();
        array = new int[10 + lastDigit];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-100, 100); // Random values from -100 to 100
        }
    }

    public void Execute()
    {
        Console.WriteLine("Task 3:");
        int min = array.Min();
        int max = array.Max();
        Console.WriteLine($"Array: {string.Join(", ", array)}");
        Console.WriteLine($"Min: {min}, Max: {max}");
    }
}
