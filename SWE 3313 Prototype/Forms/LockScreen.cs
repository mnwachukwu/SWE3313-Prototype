namespace SWE_3313_Prototype
{
    /// <summary>
    /// Lock screen form.
    /// </summary>
    public partial class LockScreen : Form
    {
        /// <summary>
        /// Ctor.
        /// </summary>
        public LockScreen()
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
            Program.NavigateToLogin();
        }
    }
}
