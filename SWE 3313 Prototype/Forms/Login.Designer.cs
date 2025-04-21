namespace SWE_3313_Prototype
{
    partial class Login
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
            textBoxEmployeeId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxPin = new TextBox();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // textBoxEmployeeId
            // 
            textBoxEmployeeId.Location = new Point(154, 92);
            textBoxEmployeeId.Name = "textBoxEmployeeId";
            textBoxEmployeeId.Size = new Size(100, 23);
            textBoxEmployeeId.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 95);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 1;
            label1.Text = "Employee Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 133);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 3;
            label2.Text = "Pin";
            // 
            // textBoxPin
            // 
            textBoxPin.Location = new Point(154, 130);
            textBoxPin.Name = "textBoxPin";
            textBoxPin.Size = new Size(100, 23);
            textBoxPin.TabIndex = 2;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(154, 203);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(75, 23);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 271);
            Controls.Add(buttonLogin);
            Controls.Add(label2);
            Controls.Add(textBoxPin);
            Controls.Add(label1);
            Controls.Add(textBoxEmployeeId);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxEmployeeId;
        private Label label1;
        private Label label2;
        private TextBox textBoxPin;
        private Button buttonLogin;
    }
}