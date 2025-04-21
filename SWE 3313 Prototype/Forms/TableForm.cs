using System.Data;

namespace SWE_3313_Prototype.Forms
{
    /// <summary>
    /// Table form.
    /// </summary>
    internal partial class TableForm : Form
    {
        /// <summary>
        /// The table.
        /// </summary>
        private Table table;

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="table"></param>
        public TableForm(Table table)
        {
            InitializeComponent();

            this.table = table;
            labelName.Text = $"{table.Name}";
            comboBoxStatus.SelectedIndex = (int)table.Status;
            UpdateTab();
        }

        /// <summary>
        /// Logout button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogOut_Click(object sender, EventArgs e)
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
        /// Set status button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetStatus_Click(object sender, EventArgs e)
        {
            table.Status = (TableStatus)comboBoxStatus.SelectedIndex;
        }

        /// <summary>
        /// Close tab button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCloseTab_Click(object sender, EventArgs e)
        {
            var orderSum = table.Order.Select(i => Program.Menu.FirstOrDefault(j => j.Id == i.MenuItemId)).Sum(i => i?.Price);
            var submittedOrderSum = table.SubmittedOrder.Select(i => Program.Menu.FirstOrDefault(j => j.Id == i.MenuItemId)).Sum(i => i?.Price);
            var sum = orderSum + submittedOrderSum;

            if (sum > 0)
            {
                MessageBox.Show($"Ready to bill for {sum:$0.00}!");
            }
            else
            {
                MessageBox.Show("No tab, can't bill!");
            }
        }

        /// <summary>
        /// Add items button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddItems_Click(object sender, EventArgs e)
        {
            var addItemForm = new AddItem(table.Order);

            addItemForm.ShowDialog();
            UpdateTab();
        }

        /// <summary>
        /// Updates the orders and tab amount based on items added to the order/sent to the kitchen.
        /// </summary>
        private void UpdateTab()
        {
            listBoxOrderItems.Items.Clear();
            listBoxSubmittedItems.Items.Clear();

            foreach (var item in table.Order)
            {
                var menuItem = Program.Menu.FirstOrDefault(i => i.Id == item.MenuItemId);

                listBoxOrderItems.Items.Add($"{menuItem?.Name} ({menuItem?.Price:$0.00})");
            }

            foreach (var item in table.SubmittedOrder)
            {
                var menuItem = Program.Menu.FirstOrDefault(i => i.Id == item.MenuItemId);

                listBoxSubmittedItems.Items.Add($"{menuItem?.Name} ({menuItem?.Price:$0.00})");
            }

            var orderSum = table.Order.Select(i => Program.Menu.FirstOrDefault(j => j.Id == i.MenuItemId)).Sum(i => i?.Price);
            var submittedOrderSum = table.SubmittedOrder.Select(i => Program.Menu.FirstOrDefault(j => j.Id == i.MenuItemId)).Sum(i => i?.Price);
            var sum = orderSum + submittedOrderSum;

            labelTotal.Text = $"{sum:$0.00}";
        }

        /// <summary>
        /// Submit button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            table.SubmittedOrder.AddRange(table.Order);
            Program.SubmitToKitchenQueue(table.Order);
            table.Order.Clear();
            UpdateTab();
        }

        /// <summary>
        /// Remove item from order button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemoveOrder_Click(object sender, EventArgs e)
        {
            if (listBoxOrderItems.SelectedIndex > -1)
            {
                table.Order.RemoveAt(listBoxOrderItems.SelectedIndex);
            }
            UpdateTab();
        }

        /// <summary>
        /// Remove item from submitted order button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemoveSubmittedOrder_Click(object sender, EventArgs e)
        {
            if (listBoxSubmittedItems.SelectedIndex > -1)
            {
                table.SubmittedOrder.RemoveAt(listBoxSubmittedItems.SelectedIndex);
            }
            UpdateTab();
        }
    }
}
