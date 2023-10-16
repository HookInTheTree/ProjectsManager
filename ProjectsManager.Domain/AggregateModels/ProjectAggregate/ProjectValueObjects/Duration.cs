namespace ProjectsManager.Domain.AggregateModels.ProjectAggregate.ProjectValueObjects;

public class Duration:ValueObject
{
    public DateTime Start { get; }
    public DateTime End { get; }

    public Duration(DateTime start, DateTime end)
    {
        if (start == DateTime.MinValue || start == DateTime.MaxValue)
            throw new ArgumentException($"Start can't be min - {DateTime.MinValue} or {DateTime.MaxValue}");
        else if (end == DateTime.MinValue || end == DateTime.MaxValue)
            throw new ArgumentException($"End can't be min - {DateTime.MinValue} or {DateTime.MaxValue}");
        else if (start >= end)
            throw new ArgumentException($"Start can't be more or equal than End");
        
        Start = start;
        End = end;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Start;
        yield return End;
    }
}