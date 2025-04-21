namespace SWE_3313_Prototype
{
    /// <summary>
    /// Representation of a person.
    /// </summary>
    internal class Person
    {
        /// <summary>
        /// A unique identifier.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The person's name, first and last.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The person's full address.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// The person's contact phone number.
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}
