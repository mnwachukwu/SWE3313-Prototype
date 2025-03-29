namespace SWE_3313_Prototype
{
    partial class NewInventoryOrder
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
            checkedListBox1 = new CheckedListBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            Sku = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            BackOrder = new DataGridViewTextBoxColumn();
            Cost = new DataGridViewTextBoxColumn();
            SuggestedPrice = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(685, 370);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 2;
            label1.Text = "Qty";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(742, 367);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Item1 x1", "Item2 x1", "Item3 x3" });
            checkedListBox1.Location = new Point(18, 22);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(308, 220);
            checkedListBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(742, 406);
            button1.Name = "button1";
            button1.Size = new Size(99, 23);
            button1.TabIndex = 5;
            button1.Text = "Add to Order";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(checkedListBox1);
            groupBox1.Location = new Point(24, 474);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(462, 268);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Order";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(341, 186);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 10;
            label3.Text = "$123.54";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(341, 171);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 9;
            label2.Text = "Order Total";
            // 
            // button4
            // 
            button4.Location = new Point(341, 219);
            button4.Name = "button4";
            button4.Size = new Size(99, 23);
            button4.TabIndex = 8;
            button4.Text = "Submit";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(341, 63);
            button3.Name = "button3";
            button3.Size = new Size(99, 23);
            button3.TabIndex = 7;
            button3.Text = "Remove";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(341, 22);
            button2.Name = "button2";
            button2.Size = new Size(99, 23);
            button2.TabIndex = 6;
            button2.Text = "Adjust Qty";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Sku, Name, Description, Qty, BackOrder, Cost, SuggestedPrice });
            dataGridView1.Location = new Point(24, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(838, 320);
            dataGridView1.TabIndex = 8;
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
            // NewInventoryOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 754);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "NewInventoryOrder";
            Text = "New Order";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBox1;
        private CheckedListBox checkedListBox1;
        private Button button1;
        private GroupBox groupBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label3;
        private Label label2;
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