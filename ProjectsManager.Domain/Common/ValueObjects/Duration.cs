using ProjectsManager.Domain.Common;

namespace ProjectsManager.Domain.Common.ValueObjects;

public sealed class Duration:ValueObject
{
    public DateTime Start { get; private set; }
    public DateTime End { get; private set; }

    public Duration(DateTime start, DateTime end)
    {
        if (start == DateTime.MinValue || start == DateTime.MaxValue)
            throw new ArgumentException($"Start can't be min - {DateTime.MinValue} or {DateTime.MaxValue}");
        else if (end == DateTime.MinValue || end == DateTime.MaxValue)
            throw new ArgumentException($"End can't be min - {DateTime.MinValue} or {DateTime.MaxValue}");
        else if (start >= end)
            throw new ArgumentException($"Start can't be more or equal than end");
        
        Start = start;
        End = end;
    }
    private Duration() { }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Start;
        yield return End;
    }
}