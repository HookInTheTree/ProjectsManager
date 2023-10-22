namespace ProjectsManager.Domain.AggregateModels.ProjectAggregate.ValueObjects.Resources
{
    public class Quantity : ValueObject
    {
        public int Value { get; }
        public Quantity(int quantity)
        {
            if (quantity <= 0)
            {
                throw new ArgumentException("Quantity value can't be less or equal 0!");
            }
            this.Value = quantity;
        }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}