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
            login_Login = new Button();
            login_RememberMe = new CheckBox();
            SuspendLayout();
            // 
            // login_Name
            // 
            login_Name.AutoSize = true;
            login_Name.BackColor = Color.Transparent;
            login_Name.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_Name.ForeColor = SystemColors.ButtonHighlight;
            login_Name.Location = new Point(116, 9);
            login_Name.Name = "login_Name";
            login_Name.Size = new Size(164, 41);
            login_Name.TabIndex = 0;
            login_Name.Text = "Bibliothek";
            // 
            // login_Label_Username
            // 
            login_Label_Username.AutoSize = true;
            login_Label_Username.BackColor = Color.Transparent;
            login_Label_Username.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_Label_Username.ForeColor = SystemColors.ButtonHighlight;
            login_Label_Username.Location = new Point(12, 77);
            login_Label_Username.Name = "login_Label_Username";
            login_Label_Username.Size = new Size(106, 28);
            login_Label_Username.TabIndex = 1;
            login_Label_Username.Text = "Username";
            // 
            // login_Label_Password
            // 
            login_Label_Password.AutoSize = true;
            login_Label_Password.BackColor = Color.Transparent;
            login_Label_Password.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_Label_Password.ForeColor = SystemColors.ButtonHighlight;
            login_Label_Password.Location = new Point(12, 134);
            login_Label_Password.Name = "login_Label_Password";
            login_Label_Password.Size = new Size(101, 28);
            login_Label_Password.TabIndex = 2;
            login_Label_Password.Text = "Password";
            // 
            // login_Username
            // 
            login_Username.Location = new Point(147, 77);
            login_Username.Name = "login_Username";
            login_Username.Size = new Size(230, 34);
            login_Username.TabIndex = 3;
            login_Username.TextAlign = HorizontalAlignment.Center;
            // 
            // login_Password
            // 
            login_Password.Location = new Point(147, 128);
            login_Password.Name = "login_Password";
            login_Password.Size = new Size(230, 34);
            login_Password.TabIndex = 4;
            login_Password.TextAlign = HorizontalAlignment.Center;
            // 
            // login_Login
            // 
            login_Login.Location = new Point(227, 191);
            login_Login.Name = "login_Login";
            login_Login.Size = new Size(150, 42);
            login_Login.TabIndex = 5;
            login_Login.Text = "Login";
            login_Login.UseVisualStyleBackColor = true;
            // 
            // login_RememberMe
            // 
            login_RememberMe.AutoSize = true;
            login_RememberMe.BackColor = Color.Transparent;
            login_RememberMe.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_RememberMe.ForeColor = SystemColors.ButtonHighlight;
            login_RememberMe.Location = new Point(12, 197);
            login_RememberMe.Name = "login_RememberMe";
            login_RememberMe.Size = new Size(172, 32);
            login_RememberMe.TabIndex = 6;
            login_RememberMe.Text = "Remember Me";
            login_RememberMe.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Hintergrund800x600;
            ClientSize = new Size(389, 256);
            Controls.Add(login_RememberMe);
            Controls.Add(login_Login);
            Controls.Add(login_Password);
            Controls.Add(login_Username);
            Controls.Add(login_Label_Password);
            Controls.Add(login_Label_Username);
            Controls.Add(login_Name);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label login_Name;
        private Label login_Label_Username;
        private Label login_Label_Password;
        private TextBox login_Username;
        private TextBox login_Password;
        private Button login_Login;
        private CheckBox login_RememberMe;
    }
}
