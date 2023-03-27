public class Computer : Product
{
    public double BatteryLife {get;set;}

    public Computer()
    {
        BatteryLife = 0;
    }

    public Computer(string name, string size, double price, string description, double batteryLife) : base(name, size, price, description)
    {
        BatteryLife = batteryLife;
    }

    public override string ToString()
    {
        return $"{base.ToString()} | {BatteryLife} hours";
    }


}