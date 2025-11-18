public class Customer
{
    private int _customerId;
    private bool _lactoseIntolerant;
    private bool _vegetarian;
    string _name;

    public Customer(int  customerId, string name, bool vegetarian, bool lactoseIntolerant)
    {
        _customerId = customerId;
        _name = name;
        _vegetarian = vegetarian;
        _lactoseIntolerant = lactoseIntolerant;
    }

    public string Name
    { 
        get { return _name; } 
    }

    public bool IsVegetarian

        { get { return _vegetarian; } }

    public bool IsLactoseIntolerant
    { 
        get  { return _lactoseIntolerant; } 
    }
    public void LeaveReview(Order order, Review review)
    {
        if (order == null || review == null)
        {
            Console.WriteLine("Order or review is invalid.");
            return;
        }

        order.LeaveReview(review);
        Console.WriteLine($"Thank you, {_name}! Your review has been added to order #{order.GetOrderId()}.");
    }
}

