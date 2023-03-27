public class Product
{
    public string Name {get;set;}
    public string Size {get;set;}
    public double Price {get;set;}
    public string Description {get;set;}

    public Product()
    {
        Name = "NULL";
        Size = "NULL";
        Price = 0;
        Description = "NULL";
    }

    public Product(string name, string size, double price, string description)
    {
        Name = name;
        Size = size;
        Price = price;
        Description = description;
    }

    public override string ToString()
    {
        return $"{Name} | {Size} | {Price} | {Description}";
    }
}





