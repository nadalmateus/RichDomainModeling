using RichDomainModeling.Core.DomainObjects;

namespace RichDomainModeling.Catalog.Domain;

public class Category : Entity
{
    public Category(string name, int code)
    {
        Name = name;
        Code = code;
    }

    public string Name { get; private set; }
    public int Code { get; private set; }

    public void UpdateName(string name)
    {
        Name = name;
    }

    public void UpdateCode(int code)
    {
        Code = code;
    }

    public override string ToString()
    {
        return $"{Name} - {Code}";
    }
}