namespace SWE_3313_Prototype
{
    partial class TrainingsEmployee
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
            checkedListBox1 = new CheckedListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Respect in the Workplace (Due: 5/1/25)", "Efficient PoS Use (Due 4/30/25)", "Secure Technology Use (5/30/25)" });
            checkedListBox1.Location = new Point(31, 31);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(255, 148);
            checkedListBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(95, 197);
            button1.Name = "button1";
            button1.Size = new Size(114, 23);
            button1.TabIndex = 1;
            button1.Text = "Start Training";
            button1.UseVisualStyleBackColor = true;
            // 
            // TrainingsEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 256);
            Controls.Add(button1);
            Controls.Add(checkedListBox1);
            Name = "TrainingsEmployee";
            Text = "Training";
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private Button button1;
    }
}