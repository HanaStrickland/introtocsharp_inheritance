public class Television : Product
{
    public bool IsSmart {get;set;}

    public Television()
    {
        IsSmart = true;
    }

    public Television(string name, string size, double price, string description, bool isSmart) : base(name, size, price, description)
    {
        IsSmart = isSmart;
    }

    public override string ToString()
    {
        return $"{base.ToString()} | Is a Smart TV: {IsSmart}";
    }
}