namespace SWE_3313_Prototype
{
    partial class CreateSchedule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label4 = new Label();
            dataGridView1 = new DataGridView();
            Employee = new DataGridViewTextBoxColumn();
            Sunday = new DataGridViewTextBoxColumn();
            Monday = new DataGridViewTextBoxColumn();
            Tuesday = new DataGridViewTextBoxColumn();
            Wednesday = new DataGridViewTextBoxColumn();
            Thursday = new DataGridViewTextBoxColumn();
            Friday = new DataGridViewTextBoxColumn();
            Saturday = new DataGridViewTextBoxColumn();
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(32, 36);
            label4.Name = "label4";
            label4.Size = new Size(844, 18);
            label4.TabIndex = 22;
            label4.Text = "Week of 3/30/25 - 4/5/25";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Employee, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday });
            dataGridView1.Location = new Point(32, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(844, 297);
            dataGridView1.TabIndex = 21;
            // 
            // Employee
            // 
            Employee.HeaderText = "";
            Employee.Name = "Employee";
            // 
            // Sunday
            // 
            Sunday.HeaderText = "Sunday";
            Sunday.Name = "Sunday";
            // 
            // Monday
            // 
            Monday.HeaderText = "Monday";
            Monday.Name = "Monday";
            // 
            // Tuesday
            // 
            Tuesday.HeaderText = "Tuesday";
            Tuesday.Name = "Tuesday";
            // 
            // Wednesday
            // 
            Wednesday.HeaderText = "Wednesday";
            Wednesday.Name = "Wednesday";
            // 
            // Thursday
            // 
            Thursday.HeaderText = "Thursday";
            Thursday.Name = "Thursday";
            // 
            // Friday
            // 
            Friday.HeaderText = "Friday";
            Friday.Name = "Friday";
            // 
            // Saturday
            // 
            Saturday.HeaderText = "Saturday";
            Saturday.Name = "Saturday";
            // 
            // button2
            // 
            button2.Location = new Point(236, 408);
            button2.Name = "button2";
            button2.Size = new Size(121, 49);
            button2.TabIndex = 24;
            button2.Text = "Set Schedule";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(726, 357);
            button3.Name = "button3";
            button3.Size = new Size(150, 23);
            button3.TabIndex = 25;
            button3.Text = "View Time Off Requests";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(380, 408);
            button1.Name = "button1";
            button1.Size = new Size(121, 49);
            button1.TabIndex = 26;
            button1.Text = "Clear Schedule";
            button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(518, 408);
            button4.Name = "button4";
            button4.Size = new Size(121, 49);
            button4.TabIndex = 27;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = true;
            // 
            // CreateSchedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 486);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Name = "CreateSchedule";
            Text = "Create Schedule";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Employee;
        private DataGridViewTextBoxColumn Sunday;
        private DataGridViewTextBoxColumn Monday;
        private DataGridViewTextBoxColumn Tuesday;
        private DataGridViewTextBoxColumn Wednesday;
        private DataGridViewTextBoxColumn Thursday;
        private DataGridViewTextBoxColumn Friday;
        private DataGridViewTextBoxColumn Saturday;
        private Button button2;
        private Button button3;
        private Button button1;
        private Button button4;
    }
}