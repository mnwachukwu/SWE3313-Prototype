namespace SWE_3313_Prototype
{
    internal class Table
    {
        public int Id { get; set; }

        public TableStatus Status { get; set; }

        public List<OrderItem> Order { get; set; } = new();

        public List<OrderItem> SubmittedOrder { get; set; } = new();

        public string Name => $"Table {Id + 1}";
    }
}
