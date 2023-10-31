using ProjectsManager.Domain.Common;

namespace ProjectsManager.Domain.EmployeeAggregate.ValueObjects;

public class FullName:ValueObject
{
    public string Name { get; private set; }
    public string MiddleName { get;  private set; }
    public string LastName { get;  private set;}

    public FullName(string name, string middleName, string lastName)
    {
        Name = name;
        MiddleName = middleName;
        LastName = lastName;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Name;
        yield return MiddleName;
        yield return LastName;
    }
}