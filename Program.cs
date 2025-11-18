
Employee employee1 = new Employee(1, "Lily");
Employee employee2 = new Employee(2, "Julius");


Customer customer1 = new Customer(1,"Leon", false, true);
Customer customer2 = new Customer(2,"Sarah", true, false);
Customer customer3 = new Customer(3, "William", false, false);



Menu menu = new Menu(1);
menu.ShowMenu();

Pizza pizzaA = menu.GetPizza(1);
Pizza pizzaB = menu.GetPizza(2);
Pizza pizzaC = menu.GetPizza(3);
Pizza pizzaD = menu.GetPizza(4);

Topping toppingA = menu.GetTopping(1);
Topping toppingB = menu.GetTopping(2);
Topping toppingC = menu.GetTopping(3);
Topping toppingD = menu.GetTopping(4);
Topping toppingE = menu.GetTopping(5);
Topping toppingF = menu.GetTopping(6);
Topping toppingG = menu.GetTopping(7);
Topping toppingH = menu.GetTopping(8);
Topping toppingI = menu.GetTopping(9);

Order order1 = new Order(1, true, customer1);
order1.AssignEmployee(employee1);

          


order1.AddPizza(pizzaB);
order1.AddTopping(toppingA);
order1.AddTopping(toppingC);
order1.AddTopping(toppingE);

Review leonsReview = new Review(1, 3, "Too few pizzas to choose from, but quite tasty!");
order1.LeaveReview(leonsReview);


Pizza searchedPizza = menu.SearchPizza("Margherita");

if (searchedPizza != null)
{
    Console.WriteLine("Search result: " + searchedPizza.Name + " " + searchedPizza.price + " kr");
}
else
{
    Console.WriteLine("Pizza not found");
}




Order order2 = new Order(2, true, customer2);
order2.AssignEmployee(employee2);




order2.AddPizza(pizzaA);


order2.AddTopping(toppingA);
order2.AddTopping(toppingC);
order2.AddTopping(toppingE);


order2.AddTopping(toppingF);
Review sarahsReview = new Review(2, 3.5, "too few pizzas to choose from, i like the amount of different toppings, however it was quite tasty.");

order2.LeaveReview(sarahsReview);


Order order3 = new Order(3, false, customer2);
order3.AssignEmployee(employee1);
order3.AddPizza(pizzaC);
Review williamsReview = new Review(3, 4.5, "i liked the tasty pizza.");

Console.WriteLine(order1);
Console.WriteLine(order2);
Console.WriteLine(order3);