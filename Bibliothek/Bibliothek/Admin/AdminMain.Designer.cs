namespace Bibliothek.Admin
{
    partial class AdminMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMain));
            adminMain_Name = new Label();
            panel3 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            adminMain_Logout = new Button();
            adminMain_Mitarbeiter = new Button();
            adminMain_Statistik = new Button();
            SuspendLayout();
            // 
            // adminMain_Name
            // 
            adminMain_Name.AutoSize = true;
            adminMain_Name.BackColor = Color.Transparent;
            adminMain_Name.Font = new Font("Vacaciones", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminMain_Name.ForeColor = SystemColors.ButtonHighlight;
            adminMain_Name.Location = new Point(266, 31);
            adminMain_Name.Name = "adminMain_Name";
            adminMain_Name.Size = new Size(255, 55);
            adminMain_Name.TabIndex = 0;
            adminMain_Name.Text = "Admin Main";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(34, 409);
            panel3.Name = "panel3";
            panel3.Size = new Size(706, 10);
            panel3.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(34, 259);
            panel1.Name = "panel1";
            panel1.Size = new Size(706, 10);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(34, 103);
            panel2.Name = "panel2";
            panel2.Size = new Size(706, 10);
            panel2.TabIndex = 9;
            // 
            // adminMain_Logout
            // 
            adminMain_Logout.BackColor = Color.Transparent;
            adminMain_Logout.FlatStyle = FlatStyle.Popup;
            adminMain_Logout.Font = new Font("Vacaciones", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminMain_Logout.ForeColor = SystemColors.Control;
            adminMain_Logout.Location = new Point(110, 449);
            adminMain_Logout.Name = "adminMain_Logout";
            adminMain_Logout.Size = new Size(555, 79);
            adminMain_Logout.TabIndex = 10;
            adminMain_Logout.Text = "Logout";
            adminMain_Logout.UseVisualStyleBackColor = false;
            adminMain_Logout.Click += adminMain_Logout_Click;
            adminMain_Logout.MouseEnter += adminMain_Buttons_MouseEnter;
            adminMain_Logout.MouseLeave += adminMain_Buttons_MouseLeave;
            // 
            // adminMain_Mitarbeiter
            // 
            adminMain_Mitarbeiter.BackColor = Color.Transparent;
            adminMain_Mitarbeiter.FlatStyle = FlatStyle.Popup;
            adminMain_Mitarbeiter.Font = new Font("Vacaciones", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminMain_Mitarbeiter.ForeColor = SystemColors.Control;
            adminMain_Mitarbeiter.Location = new Point(207, 159);
            adminMain_Mitarbeiter.Name = "adminMain_Mitarbeiter";
            adminMain_Mitarbeiter.Size = new Size(379, 64);
            adminMain_Mitarbeiter.TabIndex = 11;
            adminMain_Mitarbeiter.Text = "Mitarbeiter";
            adminMain_Mitarbeiter.UseVisualStyleBackColor = false;
            adminMain_Mitarbeiter.MouseEnter += adminMain_Buttons_MouseEnter;
            adminMain_Mitarbeiter.MouseLeave += adminMain_Buttons_MouseLeave;
            // 
            // adminMain_Statistik
            // 
            adminMain_Statistik.BackColor = Color.Transparent;
            adminMain_Statistik.FlatStyle = FlatStyle.Popup;
            adminMain_Statistik.Font = new Font("Vacaciones", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminMain_Statistik.ForeColor = SystemColors.Control;
            adminMain_Statistik.Location = new Point(207, 308);
            adminMain_Statistik.Name = "adminMain_Statistik";
            adminMain_Statistik.Size = new Size(379, 64);
            adminMain_Statistik.TabIndex = 12;
            adminMain_Statistik.Text = "Statistik";
            adminMain_Statistik.UseVisualStyleBackColor = false;
            adminMain_Statistik.MouseEnter += adminMain_Buttons_MouseEnter;
            adminMain_Statistik.MouseLeave += adminMain_Buttons_MouseLeave;
            // 
            // AdminMain
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Hintergrund800x600;
            ClientSize = new Size(782, 553);
            Controls.Add(adminMain_Statistik);
            Controls.Add(adminMain_Mitarbeiter);
            Controls.Add(adminMain_Logout);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(adminMain_Name);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdminMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Main";
            FormClosing += AdminMain_FormClosing;
            Load += AdminMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label adminMain_Name;
        private Button adminMain_Strafen;
        private Button adminMain_Verliehene_Bücher;
        private Panel panel3;
        private Panel panel1;
        private Panel panel2;
        private Button adminMain_Logout;
        private Button adminMain_Mitarbeiter;
        private Button adminMain_Statistik;
    }
}