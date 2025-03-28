namespace SWE_3313_Prototype
{
    partial class MainMenuEmployer
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
            label1 = new Label();
            label3 = new Label();
            monthCalendar1 = new MonthCalendar();
            label2 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            button4 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox2 = new GroupBox();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            panel1.Location = new Point(340, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(245, 242);
            panel1.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(6, 22);
            button1.Name = "button1";
            button1.Size = new Size(107, 38);
            button1.TabIndex = 5;
            button1.Text = "New Order";
            button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(6, 154);
            button4.Name = "button4";
            button4.Size = new Size(107, 38);
            button4.TabIndex = 8;
            button4.Text = "Check Out";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(6, 66);
            button2.Name = "button2";
            button2.Size = new Size(107, 38);
            button2.TabIndex = 6;
            button2.Text = "Pending Orders";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(6, 110);
            button3.Name = "button3";
            button3.Size = new Size(107, 38);
            button3.TabIndex = 7;
            button3.Text = "Tables";
            button3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button5);
            groupBox2.Location = new Point(12, 320);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(573, 69);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Business Management";
            // 
            // button8
            // 
            button8.Location = new Point(332, 22);
            button8.Name = "button8";
            button8.Size = new Size(126, 38);
            button8.TabIndex = 9;
            button8.Text = "Message Center (2)";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(242, 22);
            button7.Name = "button7";
            button7.Size = new Size(84, 38);
            button7.TabIndex = 8;
            button7.Text = "Inventory";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(119, 22);
            button6.Name = "button6";
            button6.Size = new Size(117, 38);
            button6.TabIndex = 7;
            button6.Text = "Employee Records";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(6, 22);
            button5.Name = "button5";
            button5.Size = new Size(107, 38);
            button5.TabIndex = 6;
            button5.Text = "Master Schedule";
            button5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button3);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(138, 204);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Business Operations";
            // 
            // MainMenuEmployer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 407);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MainMenuEmployer";
            Text = "Main Menu - <USER> (Manager)";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label3;
        private MonthCalendar monthCalendar1;
        private Label label2;
        private Panel panel1;
        private Button button1;
        private Button button4;
        private Button button2;
        private Button button3;
        private GroupBox groupBox2;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private GroupBox groupBox1;
    }
}