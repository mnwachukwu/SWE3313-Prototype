namespace SWE_3313_Prototype
{
    /// <summary>
    /// Represents a menu item.
    /// </summary>
    internal class MenuItem
    {
        /// <summary>
        /// The menu item unique identifier.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The menu item's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A description of the menu item.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The amount the menu item is sold for.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// The cost of the menu item.
        /// </summary>
        public double Cost { get; set; }

        /// <summary>
        /// The category the menu item belongs to.
        /// </summary>
        public Categories Category { get; set; }
    }
}
