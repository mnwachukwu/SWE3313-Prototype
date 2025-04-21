namespace SWE_3313_Prototype
{
    partial class TrainingEmployer
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
            checkedListBox1 = new CheckedListBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Paul T.", "Jerri P.", "Frankie O. (Manager)", "Tina B." });
            listBox1.Location = new Point(31, 43);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(192, 214);
            listBox1.TabIndex = 1;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Respect in the Workplace (Due: 5/1/25)", "Efficient PoS Use (Due 4/30/25)", "Secure Technology Use (5/30/25)" });
            checkedListBox1.Location = new Point(242, 43);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(255, 220);
            checkedListBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(309, 288);
            button1.Name = "button1";
            button1.Size = new Size(114, 23);
            button1.TabIndex = 3;
            button1.Text = "Assign Training";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(49, 288);
            button2.Name = "button2";
            button2.Size = new Size(150, 23);
            button2.TabIndex = 4;
            button2.Text = "Review Training Progress";
            button2.UseVisualStyleBackColor = true;
            // 
            // TrainingEmployer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 358);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkedListBox1);
            Controls.Add(listBox1);
            Name = "TrainingEmployer";
            Text = "Training (Manager)";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private CheckedListBox checkedListBox1;
        private Button button1;
        private Button button2;
    }
}