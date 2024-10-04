using System;

public class TaskController
{
    private ITask[] tasks;

    public TaskController(ITask[] tasks)
    {
        this.tasks = tasks;
    }

    public void Run()
    {
        foreach (var task in tasks)
        {
            task.Execute();
            Console.WriteLine();
        }
    }
}
