namespace Labb_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating the restaurant object
            Restaurant r1 = new Restaurant();

            // Adding four items to the menu
            r1.AddToMenu(new MenuItem(1, "Lasagne", 129.00m));
            r1.AddToMenu(new MenuItem(2, "Kålpudding", 149.00m));
            r1.AddToMenu(new MenuItem(3, "Pumpasoppa", 89.00m));
            r1.AddToMenu(new MenuItem(4, "Slumrande prinskorv", 109.00m));
            Console.WriteLine("-------------------------------");

            // Printing the menu
            r1.ShowMenu();
            Console.WriteLine("-------------------------------");

            // Creating three orders
            r1.CreateOrder(new Order(new List<MenuItem> { r1.Menu[0], r1.Menu[3] }, 23));
            r1.CreateOrder(new Order(new List<MenuItem> { r1.Menu[1], r1.Menu[1] }, 12));
            r1.CreateOrder(new Order(new List<MenuItem> { r1.Menu[2], r1.Menu[3] }, 4));
            Console.WriteLine("-------------------------------");

            // Printing the orders
            r1.ShowOrders();
            Console.WriteLine("-------------------------------");

            // Printing the number of orders
            r1.ShowOrderCount();

            // Printing next order in line
            r1.ShowNextorder();

            // Handling an order 
            r1.HandleOrder();

            // Printing the number of orders
            r1.ShowOrderCount();
            Console.WriteLine("-------------------------------");

            // Creating a new order
            r1.CreateOrder(new Order(new List<MenuItem> { r1.Menu[0], r1.Menu[1], r1.Menu[2] }, 5));

            // Printing the number of orders
            r1.ShowOrderCount();

            // Handling two orders
            r1.HandleOrder();
            r1.HandleOrder();

            // Printing the number of orders
            r1.ShowOrderCount();
            Console.WriteLine("-------------------------------");

            // Printing next order in line
            r1.ShowNextorder();

            // Handling an order
            r1.HandleOrder();

            // Printing the number of orders
            r1.ShowOrderCount();
        }
    }
}
