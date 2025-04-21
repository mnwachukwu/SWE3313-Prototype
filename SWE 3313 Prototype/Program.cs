using Newtonsoft.Json;

namespace SWE_3313_Prototype
{
    internal static class Program
    {
        private static Form currentForm;

        public static List<Employee> Employees { get; set; } = new();

        public static List<Order> Orders { get; set; } = new();

        public static List<MenuItem> Menu { get; set; } = new();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Employees = JsonConvert.DeserializeObject<List<Employee>>(File.ReadAllText("Employees.json"));
            Menu = JsonConvert.DeserializeObject<List<MenuItem>>(File.ReadAllText("MenuItems.json"));
            currentForm = new LockScreen();
            currentForm.Show();
            Application.Run();
        }

        public static void Exit()
        {
            Application.Exit();
        }

        public static void NavigateToLockScreen()
        {
            currentForm.Close();
            currentForm = new Login();
            currentForm.Show();
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