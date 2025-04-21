namespace SWE_3313_Prototype
{
    /// <summary>
    /// Representation of a line item of an order.
    /// </summary>
    internal class OrderItem
    {
        /// <summary>
        /// The unique identifier of the line item.
        /// </summary>
        public string Id { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// The unique identifier of the menu item this line item represents.
        /// </summary>
        public string MenuItemId { get; set; } = string.Empty;

        /// <summary>
        /// A free text entry field of special requests to send to the kitchen.
        /// </summary>
        public string SpecialRequests { get; set; } = string.Empty;
    }
}
