namespace SWE_3313_Prototype
{
    partial class ConfirmCheckout
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            textBox1 = new TextBox();
            button6 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.MenuText;
            label6.Location = new Point(104, 19);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 27;
            label6.Text = "$98.86";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 19);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 26;
            label5.Text = "Total";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 49);
            label1.Name = "label1";
            label1.Size = new Size(253, 15);
            label1.TabIndex = 28;
            label1.Text = "Thank you for your business. Come back soon!";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(67, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(224, 206);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Leave a tip?";
            // 
            // button1
            // 
            button1.Location = new Point(13, 86);
            button1.Name = "button1";
            button1.Size = new Size(95, 23);
            button1.TabIndex = 30;
            button1.Text = "5% ($4.94)";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(114, 86);
            button2.Name = "button2";
            button2.Size = new Size(95, 23);
            button2.TabIndex = 31;
            button2.Text = "10% ($9.89)";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(13, 125);
            button3.Name = "button3";
            button3.Size = new Size(95, 23);
            button3.TabIndex = 32;
            button3.Text = "15% ($14.82)";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(114, 125);
            button4.Name = "button4";
            button4.Size = new Size(95, 23);
            button4.TabIndex = 33;
            button4.Text = "20% ($19.76)";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(13, 164);
            button5.Name = "button5";
            button5.Size = new Size(95, 23);
            button5.TabIndex = 34;
            button5.Text = "Custom Tip";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(114, 165);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(95, 23);
            textBox1.TabIndex = 30;
            // 
            // button6
            // 
            button6.Location = new Point(63, 47);
            button6.Name = "button6";
            button6.Size = new Size(95, 23);
            button6.TabIndex = 35;
            button6.Text = "No thank you.";
            button6.UseVisualStyleBackColor = true;
            // 
            // ConfirmCheckout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 328);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "ConfirmCheckout";
            Text = "Thank you!";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label1;
        private GroupBox groupBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button6;
        private TextBox textBox1;
        private Button button5;
        private Button button4;
    }
}