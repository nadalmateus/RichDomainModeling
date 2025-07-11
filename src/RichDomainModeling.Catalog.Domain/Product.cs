using RichDomainModeling.Core.DomainObjects;

namespace RichDomainModeling.Catalog.Domain;

public class Product : Entity, IAggregateRoot
{
    public Product(
        string name,
        string description,
        bool active,
        decimal amount,
        DateOnly registrationDate,
        string image,
        Guid categoryId)
    {
        Name = name;
        Description = description;
        Active = active;
        Amount = amount;
        RegistrationDate = registrationDate;
        Image = image;
        CategoryId = categoryId;
    }

    public string Name { get; private set; }
    public string Description { get; private set; }
    public bool Active { get; private set; }
    public decimal Amount { get; private set; }
    public DateOnly RegistrationDate { get; private set; }
    public string Image { get; private set; }
    public int QuantityInStock { get; private set; }
    public Guid CategoryId { get; private set; }
    public Category? Category { get; private set; }

    public void UpdateName(string name)
    {
        Name = name;
    }

    public void UpdateDescription(string description)
    {
        Description = description;
    }

    public void Activate()
    {
        Active = true;
    }

    public void Deactivate()
    {
        Active = false;
    }

    public bool HasStock(int quantity)
    {
        return QuantityInStock >= quantity;
    }

    public void CreditStock(int quantity)
    {
        if (quantity < 0)
        {
            quantity *= -1;
        }
        QuantityInStock += quantity;
    }

    public void DebitStock(int quantity)
    {
        if (quantity < 0)
        {
            quantity *= -1;
        }

        QuantityInStock -= quantity;
    }

    public void UpdateCategory(Category category)
    {
        Category = category;
        CategoryId = category.Id;
    }
}