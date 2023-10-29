using ProjectsManager.Domain.Common;

namespace ProjectsManager.Domain.OrganizationAggregate.ValueObjects;

public class OrganizationId:ValueObject
{
    protected override IEnumerable<object> GetEqualityComponents()
    {
        throw new NotImplementedException();
    }
}