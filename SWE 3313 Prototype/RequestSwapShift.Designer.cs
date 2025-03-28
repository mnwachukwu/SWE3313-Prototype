namespace SWE_3313_Prototype
{
    partial class RequestSwapShift
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
            button4 = new Button();
            button3 = new Button();
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
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(814, 351);
            button4.Name = "button4";
            button4.Size = new Size(58, 22);
            button4.TabIndex = 22;
            button4.Text = "Next >";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(28, 351);
            button3.Name = "button3";
            button3.Size = new Size(58, 22);
            button3.TabIndex = 21;
            button3.Text = "< Prev";
            button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(28, 30);
            label4.Name = "label4";
            label4.Size = new Size(844, 18);
            label4.TabIndex = 20;
            label4.Text = "Week of 3/23/25 - 3/29/25";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Employee, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday });
            dataGridView1.Location = new Point(28, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(844, 297);
            dataGridView1.TabIndex = 19;
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
            // button1
            // 
            button1.Location = new Point(375, 351);
            button1.Name = "button1";
            button1.Size = new Size(134, 52);
            button1.TabIndex = 23;
            button1.Text = "Select Unwanted Shift";
            button1.UseVisualStyleBackColor = true;
            // 
            // RequestSwapShift
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 448);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Name = "RequestSwapShift";
            Text = "RequestSwapShift";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button4;
        private Button button3;
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
        private Button button1;
    }
}