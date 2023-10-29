using ProjectsManager.Domain.Common;

namespace ProjectsManager.Domain.ProjectAggregate.ValueObjects;

public class ProjectId:ValueObject
{
    protected override IEnumerable<object> GetEqualityComponents()
    {
        throw new NotImplementedException();
    }
}