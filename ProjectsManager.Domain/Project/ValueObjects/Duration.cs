﻿using ProjectsManager.Domain.Common;
namespace ProjectsManager.Domain.ProjectAggregate.ValueObjects;
public class Duration: ValueObject
{
    public DateTime Start { get; }
    public DateTime End { get; }

    private Duration() { }

    public Duration(DateTime start, DateTime end)
    {
        if (start == DateTime.MinValue || start == DateTime.MaxValue)
            throw new ArgumentException($"Project start can't be min - {DateTime.MinValue} or {DateTime.MaxValue}");
        else if (end == DateTime.MinValue || end == DateTime.MaxValue)
            throw new ArgumentException($"Project end can't be min - {DateTime.MinValue} or {DateTime.MaxValue}");
        else if (start >= end)
            throw new ArgumentException($"Project start can't be more or equal than end");
        
        Start = start;
        End = end;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Start;
        yield return End;
    }
}