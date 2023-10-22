namespace ProjectsManager.Domain.AggregateModels.ProjectAggregate.ValueObjects.ResourceType
{
    public class Name : Domain.ValueObject
    {
        public string Value { get; }

        public Name(string description)
        {
            if (string.IsNullOrEmpty(description))
                throw new ArgumentException($"Resource type name value can't be null or whitespace!");

            Value = description;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}