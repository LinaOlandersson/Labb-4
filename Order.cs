namespace Labb_4
{
    internal class Order
    {
        // Fields
        static int orderIdCounter = 1;
        private int _orderId;
        private List<MenuItem> _orderItems;
        private int _tableNumber;

        // Properties
        public int OrderId
        {
            get { return _orderId; }
        }
        public List<MenuItem> OrderItems
        {
            get { return _orderItems; }
        }
        public int TableNumber
        {
            get { return _tableNumber; }
        }

        // Constructor
        public Order(List<MenuItem> orderItems, int tableNumber)
        {
            _orderId = orderIdCounter;
            orderIdCounter++;
            _orderItems = orderItems;
            _tableNumber = tableNumber;
        }

        // Methods
        
        // Prints out the order details 
        public void PrintOrder()
        {
            decimal sum = 0;
            Console.WriteLine($"Order {OrderId}:");
            foreach (var item in OrderItems)
            {
                Console.WriteLine($"1 st {item.Name}");
                sum += item.Price;
            }
            Console.WriteLine($"Summa: {sum}\nTill bord nummer {TableNumber}\n");
        }
        

    }
}
