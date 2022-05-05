internal interface ILead
{
    void CreateSubTask();
    void AssignTask();
}

internal interface IProgrammer
{
    void WorkOnTask();
}

// Clients
internal class Manager : ILead
{
    public void CreateSubTask()
    {
        Console.WriteLine("Task created.");
    }

    public void AssignTask()
    {
        Console.WriteLine("Task assigned.");
    }
}

internal class TeamLead : ILead, IProgrammer
{
    public void CreateSubTask()
    {
        Console.WriteLine("Task created.");
    }

    public void AssignTask()
    {
        Console.WriteLine("Task assigned.");
    }

    public void WorkOnTask()
    {
        Console.WriteLine("Started working on the task.");
    }
}

internal class Programmer : IProgrammer
{
    public void WorkOnTask()
    {
        Console.WriteLine("Started working on the task.");
    }
}

// In bad example when The manager has been forced to implement WorkOnTask() which he doesnt work on task.