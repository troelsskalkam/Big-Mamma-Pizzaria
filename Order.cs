using System.Runtime.CompilerServices;

public class Order
{
    private int _orderId;
    private bool _dineIn;
    private double _totalPrice;
    private Customer _customer;
    private Pizza _pizza;
    private Employee? _employee;
    private Review? _review;

    private Topping? _topping1;
    private Topping? _topping2;
    private Topping? _topping3;

    public Order(int orderId, bool dineIn, Customer customer)
    {
        _orderId = orderId;
        _dineIn = dineIn;
        _customer = customer;
        _totalPrice = 0;
    }

    public bool Dinein
    {
        get { return _dineIn; }
    }

    public void LeaveReview(Review review)
    {
        _review = review;
    }

    public int GetOrderId()
    {
        return _orderId;
    }
    public void AssignEmployee(Employee employee)
    {
        _employee = employee;
    }
    
    public void AddPizza(Pizza pizza)
    {
        _pizza = pizza;
        _totalPrice += pizza.price;
    }

    private bool _customerIsVegetarian()
    {
        return _customer.IsVegetarian;
    }

    private bool _customerIsLactoseIntolerant()
    {
        return _customer.IsLactoseIntolerant;
    }

    public void AddTopping(Topping topping)
    { 
        if (_customerIsVegetarian() && topping.ContainsMeat)
        {
            Console.WriteLine($"{topping.toppingName} contains meat, you shouldn't add it");
            return;
        }
        if (_customerIsLactoseIntolerant() && topping.ContainsDairy)
        {
            Console.WriteLine($"{topping.toppingName} contains dairy, you shouldn't add it");
            return;
        }

        if (_topping1 == null)
        {
            _topping1 = topping;
        _totalPrice += topping.price;
        }
        else if (_topping2 == null)
        {
            _topping2 = topping;
            _totalPrice += topping.price;
        }
        else if (_topping3 == null)
        {
            _topping3 = topping;
            _totalPrice += topping.price;
        }
        else
        {
            System.Console.WriteLine("you can't add more than 3 toppings to your pizza");
        }
    }

    public double CalculateTotalPrice()
    {
        double total = _totalPrice;       
        total *= 1.25;

        if (!_dineIn)
            total += 3;                        
        return total;
    }


    public override string ToString()
    {

        Console.WriteLine($"Employee id: {_employee.EmployeeId}");
        Console.WriteLine($"Employee name: {_employee.Name}");
        
        Console.WriteLine();
        Console.WriteLine($"{_employee.Name}: Are you dining in?");
        Console.WriteLine();

        if (_dineIn == true)
        {
            Console.WriteLine($"{_customer.Name}: yes");
        }
        else
        {
            Console.WriteLine($"{_customer.Name}: no");
        }

        string dineInText = _dineIn ? "Yes" : "No";

        Console.WriteLine();
        Console.WriteLine($"{_employee.Name}: What would you like to eat?");
        Console.WriteLine();
        Console.WriteLine($"{_customer.Name}: I would like a {_pizza.Name} pizza");
        Console.WriteLine();
        Console.WriteLine($"{_employee.Name}: Any extra toppings with that?");
        Console.WriteLine();

        string toppings = "";

        if (_topping1 != null && _topping2 == null && _topping3 == null)
        {
            toppings = _topping1.toppingName;
        }
        else if (_topping1 != null && _topping2 != null && _topping3 == null)
        {
            toppings = _topping1.toppingName + " and " + _topping2.toppingName;
        }
        else if (_topping1 != null && _topping2 != null && _topping3 != null)
        {
            toppings = _topping1.toppingName + ", " + _topping2.toppingName + " and " + _topping3.toppingName;
        }
        else if (_topping1 != null && _topping2 == null && _topping3 != null)
        {
            toppings = _topping1.toppingName + " and " + _topping3.toppingName;
        }
        else if (_topping1 == null && _topping2 != null && _topping3 != null)
        {
            toppings = _topping2.toppingName + " and " + _topping3.toppingName;
        }
        else if (_topping2 != null && _topping1 == null && _topping3 == null)
        {
            toppings = _topping2.toppingName;
        }
        else if (_topping3 != null && _topping1 == null && _topping2 == null)
        {
            toppings = _topping3.toppingName;
        }
        else if (_topping1 == null && _topping2 != null && _topping3 == null)
        {
            toppings = _topping2.toppingName;
        }
        else if (_topping1 == null && _topping2 == null && _topping3 != null)
        {
            toppings = _topping3.toppingName;
        }

        if (toppings != "")
            Console.WriteLine($"{_customer.Name}: with " + toppings + " please.");
        else
            Console.WriteLine($"{_customer.Name}: with no extra toppings please.");

        // Handle toppings
        string extraToppings = "";
        if (_topping1 != null)
        {
            extraToppings = _topping1.toppingName;
            if (_topping2 != null)
                extraToppings += " and " + _topping2.toppingName;
            if (_topping3 != null)
                extraToppings += " and " + _topping3.toppingName;
        }
        else
        {
            extraToppings = "None";
        }


        double vatPrice = _totalPrice * 1.25;
        double delivery = _dineIn ? 0 : 4;
        double totalPrice = vatPrice + delivery;


        if (_review != null)
        {
            Console.WriteLine("review:");
            Console.WriteLine($"Rating: {_review.Rating()}");
            Console.WriteLine($"Comment: {_review.Comment()}");
            Console.WriteLine();
        }

        return $"Order ID: {_orderId}\n" +
               $"Customer: {_customer.Name}\n" +
               $"Employee: {_employee?.Name ?? "Not assigned"}\n" +
               $"Dine-in: {dineInText}\n" +
               $"Pizza: {_pizza.Name}\n" +
               $"Toppings: {extraToppings}\n" +
               $"Total price (incl. VAT{(!_dineIn ? " + Delivery" : "")}): {totalPrice:0.00} kr";


    }



}

