namespace SWE_3313_Prototype
{
    public partial class LockScreen : Form
    {
        public LockScreen()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Program.NavigateToLogin();
        }
    }
}
