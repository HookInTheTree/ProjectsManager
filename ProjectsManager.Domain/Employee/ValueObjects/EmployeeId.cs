using ProjectsManager.Domain.Common;

namespace ProjectsManager.Domain.EmployeeAggregate.ValueObjects;

public class EmployeeId : ValueObject
{
    protected override IEnumerable<object> GetEqualityComponents()
    {
        throw new NotImplementedException();
    }
}