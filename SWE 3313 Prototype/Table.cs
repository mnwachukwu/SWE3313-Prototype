namespace SWE_3313_Prototype
{
    /// <summary>
    /// Representation of a physical table.
    /// </summary>
    internal class Table
    {
        /// <summary>
        /// The unique identifier of the table.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The status of the table.
        /// </summary>
        public TableStatus Status { get; set; }

        /// <summary>
        /// A list of items ordered by the table.
        /// </summary>
        public List<OrderItem> Order { get; set; } = new();
        
        /// <summary>
        /// A list of items ordered by the table that has been submitted to the kitchen.
        /// </summary>
        public List<OrderItem> SubmittedOrder { get; set; } = new();

        /// <summary>
        /// The formal name of the table, made by appending its unique identifier plus 1 to "Table".
        /// </summary>
        public string Name => $"Table {Id + 1}";
    }
}
