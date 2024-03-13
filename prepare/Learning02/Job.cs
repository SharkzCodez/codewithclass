using System;

public class Job
{
    public string _jobRole;
    public string _companyName;
    public int _start;
    public int _end;

    public void Display()
    {
        Console.WriteLine($"{_jobRole} {_companyName} {_start} - {_end}");
    }
}