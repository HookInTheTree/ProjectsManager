namespace ProjectsManager.Domain.AggregateModels.ProjectAggregate.ValueObjects.Resources
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