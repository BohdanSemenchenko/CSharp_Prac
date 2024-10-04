using System.Linq;
using System;

public class Task4 : ITask
{
    private int[] array;
    private int M;

    public Task4(int lastDigit, int M)
    {
        this.M = M;
        Random random = new Random();
        array = new int[10 + lastDigit];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-100, 100); // Random values from -100 to 100
        }
    }

    public void Execute()
    {
        Console.WriteLine("Task 4:");
        var newArray = array.Where(n => Math.Abs(n) > M).ToArray();
        Console.WriteLine($"Array X: {string.Join(", ", array)}");
        Console.WriteLine($"M: {M}");
        Console.WriteLine($"Array Y (elements > |M|): {string.Join(", ", newArray)}");
    }
}
