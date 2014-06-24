using System;

public class Phone
{
    protected static string model;
    protected static string manufacturer;
    protected static int price;
    protected static string owner;
    protected static string batteryModel;
    protected static int hoursTalk;
    protected static int displaySize;
    protected static int numberOfColors;

    public Phone()
    {

    }

    public Phone(string model, string manufacturer)
    {
        model = model;
        manufacturer = manufacturer;
    }

    public Phone(string model, string owner, string manufacturer)
    {
        model = model;
        owner = owner;
        manufacturer = manufacturer;
    }

    public Phone(string model, string owner, string manufacturer, int price)
    {
        model = model;
        owner = owner;
        manufacturer = manufacturer;
        price = price;
    }

    static void Main()
    {
        int placeNAme = int.Parse(Console.ReadLine());

    }
}

public enum BatteryType
{
    Lilon, NiMH, NiCd
}
