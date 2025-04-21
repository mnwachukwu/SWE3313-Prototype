namespace SWE_3313_Prototype
{
    /// <summary>
    /// Login form.
    /// </summary>
    public partial class Login : Form
    {
        /// <summary>
        /// Ctor.
        /// </summary>
        public Login()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Login button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (IsAccountValid(textBoxEmployeeId.Text, textBoxPin.Text))
            {
                var employee = Program.Employees.First(i => i.Id == textBoxEmployeeId.Text);

                Program.Login(employee);
                Program.NavigateToTables();
            }
            else
            {
                MessageBox.Show("Invalid login attempt.");
            }
        }

        /// <summary>
        /// Checks if the ID and Pin given are a valid combination.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pin"></param>
        /// <returns></returns>
        private bool IsAccountValid(string id, string pin)
        {
            return Program.Employees.Any(i => i.Id == id && i.Pin == pin);
        }
    }
}
