namespace SWE_3313_Prototype.Forms
{
    partial class TableForm
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
            labelName = new Label();
            buttonSetStatus = new Button();
            comboBoxStatus = new ComboBox();
            buttonBack = new Button();
            listBoxOrderItems = new ListBox();
            buttonLogOut = new Button();
            buttonAddItems = new Button();
            buttonRemoveOrder = new Button();
            buttonSubmit = new Button();
            listBoxSubmittedItems = new ListBox();
            label1 = new Label();
            labelTotal = new Label();
            buttonCloseTab = new Button();
            buttonRemoveSubmittedOrder = new Button();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.Location = new Point(12, 20);
            labelName.Name = "labelName";
            labelName.Size = new Size(64, 21);
            labelName.TabIndex = 0;
            labelName.Text = "Table 0";
            // 
            // buttonSetStatus
            // 
            buttonSetStatus.Location = new Point(229, 22);
            buttonSetStatus.Name = "buttonSetStatus";
            buttonSetStatus.Size = new Size(75, 23);
            buttonSetStatus.TabIndex = 2;
            buttonSetStatus.Text = "Set Status";
            buttonSetStatus.UseVisualStyleBackColor = true;
            buttonSetStatus.Click += buttonSetStatus_Click;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Open", "Occupied", "Dirty" });
            comboBoxStatus.Location = new Point(102, 22);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(121, 23);
            comboBoxStatus.TabIndex = 3;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(182, 407);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 23);
            buttonBack.TabIndex = 4;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // listBoxOrderItems
            // 
            listBoxOrderItems.FormattingEnabled = true;
            listBoxOrderItems.ItemHeight = 15;
            listBoxOrderItems.Location = new Point(12, 133);
            listBoxOrderItems.Name = "listBoxOrderItems";
            listBoxOrderItems.Size = new Size(218, 199);
            listBoxOrderItems.TabIndex = 5;
            // 
            // buttonLogOut
            // 
            buttonLogOut.Location = new Point(272, 407);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(75, 23);
            buttonLogOut.TabIndex = 6;
            buttonLogOut.Text = "Logout";
            buttonLogOut.UseVisualStyleBackColor = true;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // buttonAddItems
            // 
            buttonAddItems.Location = new Point(12, 338);
            buttonAddItems.Name = "buttonAddItems";
            buttonAddItems.Size = new Size(64, 23);
            buttonAddItems.TabIndex = 7;
            buttonAddItems.Text = "Add";
            buttonAddItems.UseVisualStyleBackColor = true;
            buttonAddItems.Click += buttonAddItems_Click;
            // 
            // buttonRemoveOrder
            // 
            buttonRemoveOrder.Location = new Point(82, 338);
            buttonRemoveOrder.Name = "buttonRemoveOrder";
            buttonRemoveOrder.Size = new Size(69, 23);
            buttonRemoveOrder.TabIndex = 8;
            buttonRemoveOrder.Text = "Remove";
            buttonRemoveOrder.UseVisualStyleBackColor = true;
            buttonRemoveOrder.Click += buttonRemoveOrder_Click;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(157, 338);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(66, 23);
            buttonSubmit.TabIndex = 9;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // listBoxSubmittedItems
            // 
            listBoxSubmittedItems.FormattingEnabled = true;
            listBoxSubmittedItems.ItemHeight = 15;
            listBoxSubmittedItems.Location = new Point(317, 133);
            listBoxSubmittedItems.Name = "listBoxSubmittedItems";
            listBoxSubmittedItems.Size = new Size(218, 199);
            listBoxSubmittedItems.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(431, 56);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 11;
            label1.Text = "Sub Total:";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTotal.ForeColor = Color.Green;
            labelTotal.Location = new Point(495, 51);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(49, 21);
            labelTotal.TabIndex = 12;
            labelTotal.Text = "$0.00";
            // 
            // buttonCloseTab
            // 
            buttonCloseTab.Location = new Point(469, 75);
            buttonCloseTab.Name = "buttonCloseTab";
            buttonCloseTab.Size = new Size(75, 23);
            buttonCloseTab.TabIndex = 13;
            buttonCloseTab.Text = "Close Tab";
            buttonCloseTab.UseVisualStyleBackColor = true;
            buttonCloseTab.Click += buttonCloseTab_Click;
            // 
            // buttonRemoveSubmittedOrder
            // 
            buttonRemoveSubmittedOrder.Location = new Point(317, 338);
            buttonRemoveSubmittedOrder.Name = "buttonRemoveSubmittedOrder";
            buttonRemoveSubmittedOrder.Size = new Size(69, 23);
            buttonRemoveSubmittedOrder.TabIndex = 14;
            buttonRemoveSubmittedOrder.Text = "Remove";
            buttonRemoveSubmittedOrder.UseVisualStyleBackColor = true;
            buttonRemoveSubmittedOrder.Click += buttonRemoveSubmittedOrder_Click;
            // 
            // TableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 442);
            Controls.Add(buttonRemoveSubmittedOrder);
            Controls.Add(buttonCloseTab);
            Controls.Add(labelTotal);
            Controls.Add(label1);
            Controls.Add(listBoxSubmittedItems);
            Controls.Add(buttonSubmit);
            Controls.Add(buttonRemoveOrder);
            Controls.Add(buttonAddItems);
            Controls.Add(buttonLogOut);
            Controls.Add(listBoxOrderItems);
            Controls.Add(buttonBack);
            Controls.Add(comboBoxStatus);
            Controls.Add(buttonSetStatus);
            Controls.Add(labelName);
            Name = "TableForm";
            Text = "Table";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Button buttonSetStatus;
        private ComboBox comboBoxStatus;
        private Button buttonBack;
        private ListBox listBoxOrderItems;
        private Button buttonLogOut;
        private Button buttonAddItems;
        private Button buttonRemoveOrder;
        private Button buttonSubmit;
        private ListBox listBoxSubmittedItems;
        private Label label1;
        private Label labelTotal;
        private Button buttonCloseTab;
        private Button buttonRemoveSubmittedOrder;
    }
}