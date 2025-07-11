using RichDomainModeling.Core.DomainObjects;

namespace RichDomainModeling.Catalog.Domain;

public class Category : Entity
{
    public string Name { get; private set; }
}