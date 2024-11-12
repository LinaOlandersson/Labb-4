namespace Labb_4
{
    internal class Restaurant
    {
        // Properties
        public List<MenuItem> Menu { get; set; }
        public Queue<Order> Orders { get; set; }

        // Constructor
        public Restaurant()
        {
            Menu = new List<MenuItem>();
            Orders = new Queue<Order>();
        }

        // Methods

        // Adds an item to the menu list and prints it to the console
        public void AddToMenu(MenuItem menuItem)
        {
            Menu.Add(menuItem);
            Console.WriteLine($"{menuItem.Name} har lagts till i menyn.");
        }
        // Prints out all items on the menu
        public void ShowMenu()
        {
            Console.WriteLine("Meny:");
            foreach (var item in Menu)
            {
                Console.WriteLine(item.Id + ". " + item.ToString());
            }
        }
        // Puts a new order to the order queue and prints it to the console
        public void CreateOrder(Order order)
        {
            Orders.Enqueue(order);
            Console.WriteLine($"Beställning nr {order.OrderId} har lagts till.");
        }
        // Removes the first order in the order queue and prints it to the console
        public void HandleOrder()
        {
            if (Orders.TryDequeue(out Order removed))
            {
                Console.WriteLine($"Order {removed.OrderId} är färdig.");
            }
            else
            {
                Console.WriteLine("Det finns inga väntande ordrar att hantera just nu.");
            }
        }
        // Prints out all orders remaining
        public void ShowOrders()
        {
            Console.WriteLine("Aktuella beställningar:");
            foreach (var order in Orders)
            {
                order.PrintOrder();
            }
        }
        // Prints out the next order in line
        public void ShowNextorder()
        {
            if (Orders.TryPeek(out Order nextOrder))
            {
                Console.WriteLine($"Nästa order i kön:");
                nextOrder.PrintOrder();
            }
            else
            {
                Console.WriteLine("Det finns inga väntande ordrar i kön just nu.");
            }
        }
        // Prints out the number of orders in line
        public void ShowOrderCount()
        {
            if (Orders.Count == 0)
            {
                Console.WriteLine("Det finns inga väntande ordrar i kön just nu.");
            }
            else if (Orders.Count == 1)
            {
                Console.WriteLine("Det är 1 order i kön.");
            }
            else
            {
                Console.WriteLine($"Det är {Orders.Count} ordrar i kön.\n");
            }
        }
    }
}
