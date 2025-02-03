namespace Bibliothek.Kunde
{
    partial class KundeMain
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
            KundenHUB = new Label();
            Kunde_Suche = new Button();
            Kunde_Rueckgabe = new Button();
            Kunde_Reservierungen = new Button();
            Kunde_Abmelden = new Button();
            Kunde_Strafen = new Button();
            SuspendLayout();
            // 
            // KundenHUB
            // 
            KundenHUB.AutoSize = true;
            KundenHUB.BackColor = Color.Transparent;
            KundenHUB.Font = new Font("Vacaciones", 28.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KundenHUB.ForeColor = Color.Transparent;
            KundenHUB.Location = new Point(232, 17);
            KundenHUB.Name = "KundenHUB";
            KundenHUB.Size = new Size(321, 65);
            KundenHUB.TabIndex = 6;
            KundenHUB.Text = "Kunden HUB ";
            KundenHUB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Kunde_Suche
            // 
            Kunde_Suche.BackColor = Color.Transparent;
            Kunde_Suche.FlatStyle = FlatStyle.Popup;
            Kunde_Suche.Font = new Font("Vacaciones", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Kunde_Suche.ForeColor = SystemColors.ButtonHighlight;
            Kunde_Suche.Location = new Point(231, 109);
            Kunde_Suche.Margin = new Padding(0);
            Kunde_Suche.Name = "Kunde_Suche";
            Kunde_Suche.Size = new Size(322, 55);
            Kunde_Suche.TabIndex = 7;
            Kunde_Suche.Text = "Büchersuche";
            Kunde_Suche.UseVisualStyleBackColor = false;
            Kunde_Suche.Click += kundeMain_Buttons_Click;
            Kunde_Suche.MouseEnter += kundeMain_Buttons_MouseEnter;
            Kunde_Suche.MouseLeave += kundeMain_Buttons_MouseLeave;
            // 
            // Kunde_Rueckgabe
            // 
            Kunde_Rueckgabe.BackColor = Color.Transparent;
            Kunde_Rueckgabe.FlatStyle = FlatStyle.Popup;
            Kunde_Rueckgabe.Font = new Font("Vacaciones", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Kunde_Rueckgabe.ForeColor = SystemColors.ButtonHighlight;
            Kunde_Rueckgabe.Location = new Point(231, 207);
            Kunde_Rueckgabe.Margin = new Padding(0);
            Kunde_Rueckgabe.Name = "Kunde_Rueckgabe";
            Kunde_Rueckgabe.Size = new Size(322, 55);
            Kunde_Rueckgabe.TabIndex = 8;
            Kunde_Rueckgabe.Text = "Rückgabe";
            Kunde_Rueckgabe.UseVisualStyleBackColor = false;
            Kunde_Rueckgabe.Click += kundeMain_Buttons_Click;
            Kunde_Rueckgabe.MouseEnter += kundeMain_Buttons_MouseEnter;
            Kunde_Rueckgabe.MouseLeave += kundeMain_Buttons_MouseLeave;
            // 
            // Kunde_Reservierungen
            // 
            Kunde_Reservierungen.BackColor = Color.Transparent;
            Kunde_Reservierungen.FlatStyle = FlatStyle.Popup;
            Kunde_Reservierungen.Font = new Font("Vacaciones", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Kunde_Reservierungen.ForeColor = SystemColors.ButtonHighlight;
            Kunde_Reservierungen.Location = new Point(231, 314);
            Kunde_Reservierungen.Margin = new Padding(0);
            Kunde_Reservierungen.Name = "Kunde_Reservierungen";
            Kunde_Reservierungen.Size = new Size(322, 55);
            Kunde_Reservierungen.TabIndex = 9;
            Kunde_Reservierungen.Text = "Reservierungen";
            Kunde_Reservierungen.UseVisualStyleBackColor = false;
            Kunde_Reservierungen.Click += kundeMain_Buttons_Click;
            Kunde_Reservierungen.MouseEnter += kundeMain_Buttons_MouseEnter;
            Kunde_Reservierungen.MouseLeave += kundeMain_Buttons_MouseLeave;
            // 
            // Kunde_Abmelden
            // 
            Kunde_Abmelden.BackColor = Color.Transparent;
            Kunde_Abmelden.FlatStyle = FlatStyle.Popup;
            Kunde_Abmelden.Font = new Font("Vacaciones", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Kunde_Abmelden.ForeColor = SystemColors.ButtonHighlight;
            Kunde_Abmelden.Location = new Point(100, 489);
            Kunde_Abmelden.Margin = new Padding(0);
            Kunde_Abmelden.Name = "Kunde_Abmelden";
            Kunde_Abmelden.Size = new Size(590, 55);
            Kunde_Abmelden.TabIndex = 10;
            Kunde_Abmelden.Text = "Abmelden";
            Kunde_Abmelden.UseVisualStyleBackColor = false;
            Kunde_Abmelden.Click += kundeMain_Abmelden_Click;
            Kunde_Abmelden.MouseEnter += kundeMain_Buttons_MouseEnter;
            Kunde_Abmelden.MouseLeave += kundeMain_Buttons_MouseLeave;
            // 
            // Kunde_Strafen
            // 
            Kunde_Strafen.BackColor = Color.Transparent;
            Kunde_Strafen.FlatStyle = FlatStyle.Popup;
            Kunde_Strafen.Font = new Font("Vacaciones", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Kunde_Strafen.ForeColor = SystemColors.ButtonHighlight;
            Kunde_Strafen.Location = new Point(231, 400);
            Kunde_Strafen.Margin = new Padding(0);
            Kunde_Strafen.Name = "Kunde_Strafen";
            Kunde_Strafen.Size = new Size(322, 55);
            Kunde_Strafen.TabIndex = 11;
            Kunde_Strafen.Text = "Strafen";
            Kunde_Strafen.UseVisualStyleBackColor = false;
            Kunde_Strafen.Click += kundeMain_Buttons_Click;
            Kunde_Strafen.MouseEnter += kundeMain_Buttons_MouseEnter;
            Kunde_Strafen.MouseLeave += kundeMain_Buttons_MouseLeave;
            // 
            // KundeMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.Hintergrund800x600;
            ClientSize = new Size(782, 553);
            Controls.Add(Kunde_Strafen);
            Controls.Add(Kunde_Abmelden);
            Controls.Add(Kunde_Reservierungen);
            Controls.Add(Kunde_Rueckgabe);
            Controls.Add(Kunde_Suche);
            Controls.Add(KundenHUB);
            MaximizeBox = false;
            MaximumSize = new Size(800, 600);
            MinimizeBox = false;
            MinimumSize = new Size(800, 600);
            Name = "KundeMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KundeMain";
            FormClosing += KundenMain;
            Load += KundeMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label KundenHUB;
        private Button Kunde_Suche;
        private Button Kunde_Rueckgabe;
        private Button Kunde_Reservierungen;
        private Button Kunde_Abmelden;
        private Button Kunde_Strafen;
        
    }
}