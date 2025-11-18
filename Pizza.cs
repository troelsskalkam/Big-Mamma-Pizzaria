
public class Pizza
{
    private int _pizzaId;
    private string _name;
    private double _price;
    private string _description;

    public Pizza(int pizzaId, string name, string description, double price)
    {
        _pizzaId = pizzaId;
        _name = name;
        _description = description;
        _price = price;
    }

    public string Name
    {
        get { return _name; }
    }

    public double price 
    { 
        get { return _price; } 
    }


}

