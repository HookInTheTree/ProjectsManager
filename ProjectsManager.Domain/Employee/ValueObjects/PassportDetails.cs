using ProjectsManager.Domain.Common;

namespace ProjectsManager.Domain.EmployeeAggregate.ValueObjects;

public class PassportDetails:ValueObject
{
    public string Serial { get;  private set;}
    public string Number { get;  private set;}

    protected PassportDetails(string serial, string number)
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

    public static PassportDetails Create(string serial, string number)
    {
        return new PassportDetails(serial, number);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Serial;
        yield return Number;
    }
}