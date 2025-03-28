namespace SWE_3313_Prototype
{
    partial class Checkout
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
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            listBox1 = new ListBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Green;
            label6.Location = new Point(164, 373);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 25;
            label6.Text = "$98.86";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(101, 373);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 24;
            label5.Text = "Total";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(171, 348);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 23;
            label3.Text = "$5.60";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 348);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 22;
            label4.Text = "Tax (6%)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(164, 324);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 21;
            label2.Text = "$93.26";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 324);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 20;
            label1.Text = "Subtotal";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Foxy Cardboard x1 @4.99ea", "Leaded Telescope x3 @16.09ea", "Tubed Post x1 @40.00ea (ORIG: 59.97)" });
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(211, 289);
            listBox1.TabIndex = 19;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(241, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(308, 151);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Payment";
            // 
            // button1
            // 
            button1.Location = new Point(15, 22);
            button1.Name = "button1";
            button1.Size = new Size(74, 28);
            button1.TabIndex = 0;
            button1.Text = "Cash";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(15, 56);
            button2.Name = "button2";
            button2.Size = new Size(74, 28);
            button2.TabIndex = 1;
            button2.Text = "Mastercard";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(95, 56);
            button3.Name = "button3";
            button3.Size = new Size(74, 28);
            button3.TabIndex = 2;
            button3.Text = "Visa";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(175, 56);
            button4.Name = "button4";
            button4.Size = new Size(116, 28);
            button4.TabIndex = 3;
            button4.Text = "American Express";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(95, 22);
            button5.Name = "button5";
            button5.Size = new Size(74, 28);
            button5.TabIndex = 4;
            button5.Text = "Check";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(15, 105);
            button6.Name = "button6";
            button6.Size = new Size(110, 28);
            button6.TabIndex = 5;
            button6.Text = "Gift Certificate";
            button6.UseVisualStyleBackColor = true;
            // 
            // Checkout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 417);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Checkout";
            Text = "Checkout";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private ListBox listBox1;
        private GroupBox groupBox1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}