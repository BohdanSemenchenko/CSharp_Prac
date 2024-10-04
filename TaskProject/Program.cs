class Program
{
    static void Main(string[] args)
    {
        int lastDigit = 9;
        ITask[] tasks = new ITask[]
        {
            new Task1(3, 15, 7, lastDigit),
            new Task2(3.0, 4.0, 5.0),
            new Task3(lastDigit),
            new Task4(lastDigit, 10)
        };

        TaskController controller = new TaskController(tasks);
        controller.Run();
    }
}
