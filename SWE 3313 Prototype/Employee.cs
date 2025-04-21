namespace SWE_3313_Prototype
{
    /// <summary>
    /// An employee, which houses worker information.
    /// </summary>
    internal class Employee : Person
    {
        /// <summary>
        /// The name of their manager.
        /// </summary>
        public string Manager { get; set; }

        /// <summary>
        /// Their title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Their hourly wage.
        /// </summary>
        public double Wage { get; set; }

        /// <summary>
        /// Their login pin.
        /// </summary>
        public string Pin { get; set; }
    }
}
