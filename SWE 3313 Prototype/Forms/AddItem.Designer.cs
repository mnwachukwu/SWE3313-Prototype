namespace SWE_3313_Prototype.Forms
{
    partial class AddItem
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
            buttonAppetizer = new Button();
            buttonDrinks = new Button();
            buttonMain = new Button();
            buttonVegetarian = new Button();
            buttonDessert = new Button();
            panelItems = new Panel();
            buttonItem4 = new Button();
            buttonItem3 = new Button();
            buttonItem2 = new Button();
            buttonItem1 = new Button();
            buttonBack = new Button();
            buttonLogout = new Button();
            panelItems.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAppetizer
            // 
            buttonAppetizer.Location = new Point(52, 38);
            buttonAppetizer.Name = "buttonAppetizer";
            buttonAppetizer.Size = new Size(104, 48);
            buttonAppetizer.TabIndex = 0;
            buttonAppetizer.Text = "Appetizer";
            buttonAppetizer.UseVisualStyleBackColor = true;
            buttonAppetizer.Click += buttonAppetizer_Click;
            // 
            // buttonDrinks
            // 
            buttonDrinks.Location = new Point(52, 118);
            buttonDrinks.Name = "buttonDrinks";
            buttonDrinks.Size = new Size(104, 48);
            buttonDrinks.TabIndex = 1;
            buttonDrinks.Text = "Drinks";
            buttonDrinks.UseVisualStyleBackColor = true;
            buttonDrinks.Click += buttonDrinks_Click;
            // 
            // buttonMain
            // 
            buttonMain.Location = new Point(52, 198);
            buttonMain.Name = "buttonMain";
            buttonMain.Size = new Size(104, 48);
            buttonMain.TabIndex = 2;
            buttonMain.Text = "Main Course";
            buttonMain.UseVisualStyleBackColor = true;
            buttonMain.Click += buttonMain_Click;
            // 
            // buttonVegetarian
            // 
            buttonVegetarian.Location = new Point(52, 289);
            buttonVegetarian.Name = "buttonVegetarian";
            buttonVegetarian.Size = new Size(104, 48);
            buttonVegetarian.TabIndex = 3;
            buttonVegetarian.Text = "Vegetarian";
            buttonVegetarian.UseVisualStyleBackColor = true;
            buttonVegetarian.Click += buttonVegetarian_Click;
            // 
            // buttonDessert
            // 
            buttonDessert.Location = new Point(52, 381);
            buttonDessert.Name = "buttonDessert";
            buttonDessert.Size = new Size(104, 48);
            buttonDessert.TabIndex = 4;
            buttonDessert.Text = "Dessert";
            buttonDessert.UseVisualStyleBackColor = true;
            buttonDessert.Click += buttonDessert_Click;
            // 
            // panelItems
            // 
            panelItems.Controls.Add(buttonItem4);
            panelItems.Controls.Add(buttonItem3);
            panelItems.Controls.Add(buttonItem2);
            panelItems.Controls.Add(buttonItem1);
            panelItems.Location = new Point(239, 38);
            panelItems.Name = "panelItems";
            panelItems.Size = new Size(549, 391);
            panelItems.TabIndex = 9;
            panelItems.Visible = false;
            // 
            // buttonItem4
            // 
            buttonItem4.Location = new Point(286, 200);
            buttonItem4.Name = "buttonItem4";
            buttonItem4.Size = new Size(232, 126);
            buttonItem4.TabIndex = 12;
            buttonItem4.Text = "Item 4";
            buttonItem4.UseVisualStyleBackColor = true;
            // 
            // buttonItem3
            // 
            buttonItem3.Location = new Point(33, 200);
            buttonItem3.Name = "buttonItem3";
            buttonItem3.Size = new Size(232, 126);
            buttonItem3.TabIndex = 11;
            buttonItem3.Text = "Item 3";
            buttonItem3.UseVisualStyleBackColor = true;
            // 
            // buttonItem2
            // 
            buttonItem2.Location = new Point(286, 54);
            buttonItem2.Name = "buttonItem2";
            buttonItem2.Size = new Size(232, 126);
            buttonItem2.TabIndex = 10;
            buttonItem2.Text = "Item 2";
            buttonItem2.UseVisualStyleBackColor = true;
            // 
            // buttonItem1
            // 
            buttonItem1.Location = new Point(33, 54);
            buttonItem1.Name = "buttonItem1";
            buttonItem1.Size = new Size(232, 126);
            buttonItem1.TabIndex = 9;
            buttonItem1.Text = "Item 1";
            buttonItem1.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(619, 481);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 23);
            buttonBack.TabIndex = 10;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.Location = new Point(713, 481);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(75, 23);
            buttonLogout.TabIndex = 11;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // AddItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 516);
            Controls.Add(buttonLogout);
            Controls.Add(buttonBack);
            Controls.Add(panelItems);
            Controls.Add(buttonDessert);
            Controls.Add(buttonVegetarian);
            Controls.Add(buttonMain);
            Controls.Add(buttonDrinks);
            Controls.Add(buttonAppetizer);
            Name = "AddItem";
            Text = "AddItem";
            panelItems.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAppetizer;
        private Button buttonDrinks;
        private Button buttonMain;
        private Button buttonVegetarian;
        private Button buttonDessert;
        private Panel panelItems;
        private Button buttonItem4;
        private Button buttonItem3;
        private Button buttonItem2;
        private Button buttonItem1;
        private Button buttonBack;
        private Button buttonLogout;
    }
}