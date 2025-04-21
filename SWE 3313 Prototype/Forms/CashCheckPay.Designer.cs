namespace SWE_3313_Prototype
{
    partial class CashCheckPay
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
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 71);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 0;
            label1.Text = "Amount Tendered:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "100.00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 114);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 2;
            label2.Text = "Amount Remaining:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 30);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 3;
            label3.Text = "Total:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 158);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 4;
            label4.Text = "Change:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(150, 114);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 6;
            label6.Text = "$0.00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(150, 158);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 7;
            label7.Text = "$1.14";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.WindowText;
            label8.Location = new Point(150, 30);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 26;
            label8.Text = "$98.86";
            // 
            // button1
            // 
            button1.Location = new Point(101, 198);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 27;
            button1.Text = "Tender";
            button1.UseVisualStyleBackColor = true;
            // 
            // CashCheckPay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 249);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "CashCheckPay";
            Text = "Pay With Cash/Check";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
    }
}