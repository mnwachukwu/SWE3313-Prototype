using System.Data;

namespace SWE_3313_Prototype.Forms
{
    internal partial class TableForm : Form
    {
        private Table table;

        public TableForm(Table table)
        {
            InitializeComponent();

            this.table = table;
            labelName.Text = $"{table.Name}";
            comboBoxStatus.SelectedIndex = (int)table.Status;
            UpdateTab();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Program.Logout();
            Program.NavigateToLockScreen();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSetStatus_Click(object sender, EventArgs e)
        {
            table.Status = (TableStatus)comboBoxStatus.SelectedIndex;
        }

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

        private void buttonAddItems_Click(object sender, EventArgs e)
        {
            var addItemForm = new AddItem(table.Order);

            addItemForm.ShowDialog();
            UpdateTab();
        }

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

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            table.SubmittedOrder.AddRange(table.Order);
            Program.SubmitToKitchenQueue(table.Order);
            table.Order.Clear();
            UpdateTab();
        }

        private void buttonRemoveOrder_Click(object sender, EventArgs e)
        {
            if (listBoxOrderItems.SelectedIndex > -1)
            {
                table.Order.RemoveAt(listBoxOrderItems.SelectedIndex);
            }
            UpdateTab();
        }

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
