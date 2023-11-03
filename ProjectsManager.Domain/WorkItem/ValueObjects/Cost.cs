using ProjectsManager.Domain.Common;

namespace ProjectsManager.Domain.WorkItem.ValueObjects
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

            Value = cost;
        }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

    }
}