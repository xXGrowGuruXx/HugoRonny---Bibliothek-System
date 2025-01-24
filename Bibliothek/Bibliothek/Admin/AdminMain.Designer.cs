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
            adminMain_Mitarbeiter_Add = new Button();
            adminMain_Mitarbeiter_Delete = new Button();
            adminMain_Mitarbeiter_Change = new Button();
            adminMain_Strafen = new Button();
            adminMain_Verliehene_Bücher = new Button();
            adminMain_Statistik = new Button();
            panel3 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            adminMain_Logout = new Button();
            SuspendLayout();
            // 
            // adminMain_Name
            // 
            adminMain_Name.AutoSize = true;
            adminMain_Name.BackColor = Color.Transparent;
            adminMain_Name.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminMain_Name.ForeColor = SystemColors.ButtonHighlight;
            adminMain_Name.Location = new Point(297, 22);
            adminMain_Name.Name = "adminMain_Name";
            adminMain_Name.Size = new Size(192, 41);
            adminMain_Name.TabIndex = 0;
            adminMain_Name.Text = "Admin Main";
            // 
            // adminMain_Mitarbeiter_Add
            // 
            adminMain_Mitarbeiter_Add.Location = new Point(34, 145);
            adminMain_Mitarbeiter_Add.Name = "adminMain_Mitarbeiter_Add";
            adminMain_Mitarbeiter_Add.Size = new Size(188, 79);
            adminMain_Mitarbeiter_Add.TabIndex = 1;
            adminMain_Mitarbeiter_Add.Text = "Mitarbeiter hinzufügen";
            adminMain_Mitarbeiter_Add.UseVisualStyleBackColor = true;
            // 
            // adminMain_Mitarbeiter_Delete
            // 
            adminMain_Mitarbeiter_Delete.Location = new Point(297, 145);
            adminMain_Mitarbeiter_Delete.Name = "adminMain_Mitarbeiter_Delete";
            adminMain_Mitarbeiter_Delete.Size = new Size(188, 79);
            adminMain_Mitarbeiter_Delete.TabIndex = 2;
            adminMain_Mitarbeiter_Delete.Text = "Mitarbeiter löschen";
            adminMain_Mitarbeiter_Delete.UseVisualStyleBackColor = true;
            // 
            // adminMain_Mitarbeiter_Change
            // 
            adminMain_Mitarbeiter_Change.Location = new Point(552, 145);
            adminMain_Mitarbeiter_Change.Name = "adminMain_Mitarbeiter_Change";
            adminMain_Mitarbeiter_Change.Size = new Size(188, 79);
            adminMain_Mitarbeiter_Change.TabIndex = 3;
            adminMain_Mitarbeiter_Change.Text = "Mitarbeiter bearbeiten";
            adminMain_Mitarbeiter_Change.UseVisualStyleBackColor = true;
            // 
            // adminMain_Strafen
            // 
            adminMain_Strafen.Location = new Point(34, 299);
            adminMain_Strafen.Name = "adminMain_Strafen";
            adminMain_Strafen.Size = new Size(188, 79);
            adminMain_Strafen.TabIndex = 4;
            adminMain_Strafen.Text = "Strafen ansehen";
            adminMain_Strafen.UseVisualStyleBackColor = true;
            // 
            // adminMain_Verliehene_Bücher
            // 
            adminMain_Verliehene_Bücher.Location = new Point(297, 299);
            adminMain_Verliehene_Bücher.Name = "adminMain_Verliehene_Bücher";
            adminMain_Verliehene_Bücher.Size = new Size(188, 79);
            adminMain_Verliehene_Bücher.TabIndex = 5;
            adminMain_Verliehene_Bücher.Text = "Verliehene Bücher ansehen";
            adminMain_Verliehene_Bücher.UseVisualStyleBackColor = true;
            // 
            // adminMain_Statistik
            // 
            adminMain_Statistik.Location = new Point(552, 299);
            adminMain_Statistik.Name = "adminMain_Statistik";
            adminMain_Statistik.Size = new Size(188, 79);
            adminMain_Statistik.TabIndex = 6;
            adminMain_Statistik.Text = "Statistik erstellen";
            adminMain_Statistik.UseVisualStyleBackColor = true;
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
            adminMain_Logout.Location = new Point(297, 449);
            adminMain_Logout.Name = "adminMain_Logout";
            adminMain_Logout.Size = new Size(188, 79);
            adminMain_Logout.TabIndex = 10;
            adminMain_Logout.Text = "Logout";
            adminMain_Logout.UseVisualStyleBackColor = true;
            // 
            // AdminMain
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Hintergrund800x600;
            ClientSize = new Size(782, 553);
            Controls.Add(adminMain_Logout);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(adminMain_Statistik);
            Controls.Add(adminMain_Verliehene_Bücher);
            Controls.Add(adminMain_Strafen);
            Controls.Add(adminMain_Mitarbeiter_Change);
            Controls.Add(adminMain_Mitarbeiter_Delete);
            Controls.Add(adminMain_Mitarbeiter_Add);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label adminMain_Name;
        private Button adminMain_Mitarbeiter_Add;
        private Button adminMain_Mitarbeiter_Delete;
        private Button adminMain_Mitarbeiter_Change;
        private Button adminMain_Strafen;
        private Button adminMain_Verliehene_Bücher;
        private Button adminMain_Statistik;
        private Panel panel3;
        private Panel panel1;
        private Panel panel2;
        private Button adminMain_Logout;
    }
}