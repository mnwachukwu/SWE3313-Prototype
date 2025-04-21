using Newtonsoft.Json;

namespace SWE_3313_Prototype
{
    internal static class Program
    {
        private static Random rng = new Random();

        private static Form? currentForm;

        private static Employee? currentEmployee;

        private static int assignedSection = -1;

        private static Dictionary<Employee, int> employeeAssignedSections = new();

        private static int nowServing = 0;

        public static List<Employee> Employees { get; set; } = new();

        public static Queue<OrderItem> KitchenOrders { get; set; } = new();

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

        public static void Logout()
        {
            currentEmployee = null;
            assignedSection = -1;
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