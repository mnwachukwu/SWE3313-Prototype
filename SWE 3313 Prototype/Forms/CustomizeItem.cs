namespace SWE_3313_Prototype.Forms
{
    public partial class CustomizeItem : Form
    {
        private MenuItem item;
        private List<OrderItem> order;

        internal CustomizeItem(MenuItem item, List<OrderItem> order)
        {
            InitializeComponent();

            this.item = item;
            this.order = order;

            labelItem.Text = item.Name;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            order.Add(new() { MenuItemId = item.Id, SpecialRequests = textBoxNotes.Text });
            Close();
        }
    }
}
