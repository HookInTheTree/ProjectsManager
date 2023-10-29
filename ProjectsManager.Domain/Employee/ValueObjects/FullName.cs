using ProjectsManager.Domain.Common;

namespace ProjectsManager.Domain.EmployeeAggregate.ValueObjects;

public class FullName:ValueObject
{
    public string Name { get; private set; }
    public string MiddleName { get;  private set; }
    public string LastName { get;  private set;}

    protected FullName(string name, string middleName, string lastName)
    {
        Name = name;
        MiddleName = middleName;
        LastName = lastName;
    }

    public static FullName Create(string name, string middlename, string lastName)
    {
        return new FullName(name, middlename, lastName);
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Name;
        yield return MiddleName;
        yield return LastName;
    }
}