namespace ProjectsManager.Domain.AggregateModels.EmployeeAggregate;

public class PassportDetails:ValueObject
{
    public string Serial { get; }
    public string Number { get; }

    public PassportDetails(string serial, string number)
    {
        if (string.IsNullOrEmpty(serial))
            throw new ArgumentException("The serial code can't be null or empty!");
        if (string.IsNullOrEmpty(number))
            throw new ArgumentException("The number code can't be null or empty!");
        
        if (!serial.All(x => char.IsDigit(x) && serial.Length != 4))
            throw new ArgumentException("The serial can include only 4 digits!");
        if (!number.All(x => char.IsDigit(x)) && number.Length != 6)
            throw new ArgumentException("The number can include only 6 digits!");

        Serial = serial;
        Number = number;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Serial;
        yield return Number;
    }
}