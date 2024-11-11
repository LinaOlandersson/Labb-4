namespace Labb_4
{
    internal class MenuItem
    {
        // Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Constructor
        public MenuItem(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        // Method
        public override string ToString()
        {
            return $"{Name} - {Price:C}";
        }
    }
}
