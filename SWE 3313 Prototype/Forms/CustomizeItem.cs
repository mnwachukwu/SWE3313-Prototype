namespace SWE_3313_Prototype.Forms
{
    /// <summary>
    /// Form that allows for item customization before adding it to an order.
    /// </summary>
    public partial class CustomizeItem : Form
    {
        /// <summary>
        /// The menu item to customize.
        /// </summary>
        private MenuItem item;

        /// <summary>
        /// The order.
        /// </summary>
        private List<OrderItem> order;

        /// <summary>
        /// Ctor, sets up form.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="order"></param>
        internal CustomizeItem(MenuItem item, List<OrderItem> order)
        {
            InitializeComponent();

            this.item = item;
            this.order = order;

            labelItem.Text = item.Name;
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
        /// Add button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            order.Add(new() { MenuItemId = item.Id, SpecialRequests = textBoxNotes.Text });
            Close();
        }
    }
}
