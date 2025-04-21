namespace SWE_3313_Prototype
{
    internal class Order
    {
        public string Id { get; set; }

        public List<OrderItem> Items { get; set; } = new();
    }
}
