namespace Bibliothek.Mitarbeiter
{
    partial class MitarbeiterMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MitarbeiterMain));
            mitarbeiter_Kunden = new Button();
            mitarbeiter_Bücher = new Button();
            mitarbeiter_Autoren = new Button();
            mitarbeiter_Genres = new Button();
            mitarbeiter_Abmelden = new Button();
            mitarbeiter_Name = new Label();
            SuspendLayout();
            // 
            // mitarbeiter_Kunden
            // 
            mitarbeiter_Kunden.BackColor = Color.Transparent;
            mitarbeiter_Kunden.FlatStyle = FlatStyle.Popup;
            mitarbeiter_Kunden.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mitarbeiter_Kunden.ForeColor = SystemColors.ButtonHighlight;
            mitarbeiter_Kunden.Location = new Point(236, 98);
            mitarbeiter_Kunden.Margin = new Padding(0);
            mitarbeiter_Kunden.Name = "mitarbeiter_Kunden";
            mitarbeiter_Kunden.Size = new Size(322, 55);
            mitarbeiter_Kunden.TabIndex = 0;
            mitarbeiter_Kunden.Text = "Kunden";
            mitarbeiter_Kunden.UseVisualStyleBackColor = false;
            mitarbeiter_Kunden.MouseEnter += mitarbeiter_Buttons_MouseEnter;
            mitarbeiter_Kunden.MouseLeave += mitarbeiter_Buttons_MouseLeave;
            // 
            // mitarbeiter_Bücher
            // 
            mitarbeiter_Bücher.BackColor = Color.Transparent;
            mitarbeiter_Bücher.FlatStyle = FlatStyle.Popup;
            mitarbeiter_Bücher.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mitarbeiter_Bücher.ForeColor = SystemColors.ButtonHighlight;
            mitarbeiter_Bücher.Location = new Point(236, 200);
            mitarbeiter_Bücher.Margin = new Padding(0);
            mitarbeiter_Bücher.Name = "mitarbeiter_Bücher";
            mitarbeiter_Bücher.Size = new Size(322, 55);
            mitarbeiter_Bücher.TabIndex = 1;
            mitarbeiter_Bücher.Text = "Bücher";
            mitarbeiter_Bücher.UseVisualStyleBackColor = false;
            mitarbeiter_Bücher.MouseEnter += mitarbeiter_Buttons_MouseEnter;
            mitarbeiter_Bücher.MouseLeave += mitarbeiter_Buttons_MouseLeave;
            // 
            // mitarbeiter_Autoren
            // 
            mitarbeiter_Autoren.BackColor = Color.Transparent;
            mitarbeiter_Autoren.FlatStyle = FlatStyle.Popup;
            mitarbeiter_Autoren.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mitarbeiter_Autoren.ForeColor = SystemColors.ButtonHighlight;
            mitarbeiter_Autoren.Location = new Point(236, 299);
            mitarbeiter_Autoren.Margin = new Padding(0);
            mitarbeiter_Autoren.Name = "mitarbeiter_Autoren";
            mitarbeiter_Autoren.Size = new Size(322, 55);
            mitarbeiter_Autoren.TabIndex = 2;
            mitarbeiter_Autoren.Text = "Autoren";
            mitarbeiter_Autoren.UseVisualStyleBackColor = false;
            mitarbeiter_Autoren.MouseEnter += mitarbeiter_Buttons_MouseEnter;
            mitarbeiter_Autoren.MouseLeave += mitarbeiter_Buttons_MouseLeave;
            // 
            // mitarbeiter_Genres
            // 
            mitarbeiter_Genres.BackColor = Color.Transparent;
            mitarbeiter_Genres.FlatStyle = FlatStyle.Popup;
            mitarbeiter_Genres.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mitarbeiter_Genres.ForeColor = SystemColors.ButtonHighlight;
            mitarbeiter_Genres.Location = new Point(236, 395);
            mitarbeiter_Genres.Margin = new Padding(0);
            mitarbeiter_Genres.Name = "mitarbeiter_Genres";
            mitarbeiter_Genres.Size = new Size(322, 55);
            mitarbeiter_Genres.TabIndex = 3;
            mitarbeiter_Genres.Text = "Genres";
            mitarbeiter_Genres.UseVisualStyleBackColor = false;
            mitarbeiter_Genres.MouseEnter += mitarbeiter_Buttons_MouseEnter;
            mitarbeiter_Genres.MouseLeave += mitarbeiter_Buttons_MouseLeave;
            // 
            // mitarbeiter_Abmelden
            // 
            mitarbeiter_Abmelden.BackColor = Color.Transparent;
            mitarbeiter_Abmelden.FlatStyle = FlatStyle.Popup;
            mitarbeiter_Abmelden.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mitarbeiter_Abmelden.ForeColor = SystemColors.ButtonHighlight;
            mitarbeiter_Abmelden.Location = new Point(106, 497);
            mitarbeiter_Abmelden.Margin = new Padding(0);
            mitarbeiter_Abmelden.Name = "mitarbeiter_Abmelden";
            mitarbeiter_Abmelden.Size = new Size(590, 55);
            mitarbeiter_Abmelden.TabIndex = 4;
            mitarbeiter_Abmelden.Text = "Abmelden";
            mitarbeiter_Abmelden.UseVisualStyleBackColor = false;
            mitarbeiter_Abmelden.Click += mitarbeiter_Abmelden_Click;
            mitarbeiter_Abmelden.MouseEnter += mitarbeiter_Buttons_MouseEnter;
            mitarbeiter_Abmelden.MouseLeave += mitarbeiter_Buttons_MouseLeave;
            // 
            // mitarbeiter_Name
            // 
            mitarbeiter_Name.AutoSize = true;
            mitarbeiter_Name.BackColor = Color.Transparent;
            mitarbeiter_Name.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mitarbeiter_Name.ForeColor = Color.Transparent;
            mitarbeiter_Name.Location = new Point(260, 9);
            mitarbeiter_Name.Name = "mitarbeiter_Name";
            mitarbeiter_Name.Size = new Size(268, 37);
            mitarbeiter_Name.TabIndex = 5;
            mitarbeiter_Name.Text = "Mitarbeiter HUB ";
            mitarbeiter_Name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MitarbeiterMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.Hintergrund800x600;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(784, 561);
            Controls.Add(mitarbeiter_Name);
            Controls.Add(mitarbeiter_Abmelden);
            Controls.Add(mitarbeiter_Genres);
            Controls.Add(mitarbeiter_Autoren);
            Controls.Add(mitarbeiter_Bücher);
            Controls.Add(mitarbeiter_Kunden);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(800, 600);
            MinimizeBox = false;
            MinimumSize = new Size(800, 600);
            Name = "MitarbeiterMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mitarbeiter";
            FormClosing += MitarbeiterMain_FormClosing;
            Load += Mitarbeiter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button mitarbeiter_Kunden;
        private Button mitarbeiter_Bücher;
        private Button mitarbeiter_Autoren;
        private Button mitarbeiter_Genres;
        private Button mitarbeiter_Abmelden;
        private Label mitarbeiter_Name;
    }
}