namespace SWE_3313_Prototype
{
    internal class OrderItem
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string MenuItemId { get; set; } = string.Empty;

        public string SpecialRequests { get; set; } = string.Empty;
    }
}
