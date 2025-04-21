using System.Data;

namespace SWE_3313_Prototype.Forms
{
    /// <summary>
    /// Form used to add items to an order.
    /// </summary>
    public partial class AddItem : Form
    {
        /// <summary>
        /// The order.
        /// </summary>
        private List<OrderItem> order = new();
        
        /// <summary>
        /// The buttons that represent menu items to add.
        /// </summary>
        private List<Control> itemButtons;
        
        /// <summary>
        /// The menu items.
        /// </summary>
        List<MenuItem> items = new();

        /// <summary>
        /// Ctor, sets up form.
        /// </summary>
        /// <param name="order"></param>
        internal AddItem(List<OrderItem> order)
        {
            InitializeComponent();

            itemButtons = new()
            {
                buttonItem1,
                buttonItem2,
                buttonItem3,
                buttonItem4
            };

            for (var i = 0; i < itemButtons.Count; i++) 
            {
                itemButtons[i].Click += buttonItem_Click;
                itemButtons[i].Tag = i;
            }

            this.order = order;
        }

        /// <summary>
        /// Loads items, depending on category.
        /// </summary>
        /// <param name="category"></param>
        private void LoadItems(Categories category)
        {
            items = Program.Menu.Where(i => i.Category == category).ToList();

            for (var i = 0; i < itemButtons.Count; i++)
            {
                itemButtons[i].Text = $"{items[i].Name}{Environment.NewLine}{items[i].Price:$0.00}";
            }
        }

        /// <summary>
        /// Appetizer button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAppetizer_Click(object sender, EventArgs e)
        {
            LoadItems(Categories.Appetizer);
            panelItems.Visible = true;
        }

        /// <summary>
        /// Drinks button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDrinks_Click(object sender, EventArgs e)
        {
            LoadItems(Categories.Drinks);
            panelItems.Visible = true;
        }

        /// <summary>
        /// Main Course button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMain_Click(object sender, EventArgs e)
        {
            LoadItems(Categories.MainCourse);
            panelItems.Visible = true;
        }

        /// <summary>
        /// Vegetarian button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonVegetarian_Click(object sender, EventArgs e)
        {
            LoadItems(Categories.Vegetarian);
            panelItems.Visible = true;
        }

        /// <summary>
        /// Dessert button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDessert_Click(object sender, EventArgs e)
        {
            LoadItems(Categories.Dessert);
            panelItems.Visible = true;
        }

        /// <summary>
        /// Logout button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Program.Logout();
            Program.NavigateToLockScreen();
        }
        
        /// <summary>
        /// Back button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Add item button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonItem_Click(object sender, EventArgs e)
        {
            var selectedItem = (int)((Control)sender).Tag;
            var customize = new CustomizeItem(items[selectedItem], order);

            customize.ShowDialog();
            Close();
        }
    }
}
