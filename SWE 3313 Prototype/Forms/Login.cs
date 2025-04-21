namespace SWE_3313_Prototype
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (IsAccountValid(textBoxEmployeeId.Text, textBoxPin.Text))
            {
                Program.NavigateToTables();
            }
        }

        private bool IsAccountValid(string id, string pin)
        {
            return Program.Employees.Any(i => i.Id == id && i.Pin == pin);
        }
    }
}
