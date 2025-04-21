using Newtonsoft.Json;

namespace SWE_3313_Prototype
{
    /// <summary>
    /// The main program.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// A random number generator.
        /// </summary>
        private static Random rng = new Random();

        /// <summary>
        /// The currently active form.
        /// </summary>
        private static Form? currentForm;

        /// <summary>
        /// The currently loged in employee.
        /// </summary>
        private static Employee? currentEmployee;

        /// <summary>
        /// The currently logged in employee's assigned section.
        /// </summary>
        private static int assignedSection = -1;

        /// <summary>
        /// A history of employee assigned sections to be remembered for logins beyond the first.
        /// </summary>
        private static Dictionary<Employee, int> employeeAssignedSections = new();

        /// <summary>
        /// A number to track the number of orders sent to the kitchen.
        /// </summary>
        private static int nowServing = 0;

        /// <summary>
        /// A list of all employees, loaded from "Employees.json".
        /// </summary>
        public static List<Employee> Employees { get; set; } = new();

        /// <summary>
        /// A list of all order items that have been sent to the kitchen.
        /// </summary>
        public static Queue<OrderItem> KitchenOrders { get; set; } = new();

        /// <summary>
        /// A list of all menu items available for customers, loaded from "MenuItems.json".
        /// </summary>
        public static List<MenuItem> Menu { get; set; } = new();

        /// <summary>
        /// A list of all tables for tracking. Initialized in Main().
        /// </summary>
        public static List<Table> Tables { get; set; } = new();

        /// <summary>
        ///  The main entry point for the application. This handles setting up the program for first run.
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

        /// <summary>
        /// A method used to stop the application from running.
        /// </summary>
        public static void Exit()
        {
            Application.Exit();
        }

        /// <summary>
        /// Logs a user in.
        /// </summary>
        /// <param name="employee"></param>
        public static void Login(Employee employee)
        {
            currentEmployee = employee;
            
            if (employeeAssignedSections.ContainsKey(employee))
            {
                assignedSection = employeeAssignedSections[employee];
            }
            else
            {
                assignedSection = rng.Next(0, 5);
                employeeAssignedSections.Add(employee, assignedSection);
            }
        }

        /// <summary>
        /// Logs a user out.
        /// </summary>
        public static void Logout()
        {
            currentEmployee = null;
            assignedSection = -1;
        }

        /// <summary>
        /// Navigates the program to the lock screen.
        /// </summary>
        public static void NavigateToLockScreen()
        {
            currentForm?.Close();
            currentForm = new LockScreen();
            currentForm.Show();
        }

        /// <summary>
        /// Navigates the program to the login screen.
        /// </summary>
        public static void NavigateToLogin()
        {
            currentForm?.Close();
            currentForm = new Login();
            currentForm.Show();
        }

        /// <summary>
        /// Navigates the program to the tables screen.
        /// </summary>
        public static void NavigateToTables()
        {
            if (currentEmployee != null)
            {
                currentForm?.Close();
                currentForm = new Tables(currentEmployee, assignedSection);
                currentForm.Show();
            }
        }

        /// <summary>
        /// Submits a list of order items as a single order to the kitchen.
        /// </summary>
        /// <param name="submittedItems"></param>
        public static void SubmitToKitchenQueue(List<OrderItem> submittedItems)
        {
            nowServing++;
            Console.WriteLine($"Order #{nowServing} received:");

            foreach (var item in submittedItems)
            {
                var menuItem = Menu.FirstOrDefault(i => i.Id == item.MenuItemId);

                KitchenOrders.Enqueue(item);

                Console.WriteLine($"- {menuItem.Name}");

                if (!string.IsNullOrEmpty(item.SpecialRequests))
                {
                    Console.WriteLine($"    - Special request: {item.SpecialRequests}");
                }
            }
        }
    }
}