namespace Bibliothek
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            login_Name = new Label();
            login_Label_Username = new Label();
            login_Label_Password = new Label();
            login_Username = new TextBox();
            login_Password = new TextBox();
            login_RememberMe = new CheckBox();
            login_Login = new Button();
            SuspendLayout();
            // 
            // login_Name
            // 
            login_Name.AutoSize = true;
            login_Name.BackColor = Color.Transparent;
            login_Name.Font = new Font("Vacaciones", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_Name.ForeColor = Color.White;
            login_Name.Location = new Point(101, 9);
            login_Name.Name = "login_Name";
            login_Name.Size = new Size(232, 55);
            login_Name.TabIndex = 0;
            login_Name.Text = "Bibliothek";
            // 
            // login_Label_Username
            // 
            login_Label_Username.AutoSize = true;
            login_Label_Username.BackColor = Color.Transparent;
            login_Label_Username.Font = new Font("Vacaciones", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_Label_Username.ForeColor = SystemColors.ButtonHighlight;
            login_Label_Username.Location = new Point(13, 66);
            login_Label_Username.Name = "login_Label_Username";
            login_Label_Username.Size = new Size(123, 28);
            login_Label_Username.TabIndex = 1;
            login_Label_Username.Text = "Username";
            // 
            // login_Label_Password
            // 
            login_Label_Password.AutoSize = true;
            login_Label_Password.BackColor = Color.Transparent;
            login_Label_Password.Font = new Font("Vacaciones", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_Label_Password.ForeColor = SystemColors.ButtonHighlight;
            login_Label_Password.Location = new Point(13, 110);
            login_Label_Password.Name = "login_Label_Password";
            login_Label_Password.Size = new Size(120, 28);
            login_Label_Password.TabIndex = 2;
            login_Label_Password.Text = "Password";
            // 
            // login_Username
            // 
            login_Username.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_Username.Location = new Point(160, 63);
            login_Username.Name = "login_Username";
            login_Username.Size = new Size(251, 34);
            login_Username.TabIndex = 3;
            login_Username.TextAlign = HorizontalAlignment.Center;
            // 
            // login_Password
            // 
            login_Password.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_Password.Location = new Point(160, 105);
            login_Password.Name = "login_Password";
            login_Password.Size = new Size(251, 34);
            login_Password.TabIndex = 4;
            login_Password.TextAlign = HorizontalAlignment.Center;
            // 
            // login_RememberMe
            // 
            login_RememberMe.AutoSize = true;
            login_RememberMe.BackColor = Color.Transparent;
            login_RememberMe.Font = new Font("Vacaciones", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_RememberMe.ForeColor = SystemColors.ButtonHighlight;
            login_RememberMe.Location = new Point(13, 162);
            login_RememberMe.Name = "login_RememberMe";
            login_RememberMe.Size = new Size(189, 32);
            login_RememberMe.TabIndex = 6;
            login_RememberMe.Text = "Remember Me";
            login_RememberMe.UseVisualStyleBackColor = false;
            // 
            // login_Login
            // 
            login_Login.BackColor = Color.Transparent;
            login_Login.FlatStyle = FlatStyle.Flat;
            login_Login.Font = new Font("Vacaciones", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_Login.ForeColor = SystemColors.Control;
            login_Login.Location = new Point(251, 153);
            login_Login.Name = "login_Login";
            login_Login.Size = new Size(160, 47);
            login_Login.TabIndex = 7;
            login_Login.Text = "Login";
            login_Login.UseVisualStyleBackColor = false;
            login_Login.Click += login_Login_Click;
            login_Login.MouseEnter += login_Login_MouseEnter;
            login_Login.MouseLeave += login_Login_MouseLeave;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Hintergrund800x600;
            ClientSize = new Size(424, 210);
            Controls.Add(login_Login);
            Controls.Add(login_RememberMe);
            Controls.Add(login_Password);
            Controls.Add(login_Username);
            Controls.Add(login_Label_Password);
            Controls.Add(login_Label_Username);
            Controls.Add(login_Name);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox login_Username;
        private TextBox login_Password;
        public CheckBox login_RememberMe;
        private Label login_Name;
        private Label login_Label_Username;
        private Label login_Label_Password;
        private Button login_Login;
    }
}
