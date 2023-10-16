using ProjectsManager.Domain.AggregateModels.EmployeeAggregate;
using ProjectsManager.Domain.AggregateModels.OrganizationAggregate.OrganizationValueObjects;

namespace ProjectsManager.Domain.OrganizationAggregate;

public class Organization : Entity
{
    public Name Name { get; private set; }
    public JuridicalAddress JuridicalAddress { get; private set; }
    public ContactInfo ContactInfo { get; private set; }
    public Employee Owner { get; private set; }

    public Organization(Name name, JuridicalAddress juridicalAddress, ContactInfo contactInfo, Employee owner)
    {
        Name = name;
        JuridicalAddress = juridicalAddress;
        ContactInfo = contactInfo;
        Owner = owner;
    }

    public void SetOwner(Employee owner)
    {
        Owner = owner;
    }
}