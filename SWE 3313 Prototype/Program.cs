namespace SWE_3313_Prototype
{
    internal static class Program
    {
        private static Form currentForm;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            currentForm = new LockScreen();
            currentForm.Show();
            Application.Run();
        }

        public static void Exit()
        {
            Application.Exit();
        }

        public static void NavigateToLogin()
        {
            currentForm.Close();
            currentForm = new Login();
            currentForm.Show();
        }

        public static void NavigateToTables()
        {

        }
    }
}