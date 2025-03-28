namespace SWE_3313_Prototype
{
    partial class NewOrder
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
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Foxy Cardboard x1 @4.99ea", "Leaded Telescope x3 @16.09ea", "Tubed Post x1 @40.00ea (ORIG: 59.97)" });
            listBox1.Location = new Point(577, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(211, 289);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(31, 28);
            button1.Name = "button1";
            button1.Size = new Size(118, 54);
            button1.TabIndex = 1;
            button1.Text = "Foxy Cardboard\r\n$4.99";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(186, 28);
            button2.Name = "button2";
            button2.Size = new Size(118, 54);
            button2.TabIndex = 2;
            button2.Text = "Leaded Telescope\r\n$16.09";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(333, 28);
            button3.Name = "button3";
            button3.Size = new Size(118, 54);
            button3.TabIndex = 3;
            button3.Text = "Tubed Post\r\n$59.97";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(31, 116);
            button4.Name = "button4";
            button4.Size = new Size(118, 54);
            button4.TabIndex = 4;
            button4.Text = "Enlongated Beaker\r\n$65.55";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(186, 116);
            button5.Name = "button5";
            button5.Size = new Size(118, 54);
            button5.TabIndex = 5;
            button5.Text = "Refracted Tin\r\n$21.00";
            button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(649, 353);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 6;
            label1.Text = "Subtotal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(731, 353);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 7;
            label2.Text = "$93.26";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(738, 377);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 9;
            label3.Text = "$5.60";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(649, 377);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 8;
            label4.Text = "Tax (6%)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(668, 402);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 10;
            label5.Text = "Total";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(731, 402);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 11;
            label6.Text = "$98.86";
            // 
            // button6
            // 
            button6.Location = new Point(12, 387);
            button6.Name = "button6";
            button6.Size = new Size(109, 46);
            button6.TabIndex = 12;
            button6.Text = "Submit";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(149, 387);
            button7.Name = "button7";
            button7.Size = new Size(109, 46);
            button7.TabIndex = 13;
            button7.Text = "Cancel";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(632, 307);
            button8.Name = "button8";
            button8.Size = new Size(100, 25);
            button8.TabIndex = 14;
            button8.Text = "Remove";
            button8.UseVisualStyleBackColor = true;
            // 
            // NewOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 445);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "NewOrder";
            Text = "Place Order";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}