namespace RichDomainModeling.Core.DomainObjects;

public abstract class Entity
{
    public Guid Id { get; set; }

    protected Entity()
    {
        Id = Guid.NewGuid();
    }

    public override bool Equals(object? obj)
    {
        var compareTo = obj as Entity;

        return ReferenceEquals(this, compareTo) || (compareTo is not null && Id.Equals(compareTo.Id));
    }

    public static bool operator ==(Entity a, Entity b)
    {
        return ReferenceEquals(a, b) && b is null || a is not null && b is not null && a.Equals(b);
    }

    public static bool operator !=(Entity a, Entity b)
    {
        return !(a == b);
    }

    public override int GetHashCode()
    {
        return (GetType().GetHashCode() * 907) + Id.GetHashCode();
    }

    public override string ToString()
    {
        return $"{GetType().Name} [Id={Id}]";
    }
}