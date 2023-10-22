using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectsManager.Domain.AggregateModels.ProjectAggregate.ValueObjects.ResourceType;

namespace ProjectsManager.Domain.AggregateModels.ProjectAggregate.Entities
{
    public class ResourceType:Entity
    {
        public Name Name { get; private set; }
        public Description Description { get;private set; }
        public ResourceType(Name name, Description description)
        {
            Name = name;
            Description = description;
        }

        public void ChangeName(Name name)
        {
            Name = name;
        }

        public void ChangeDescription(Description description)
        {
            Description = description;
        }
    }
}
