namespace HelionTask2WForms
{
    partial class Form1
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
            username = new TextBox();
            password = new TextBox();
            number = new TextBox();
            CheckBtn = new Button();
            statusLabel = new Label();
            ResetBtn = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // username
            // 
            username.Anchor = AnchorStyles.None;
            username.BackColor = Color.FromArgb(153, 170, 181);
            username.Font = new Font("Segoe UI", 12F);
            username.ForeColor = Color.White;
            username.Location = new Point(189, 25);
            username.Name = "username";
            username.PlaceholderText = "Username";
            username.Size = new Size(130, 29);
            username.TabIndex = 0;
            username.Text = "sledzeniepp";
            // 
            // password
            // 
            password.Anchor = AnchorStyles.None;
            password.BackColor = Color.FromArgb(153, 170, 181);
            password.Font = new Font("Segoe UI", 12F);
            password.ForeColor = Color.White;
            password.Location = new Point(189, 69);
            password.Name = "password";
            password.PasswordChar = '*';
            password.PlaceholderText = "Password";
            password.Size = new Size(130, 29);
            password.TabIndex = 1;
            password.Text = "PPSA";
            // 
            // number
            // 
            number.Anchor = AnchorStyles.None;
            number.BackColor = Color.FromArgb(153, 170, 181);
            number.Font = new Font("Segoe UI", 12F);
            number.ForeColor = Color.White;
            number.Location = new Point(189, 113);
            number.Name = "number";
            number.PlaceholderText = "Tracking number";
            number.Size = new Size(130, 29);
            number.TabIndex = 2;
            number.Text = "PX6273716673";
            // 
            // CheckBtn
            // 
            CheckBtn.BackColor = Color.FromArgb(107, 139, 161);
            CheckBtn.Cursor = Cursors.Hand;
            CheckBtn.FlatAppearance.BorderColor = Color.FromArgb(107, 139, 161);
            CheckBtn.FlatAppearance.BorderSize = 0;
            CheckBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            CheckBtn.ForeColor = Color.White;
            CheckBtn.Location = new Point(189, 158);
            CheckBtn.Name = "CheckBtn";
            CheckBtn.Size = new Size(130, 29);
            CheckBtn.TabIndex = 3;
            CheckBtn.Text = "CHECK STATUS";
            CheckBtn.UseVisualStyleBackColor = false;
            CheckBtn.Click += CheckBtn_Click;
            // 
            // statusLabel
            // 
            statusLabel.Anchor = AnchorStyles.None;
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Segoe UI", 12F);
            statusLabel.ForeColor = Color.White;
            statusLabel.Location = new Point(12, 303);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(63, 21);
            statusLabel.TabIndex = 4;
            statusLabel.Text = "STATUS";
            statusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = Color.FromArgb(44, 47, 51);
            ResetBtn.Cursor = Cursors.Hand;
            ResetBtn.FlatAppearance.BorderColor = Color.FromArgb(107, 139, 161);
            ResetBtn.FlatAppearance.BorderSize = 0;
            ResetBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ResetBtn.ForeColor = Color.White;
            ResetBtn.Location = new Point(211, 193);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(85, 29);
            ResetBtn.TabIndex = 5;
            ResetBtn.Text = "RESET";
            ResetBtn.UseVisualStyleBackColor = false;
            ResetBtn.Click += CancelBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(107, 139, 161);
            panel1.Location = new Point(-1, 288);
            panel1.Name = "panel1";
            panel1.Size = new Size(506, 10);
            panel1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 47, 51);
            ClientSize = new Size(503, 333);
            Controls.Add(panel1);
            Controls.Add(ResetBtn);
            Controls.Add(statusLabel);
            Controls.Add(CheckBtn);
            Controls.Add(number);
            Controls.Add(password);
            Controls.Add(username);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Poczta Polska WebService";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username;
        private TextBox password;
        private TextBox number;
        private Button CheckBtn;
        private Label statusLabel;
        private Button ResetBtn;
        private Panel panel1;
    }
}
