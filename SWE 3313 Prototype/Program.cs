using Newtonsoft.Json;

namespace SWE_3313_Prototype
{
    internal static class Program
    {
        private static Random rng = new Random();

        private static Form? currentForm;

        private static Employee? currentEmployee;

        private static int assignedSection;

        public static List<Employee> Employees { get; set; } = new();

        public static List<Order> Orders { get; set; } = new();

        public static List<MenuItem> Menu { get; set; } = new();

        public static List<Table> Tables { get; set; } = new();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Employees = JsonConvert.DeserializeObject<List<Employee>>(File.ReadAllText("Employees.json")) ?? new();
            Menu = JsonConvert.DeserializeObject<List<MenuItem>>(File.ReadAllText("MenuItems.json")) ?? new();
            
            for (var i = 0; i < 30; i++)
            {
                Tables.Add(new() { Id = i });
            }

            currentForm = new LockScreen();
            currentForm.Show();
            Application.Run();
        }

        public static void Exit()
        {
            Application.Exit();
        }

        public static void Login(Employee employee)
        {
            currentEmployee = employee;
            assignedSection = rng.Next(0, 5);
        }

        public static void Logout()
        {
            currentEmployee = null;
        }

        public static void NavigateToLockScreen()
        {
            currentForm?.Close();
            currentForm = new LockScreen();
            currentForm.Show();
        }

        public static void NavigateToLogin()
        {
            currentForm?.Close();
            currentForm = new Login();
            currentForm.Show();
        }

        public static void NavigateToTables()
        {
            if (currentEmployee != null)
            {
                currentForm?.Close();
                currentForm = new Tables(currentEmployee, assignedSection);
                currentForm.Show();
            }
        }
    }
}