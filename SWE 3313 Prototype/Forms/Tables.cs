﻿using SWE_3313_Prototype.Forms;

namespace SWE_3313_Prototype
{
    /// <summary>
    /// Tables form, which handles the view of all tables.
    /// </summary>
    public partial class Tables : Form
    {
        /// <summary>
        /// The logged in employee.
        /// </summary>
        private Employee employee;

        /// <summary>
        /// The employee's assigned section.
        /// </summary>
        private int assignedSection;

        /// <summary>
        /// The list of buttons for the form that represent tables.
        /// </summary>
        public List<Control> TableButtons { get; set; }

        /// <summary>
        /// The list of buttons that are grouped by section.
        /// </summary>
        public List<Control>[] SectionButtons { get; set; }

        /// <summary>
        /// Ctor, sets up Tables form.
        /// </summary>
        /// <param name="loggedInEmployee"></param>
        /// <param name="section"></param>
        internal Tables(Employee loggedInEmployee, int section)
        {
            InitializeComponent();

            TableButtons = new()
            {
                button1,
                button2,
                button3,
                button4,
                button5,
                button6,
                button7,
                button8,
                button9,
                button10,
                button11,
                button12,
                button13,
                button14,
                button15,
                button16,
                button17,
                button18,
                button19,
                button20,
                button21,
                button22,
                button23,
                button24,
                button25,
                button26,
                button27,
                button28,
                button29,
                button30
            };

            for (var i = 0; i < TableButtons.Count; i++)
            {
                UpdateTableButton(TableButtons[i], Program.Tables[i]);
                TableButtons[i].Tag = i;
                TableButtons[i].Click += Button_Click;
            }

            employee = loggedInEmployee;
            assignedSection = section;
            labelName.Text = $"Welcome, {employee.Name} (Section: {assignedSection + 1})";

            SectionButtons = new List<Control>[5];

            SectionButtons[0] = new()
            {
                button1,
                button2,
                button3,
                button4,
                button5,
                button6
            };

            SectionButtons[1] = new()
            {
                button7,
                button8,
                button9,
                button10,
                button11,
                button12
            };

            SectionButtons[2] = new()
            {
                button13,
                button14,
                button15,
                button16,
                button17,
                button18
            };

            SectionButtons[3] = new()
            {
                button19,
                button20,
                button21,
                button22,
                button23,
                button24
            };

            SectionButtons[4] = new()
            {
                button25,
                button26,
                button27,
                button28,
                button29,
                button30
            };

            for (var i = 0; i < SectionButtons.Count(); i++)
            {
                if (assignedSection != i)
                {
                    foreach (var control in SectionButtons[i])
                    {
                        control.Enabled = false;
                    }
                }
            }
        }

        /// <summary>
        /// Updates the given button with the given table's information.
        /// </summary>
        /// <param name="button"></param>
        /// <param name="table"></param>
        private void UpdateTableButton(Control button, Table table)
        {
            button.Text = $"{table.Name}{Environment.NewLine}" +
                $"[{table.Status}]";

            switch (table.Status)
            {
                case TableStatus.Open:
                    button.BackColor = Color.LightSeaGreen;
                    break;
                case TableStatus.Occupied:
                    button.BackColor = Color.Yellow;
                    break;
                case TableStatus.Dirty:
                    button.BackColor = Color.IndianRed;
                    break;
            }
        }

        /// <summary>
        /// Tables button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, EventArgs e)
        {
            var control = (Control)sender;
            var table = Program.Tables[(int)control.Tag];
            var tableForm = new TableForm(table);

            tableForm.ShowDialog();
            UpdateTableButton(control, table);
        }

        /// <summary>
        /// Log out button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Program.Logout();
            Program.NavigateToLockScreen();
        }
    }
}
