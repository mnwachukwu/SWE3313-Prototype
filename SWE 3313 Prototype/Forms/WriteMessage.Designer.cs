namespace SWE_3313_Prototype
{
    partial class WriteMessage
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
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(651, 379);
            button4.Name = "button4";
            button4.Size = new Size(96, 23);
            button4.TabIndex = 22;
            button4.Text = "Save as Draft";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(147, 133);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(600, 231);
            textBox1.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 133);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 15;
            label4.Text = "Message:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 102);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 14;
            label3.Text = "Subject:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 73);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 13;
            label2.Text = "To:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 49);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 12;
            label1.Text = "From:";
            // 
            // button3
            // 
            button3.Location = new Point(557, 379);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 23;
            button3.Text = "Send";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(147, 99);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 23);
            textBox2.TabIndex = 24;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(147, 70);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(245, 23);
            textBox3.TabIndex = 25;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(147, 41);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(245, 23);
            textBox4.TabIndex = 26;
            // 
            // WriteMessage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 432);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "WriteMessage";
            Text = "New Message";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}