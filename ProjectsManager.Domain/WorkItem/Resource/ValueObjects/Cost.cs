using ProjectsManager.Domain.Common;

namespace ProjectsManager.Domain.WorkItemAggregate.Resources.ValueObjects
{
    public class Cost : ValueObject
    {
        public decimal Value { get; }
        public Cost(decimal cost)
        {
            if (cost < 0)
            {
                throw new ArgumentException("Cost value can't be less 0!");
            }

            this.Value = cost;
        }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
        
    }
}