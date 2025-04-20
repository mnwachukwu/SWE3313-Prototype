namespace SWE_3313_Prototype
{
    partial class Inventory
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            dataGridView1 = new DataGridView();
            Sku = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            BackOrder = new DataGridViewTextBoxColumn();
            Cost = new DataGridViewTextBoxColumn();
            SuggestedPrice = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(79, 383);
            button1.Name = "button1";
            button1.Size = new Size(108, 41);
            button1.TabIndex = 1;
            button1.Text = "New Order";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(212, 383);
            button2.Name = "button2";
            button2.Size = new Size(108, 41);
            button2.TabIndex = 2;
            button2.Text = "Receive Order";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(344, 383);
            button3.Name = "button3";
            button3.Size = new Size(108, 41);
            button3.TabIndex = 3;
            button3.Text = "Adjust";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(476, 383);
            button4.Name = "button4";
            button4.Size = new Size(108, 41);
            button4.TabIndex = 4;
            button4.Text = "New Item";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(607, 383);
            button5.Name = "button5";
            button5.Size = new Size(108, 41);
            button5.TabIndex = 5;
            button5.Text = "Edit Item";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(741, 383);
            button6.Name = "button6";
            button6.Size = new Size(108, 41);
            button6.TabIndex = 6;
            button6.Text = "Delete Item";
            button6.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Sku, Name, Description, Qty, BackOrder, Cost, SuggestedPrice });
            dataGridView1.Location = new Point(56, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(838, 320);
            dataGridView1.TabIndex = 7;
            // 
            // Sku
            // 
            Sku.HeaderText = "SKU";
            Sku.Name = "Sku";
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.Name = "Name";
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.Name = "Description";
            // 
            // Qty
            // 
            Qty.HeaderText = "Qty";
            Qty.Name = "Qty";
            // 
            // BackOrder
            // 
            BackOrder.HeaderText = "Back Order";
            BackOrder.Name = "BackOrder";
            // 
            // Cost
            // 
            Cost.HeaderText = "Cost";
            Cost.Name = "Cost";
            // 
            // SuggestedPrice
            // 
            SuggestedPrice.HeaderText = "Suggested Price";
            SuggestedPrice.Name = "SuggestedPrice";
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 449);
            Controls.Add(dataGridView1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Sku;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewTextBoxColumn BackOrder;
        private DataGridViewTextBoxColumn Cost;
        private DataGridViewTextBoxColumn SuggestedPrice;
    }
}