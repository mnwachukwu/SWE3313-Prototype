using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWE_3313_Prototype.Forms
{
    public partial class AddItem : Form
    {
        private List<OrderItem> order = new();
        private List<Control> itemButtons;
        List<MenuItem> items = new();

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

        private void LoadItems(Categories category)
        {
            items = Program.Menu.Where(i => i.Category == category).ToList();

            for (var i = 0; i < itemButtons.Count; i++)
            {
                itemButtons[i].Text = $"{items[i].Name}{Environment.NewLine}{items[i].Price:$0.00}";
            }
        }

        private void buttonAppetizer_Click(object sender, EventArgs e)
        {
            LoadItems(Categories.Appetizer);
            panelItems.Visible = true;
        }

        private void buttonDrinks_Click(object sender, EventArgs e)
        {
            LoadItems(Categories.Drinks);
            panelItems.Visible = true;
        }

        private void buttonMain_Click(object sender, EventArgs e)
        {
            LoadItems(Categories.MainCourse);
            panelItems.Visible = true;
        }

        private void buttonVegetarian_Click(object sender, EventArgs e)
        {
            LoadItems(Categories.Vegetarian);
            panelItems.Visible = true;
        }

        private void buttonDessert_Click(object sender, EventArgs e)
        {
            LoadItems(Categories.Dessert);
            panelItems.Visible = true;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Program.Logout();
            Program.NavigateToLockScreen();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonItem_Click(object sender, EventArgs e)
        {
            var selectedItem = (int)((Control)sender).Tag;
            var customize = new CustomizeItem(items[selectedItem], order);

            customize.ShowDialog();
            Close();
        }
    }
}
