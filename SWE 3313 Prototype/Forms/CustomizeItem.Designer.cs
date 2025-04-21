namespace SWE_3313_Prototype.Forms
{
    partial class CustomizeItem
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
            labelItem = new Label();
            textBoxNotes = new TextBox();
            label2 = new Label();
            buttonBack = new Button();
            buttonAdd = new Button();
            SuspendLayout();
            // 
            // labelItem
            // 
            labelItem.AutoSize = true;
            labelItem.Location = new Point(37, 56);
            labelItem.Name = "labelItem";
            labelItem.Size = new Size(64, 15);
            labelItem.TabIndex = 0;
            labelItem.Text = "Item: Food";
            // 
            // textBoxNotes
            // 
            textBoxNotes.Location = new Point(37, 124);
            textBoxNotes.Multiline = true;
            textBoxNotes.Name = "textBoxNotes";
            textBoxNotes.Size = new Size(266, 114);
            textBoxNotes.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 106);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 2;
            label2.Text = "Customization notes";
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(37, 294);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 23);
            buttonBack.TabIndex = 3;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(228, 294);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // CustomizeItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 345);
            Controls.Add(buttonAdd);
            Controls.Add(buttonBack);
            Controls.Add(label2);
            Controls.Add(textBoxNotes);
            Controls.Add(labelItem);
            Name = "CustomizeItem";
            Text = "CustomizeItem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelItem;
        private TextBox textBoxNotes;
        private Label label2;
        private Button buttonBack;
        private Button buttonAdd;
    }
}