    public class Topping
    {
    private int _toppingId;
    private string _toppingName;
    private double _price;
    private bool _containsMeat;
    private bool _containsDairy;
    public Topping(int toppingId, string toppingName, double price, bool containsMeat, bool containsDairy) 
    {
        _toppingId = toppingId;
        _toppingName = toppingName;
        _price = price;
        _containsMeat = containsMeat;
        _containsDairy = containsDairy;
    }

    public int toppingId
    { 
        get 
        { 
            return _toppingId; 
        } 
    }
        public string toppingName
    { 
        get 
        { 
            return _toppingName; 
        } 
    }

        public double price

    {
        get
        {
            return _price;
        }
    }

        public bool ContainsMeat
    {
        get { return _containsMeat; }
    }
    public bool ContainsDairy
    {
        get { return _containsDairy; }
    }



}

