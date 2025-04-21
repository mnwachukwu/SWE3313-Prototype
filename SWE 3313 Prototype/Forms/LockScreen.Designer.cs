namespace SWE_3313_Prototype
{
    partial class LockScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonLogin = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(164, 135);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(171, 49);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(164, 117);
            label1.Name = "label1";
            label1.Size = new Size(171, 15);
            label1.TabIndex = 1;
            label1.Text = "Screen locked. Tap to continue.";
            // 
            // LockScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 308);
            Controls.Add(label1);
            Controls.Add(buttonLogin);
            Name = "LockScreen";
            Text = "Employee Login - v1.3.43.23098";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private Label label1;
    }
}
