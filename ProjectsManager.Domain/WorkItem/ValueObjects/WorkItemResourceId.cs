using ProjectsManager.Domain.Common;
using ProjectsManager.Domain.ResourceType.ValueObjects;

namespace ProjectsManager.Domain.WorkItem
{
    public sealed class WorkItemResourceId : AggregateRootId<Guid>
    {
        private WorkItemResourceId(Guid guid)
        {
            Value = Value;
        }

        public override Guid Value { get; protected set; }

        public static WorkItemResourceId Create(Guid guid)
        {
            return new WorkItemResourceId(guid);
        }

        public static WorkItemResourceId CreateUnique()
        {
            return new WorkItemResourceId(Guid.NewGuid());
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}