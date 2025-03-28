namespace SWE_3313_Prototype
{
    partial class ScheduleEmployer
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
            button7 = new Button();
            button5 = new Button();
            groupBox2 = new GroupBox();
            button6 = new Button();
            button4 = new Button();
            button3 = new Button();
            label4 = new Label();
            button2 = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            Saturday = new DataGridViewTextBoxColumn();
            Friday = new DataGridViewTextBoxColumn();
            Thursday = new DataGridViewTextBoxColumn();
            Wednesday = new DataGridViewTextBoxColumn();
            Tuesday = new DataGridViewTextBoxColumn();
            Monday = new DataGridViewTextBoxColumn();
            Sunday = new DataGridViewTextBoxColumn();
            Employee = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label3 = new Label();
            monthCalendar1 = new MonthCalendar();
            label2 = new Label();
            panel1 = new Panel();
            button8 = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button7
            // 
            button7.Location = new Point(244, 22);
            button7.Name = "button7";
            button7.Size = new Size(106, 40);
            button7.TabIndex = 10;
            button7.Text = "Clock Out";
            button7.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(145, 22);
            button5.Name = "button5";
            button5.Size = new Size(120, 40);
            button5.TabIndex = 9;
            button5.Text = "Create Schedule";
            button5.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button6);
            groupBox2.Location = new Point(398, 400);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(284, 79);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Schedule Operations";
            // 
            // button6
            // 
            button6.Location = new Point(6, 22);
            button6.Name = "button6";
            button6.Size = new Size(133, 40);
            button6.TabIndex = 8;
            button6.Text = "Time Off Requests (2)";
            button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(818, 344);
            button4.Name = "button4";
            button4.Size = new Size(58, 22);
            button4.TabIndex = 17;
            button4.Text = "Next >";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(32, 344);
            button3.Name = "button3";
            button3.Size = new Size(58, 22);
            button3.TabIndex = 16;
            button3.Text = "< Prev";
            button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(32, 23);
            label4.Name = "label4";
            label4.Size = new Size(844, 18);
            label4.TabIndex = 15;
            label4.Text = "Week of 3/23/25 - 3/29/25";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Location = new Point(118, 22);
            button2.Name = "button2";
            button2.Size = new Size(120, 40);
            button2.TabIndex = 9;
            button2.Text = "Clock Out Break";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(6, 22);
            button1.Name = "button1";
            button1.Size = new Size(106, 40);
            button1.TabIndex = 8;
            button1.Text = "Clock In";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(32, 400);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 79);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Clock In/Out";
            // 
            // Saturday
            // 
            Saturday.HeaderText = "Saturday";
            Saturday.Name = "Saturday";
            // 
            // Friday
            // 
            Friday.HeaderText = "Friday";
            Friday.Name = "Friday";
            // 
            // Thursday
            // 
            Thursday.HeaderText = "Thursday";
            Thursday.Name = "Thursday";
            // 
            // Wednesday
            // 
            Wednesday.HeaderText = "Wednesday";
            Wednesday.Name = "Wednesday";
            // 
            // Tuesday
            // 
            Tuesday.HeaderText = "Tuesday";
            Tuesday.Name = "Tuesday";
            // 
            // Monday
            // 
            Monday.HeaderText = "Monday";
            Monday.Name = "Monday";
            // 
            // Sunday
            // 
            Sunday.HeaderText = "Sunday";
            Sunday.Name = "Sunday";
            // 
            // Employee
            // 
            Employee.HeaderText = "";
            Employee.Name = "Employee";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Employee, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday });
            dataGridView1.Location = new Point(32, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(844, 297);
            dataGridView1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 11);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 0;
            label1.Text = "Welcome, <USER>!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(88, 47);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 3;
            label3.Text = "16:19:47";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(9, 71);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 47);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 2;
            label2.Text = "Current Time:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(monthCalendar1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(913, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(245, 242);
            panel1.TabIndex = 12;
            // 
            // button8
            // 
            button8.Location = new Point(387, 344);
            button8.Name = "button8";
            button8.Size = new Size(108, 25);
            button8.TabIndex = 10;
            button8.Text = "Adjust Schedule";
            button8.UseVisualStyleBackColor = true;
            // 
            // ScheduleEmployer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 510);
            Controls.Add(button8);
            Controls.Add(groupBox2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "ScheduleEmployer";
            Text = "Schedule (Manager)";
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button7;
        private Button button5;
        private GroupBox groupBox2;
        private Button button6;
        private Button button4;
        private Button button3;
        private Label label4;
        private Button button2;
        private Button button1;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn Saturday;
        private DataGridViewTextBoxColumn Friday;
        private DataGridViewTextBoxColumn Thursday;
        private DataGridViewTextBoxColumn Wednesday;
        private DataGridViewTextBoxColumn Tuesday;
        private DataGridViewTextBoxColumn Monday;
        private DataGridViewTextBoxColumn Sunday;
        private DataGridViewTextBoxColumn Employee;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label3;
        private MonthCalendar monthCalendar1;
        private Label label2;
        private Panel panel1;
        private Button button8;
    }
}