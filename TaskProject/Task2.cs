using System;

public class Task2 : ITask
{
    private double sideA, sideB, sideC;

    public Task2(double sideA, double sideB, double sideC)
    {
        this.sideA = sideA;
        this.sideB = sideB;
        this.sideC = sideC;
    }

    public void Execute()
    {
        Console.WriteLine("Task 2:");
        if (IsValidTriangle())
        {
            double perimeter = sideA + sideB + sideC;
            double s = perimeter / 2;
            double area = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
            string triangleType = DetermineTriangleType();

            Console.WriteLine($"Perimeter: {perimeter}");
            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"Triangle Type: {triangleType}");
        }
        else
        {
            Console.WriteLine("The sides do not form a valid triangle.");
        }
    }

    private bool IsValidTriangle()
    {
        return sideA + sideB > sideC && sideB + sideC > sideA && sideA + sideC > sideB;
    }

    private string DetermineTriangleType()
    {
        if (sideA == sideB && sideB == sideC)
            return "Equilateral";
        if (sideA == sideB || sideB == sideC || sideA == sideC)
            return "Isosceles";
        return "Scalene";
    }
}
