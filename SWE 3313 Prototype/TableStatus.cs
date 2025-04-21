namespace SWE_3313_Prototype
{
    /// <summary>
    /// The status for a table.
    /// </summary>
    internal enum TableStatus
    {
        /// <summary>
        /// Ready to use for a customer.
        /// </summary>
        Open,

        /// <summary>
        /// In use by a customer.
        /// </summary>
        Occupied,

        /// <summary>
        /// Needs to be made ready for another customer.
        /// </summary>
        Dirty
    }
}
