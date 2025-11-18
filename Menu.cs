public class Menu
{
    private int _menuId;
    private Pizza _pizza1;
    private Pizza _pizza2;
    private Pizza _pizza3;
    private Pizza _pizza4;
    private Topping _topping1;
    private Topping _topping2;
    private Topping _topping3;
    private Topping _topping4;
    private Topping _topping5;
    private Topping _topping6;
    private Topping _topping7;
    private Topping _topping8;
    private Topping _topping9;
    public Menu (int menuId)
    {
        _menuId = menuId;

      _pizza1 = new Pizza(1, "Margherita", "Cheese and tomato", 9.99);
      _pizza2 = new Pizza(2, "Lactose free Margherita", "Lactose free Cheese and tomato", 11.99);
      _pizza3 = new Pizza(3, "Pepperoni", "Cheese, tomato and pepperoni", 12.99);
      _pizza4 = new Pizza(4, "Hawaii", "Cheese tomato, pineapples and ham", 13.99);

        _topping1 = new Topping(1, "ExtraCheese", 2.00, false, true);
        _topping2 = new Topping(2, "Sausages", 4.00, true, false);
        _topping3 = new Topping(3, "Shawarma", 4.00, true, false);
        _topping4 = new Topping(4, "ChilliSauce", 3.00, false, false);
        _topping5 = new Topping(5, "Jalapénos", 3.00, false, false);
        _topping6 = new Topping(6, "Lettuce", 1.50, false, false);
        _topping7 = new Topping(7, "Pepperoni", 4.00, true, false);
        _topping8 = new Topping(8, "Ham", 4.00, true, false);
        _topping9 = new Topping(9, "Pineapple", 1.50, false, false);

    }
    public void ShowMenu()
    {
        Console.WriteLine("Menu:");
        Console.WriteLine();
        Console.WriteLine("Pizzas:");
        Console.WriteLine($"1. {_pizza1.Name} - ${_pizza1.price}");
        Console.WriteLine($"2. {_pizza2.Name} - ${_pizza2.price}");
        Console.WriteLine($"3. {_pizza3.Name} - ${_pizza3.price}");
        Console.WriteLine($"4. {_pizza4.Name} - ${_pizza4.price}");
        Console.WriteLine();

        Console.WriteLine("Toppings:");
        Console.WriteLine($"1. {_topping1.toppingName} - ${_topping1.price}");
        Console.WriteLine($"2. {_topping2.toppingName} - ${_topping2.price}");
        Console.WriteLine($"3. {_topping3.toppingName} - ${_topping3.price}");
        Console.WriteLine($"4. {_topping4.toppingName} - ${_topping4.price}");
        Console.WriteLine($"5. {_topping5.toppingName} - ${_topping5.price}");
        Console.WriteLine($"6. {_topping6.toppingName} - ${_topping6.price}");
        Console.WriteLine($"7. {_topping7.toppingName} - ${_topping7.price}");
        Console.WriteLine($"8. {_topping8.toppingName} - ${_topping8.price}");
        Console.WriteLine($"9. {_topping9.toppingName} - ${_topping9.price}");
    }
    public Pizza GetPizza(int choice)
    {
        if (choice == 1) return _pizza1;
        else if (choice == 2) return _pizza2;
        else if (choice == 3) return _pizza3;
        else if (choice == 4) return _pizza4;
        else return null;
    }

    public Topping GetTopping(int choice)
    {
        if (choice == 1) return _topping1;
        else if (choice == 2) return _topping2;
        else if (choice == 3) return _topping3;
        else if (choice == 4) return _topping4;
        else if (choice == 5) return _topping5;
        else if (choice == 6) return _topping6;
        else if (choice == 7) return _topping7;
        else if (choice == 8) return _topping8;
        else if (choice == 9) return _topping9;
        else return null;
    }
}

