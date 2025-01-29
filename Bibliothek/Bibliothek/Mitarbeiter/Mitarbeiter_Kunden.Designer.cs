namespace Bibliothek.Mitarbeiter
{
    partial class Mitarbeiter_Kunden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mitarbeiter_Kunden));
            kunden_Seitenname = new Label();
            kunden_Label_Username = new Label();
            kunden_Username = new TextBox();
            kunden_Auswahl_neu = new ComboBox();
            kunden_Label_Name = new Label();
            kunden_Label_Vorname = new Label();
            kunden_Label_Strasse = new Label();
            kunden_Label_Ort = new Label();
            kunden_Label_PLZ = new Label();
            kunden_Name = new TextBox();
            kunden_Vorname = new TextBox();
            kunden_Strasse = new TextBox();
            kunden_Ort = new TextBox();
            kunden_PLZ = new TextBox();
            kunden_Speichern = new Button();
            kunden_deaktivieren = new Button();
            kunden_Zurueck = new Button();
            kunden_Reservierungen = new Button();
            kunden_Ausgeliehen = new Button();
            Kunden_Testlabel = new Label();
            SuspendLayout();
            // 
            // kunden_Seitenname
            // 
            kunden_Seitenname.AutoSize = true;
            kunden_Seitenname.BackColor = Color.Transparent;
            kunden_Seitenname.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kunden_Seitenname.ForeColor = Color.Transparent;
            kunden_Seitenname.Location = new Point(315, 9);
            kunden_Seitenname.Name = "kunden_Seitenname";
            kunden_Seitenname.Size = new Size(143, 37);
            kunden_Seitenname.TabIndex = 6;
            kunden_Seitenname.Text = "Kunden ";
            kunden_Seitenname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // kunden_Label_Username
            // 
            kunden_Label_Username.AutoSize = true;
            kunden_Label_Username.BackColor = Color.Transparent;
            kunden_Label_Username.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kunden_Label_Username.ForeColor = SystemColors.ButtonHighlight;
            kunden_Label_Username.Location = new Point(39, 94);
            kunden_Label_Username.Name = "kunden_Label_Username";
            kunden_Label_Username.Size = new Size(91, 20);
            kunden_Label_Username.TabIndex = 8;
            kunden_Label_Username.Text = "Username";
            // 
            // kunden_Username
            // 
            kunden_Username.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kunden_Username.Location = new Point(187, 88);
            kunden_Username.Name = "kunden_Username";
            kunden_Username.Size = new Size(251, 26);
            kunden_Username.TabIndex = 9;
            kunden_Username.TextAlign = HorizontalAlignment.Center;
            kunden_Username.MouseEnter += mitarbeiter_Kunden_MouseEnter;
            kunden_Username.MouseLeave += mitarbeiter_Kunden_MouseLeave;
            // 
            // kunden_Auswahl_neu
            // 
            kunden_Auswahl_neu.FormattingEnabled = true;
            kunden_Auswahl_neu.Location = new Point(39, 51);
            kunden_Auswahl_neu.Name = "kunden_Auswahl_neu";
            kunden_Auswahl_neu.Size = new Size(399, 23);
            kunden_Auswahl_neu.TabIndex = 10;
            kunden_Auswahl_neu.Text = "Kunde auswählen";
            kunden_Auswahl_neu.MouseEnter += mitarbeiter_Kunden_MouseEnter;
            kunden_Auswahl_neu.MouseLeave += mitarbeiter_Kunden_MouseLeave;
            // 
            // kunden_Label_Name
            // 
            kunden_Label_Name.AutoSize = true;
            kunden_Label_Name.BackColor = Color.Transparent;
            kunden_Label_Name.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kunden_Label_Name.ForeColor = SystemColors.ButtonHighlight;
            kunden_Label_Name.Location = new Point(39, 144);
            kunden_Label_Name.Name = "kunden_Label_Name";
            kunden_Label_Name.Size = new Size(55, 20);
            kunden_Label_Name.TabIndex = 11;
            kunden_Label_Name.Text = "Name";
            // 
            // kunden_Label_Vorname
            // 
            kunden_Label_Vorname.AutoSize = true;
            kunden_Label_Vorname.BackColor = Color.Transparent;
            kunden_Label_Vorname.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kunden_Label_Vorname.ForeColor = SystemColors.ButtonHighlight;
            kunden_Label_Vorname.Location = new Point(39, 192);
            kunden_Label_Vorname.Name = "kunden_Label_Vorname";
            kunden_Label_Vorname.Size = new Size(81, 20);
            kunden_Label_Vorname.TabIndex = 12;
            kunden_Label_Vorname.Text = "Vorname";
            // 
            // kunden_Label_Strasse
            // 
            kunden_Label_Strasse.AutoSize = true;
            kunden_Label_Strasse.BackColor = Color.Transparent;
            kunden_Label_Strasse.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kunden_Label_Strasse.ForeColor = SystemColors.ButtonHighlight;
            kunden_Label_Strasse.Location = new Point(39, 248);
            kunden_Label_Strasse.Name = "kunden_Label_Strasse";
            kunden_Label_Strasse.Size = new Size(71, 20);
            kunden_Label_Strasse.TabIndex = 13;
            kunden_Label_Strasse.Text = "Strasse";
            // 
            // kunden_Label_Ort
            // 
            kunden_Label_Ort.AutoSize = true;
            kunden_Label_Ort.BackColor = Color.Transparent;
            kunden_Label_Ort.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kunden_Label_Ort.ForeColor = SystemColors.ButtonHighlight;
            kunden_Label_Ort.Location = new Point(39, 304);
            kunden_Label_Ort.Name = "kunden_Label_Ort";
            kunden_Label_Ort.Size = new Size(34, 20);
            kunden_Label_Ort.TabIndex = 14;
            kunden_Label_Ort.Text = "Ort";
            // 
            // kunden_Label_PLZ
            // 
            kunden_Label_PLZ.AutoSize = true;
            kunden_Label_PLZ.BackColor = Color.Transparent;
            kunden_Label_PLZ.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kunden_Label_PLZ.ForeColor = SystemColors.ButtonHighlight;
            kunden_Label_PLZ.Location = new Point(39, 360);
            kunden_Label_PLZ.Name = "kunden_Label_PLZ";
            kunden_Label_PLZ.Size = new Size(41, 20);
            kunden_Label_PLZ.TabIndex = 15;
            kunden_Label_PLZ.Text = "PLZ";
            // 
            // kunden_Name
            // 
            kunden_Name.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kunden_Name.Location = new Point(187, 138);
            kunden_Name.Name = "kunden_Name";
            kunden_Name.Size = new Size(251, 26);
            kunden_Name.TabIndex = 16;
            kunden_Name.TextAlign = HorizontalAlignment.Center;
            kunden_Name.MouseEnter += mitarbeiter_Kunden_MouseEnter;
            kunden_Name.MouseLeave += mitarbeiter_Kunden_MouseLeave;
            // 
            // kunden_Vorname
            // 
            kunden_Vorname.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kunden_Vorname.Location = new Point(187, 186);
            kunden_Vorname.Name = "kunden_Vorname";
            kunden_Vorname.Size = new Size(251, 26);
            kunden_Vorname.TabIndex = 17;
            kunden_Vorname.TextAlign = HorizontalAlignment.Center;
            kunden_Vorname.MouseEnter += mitarbeiter_Kunden_MouseEnter;
            kunden_Vorname.MouseLeave += mitarbeiter_Kunden_MouseLeave;
            // 
            // kunden_Strasse
            // 
            kunden_Strasse.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kunden_Strasse.Location = new Point(187, 242);
            kunden_Strasse.Name = "kunden_Strasse";
            kunden_Strasse.Size = new Size(251, 26);
            kunden_Strasse.TabIndex = 18;
            kunden_Strasse.TextAlign = HorizontalAlignment.Center;
            kunden_Strasse.MouseEnter += mitarbeiter_Kunden_MouseEnter;
            kunden_Strasse.MouseLeave += mitarbeiter_Kunden_MouseLeave;
            // 
            // kunden_Ort
            // 
            kunden_Ort.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kunden_Ort.Location = new Point(187, 298);
            kunden_Ort.Name = "kunden_Ort";
            kunden_Ort.Size = new Size(251, 26);
            kunden_Ort.TabIndex = 19;
            kunden_Ort.TextAlign = HorizontalAlignment.Center;
            kunden_Ort.MouseEnter += mitarbeiter_Kunden_MouseEnter;
            kunden_Ort.MouseLeave += mitarbeiter_Kunden_MouseLeave;
            // 
            // kunden_PLZ
            // 
            kunden_PLZ.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kunden_PLZ.Location = new Point(187, 354);
            kunden_PLZ.Name = "kunden_PLZ";
            kunden_PLZ.Size = new Size(251, 26);
            kunden_PLZ.TabIndex = 20;
            kunden_PLZ.TextAlign = HorizontalAlignment.Center;
            kunden_PLZ.MouseEnter += mitarbeiter_Kunden_MouseEnter;
            kunden_PLZ.MouseLeave += mitarbeiter_Kunden_MouseLeave;
            // 
            // kunden_Speichern
            // 
            kunden_Speichern.BackColor = Color.Transparent;
            kunden_Speichern.FlatStyle = FlatStyle.Popup;
            kunden_Speichern.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kunden_Speichern.ForeColor = SystemColors.Control;
            kunden_Speichern.Location = new Point(564, 88);
            kunden_Speichern.Name = "kunden_Speichern";
            kunden_Speichern.Size = new Size(211, 165);
            kunden_Speichern.TabIndex = 23;
            kunden_Speichern.Text = "Speichern";
            kunden_Speichern.UseVisualStyleBackColor = false;
            kunden_Speichern.MouseEnter += mitarbeiter_Kunden_MouseEnter;
            kunden_Speichern.MouseLeave += mitarbeiter_Kunden_MouseLeave;
            // 
            // kunden_deaktivieren
            // 
            kunden_deaktivieren.BackColor = Color.Transparent;
            kunden_deaktivieren.FlatStyle = FlatStyle.Popup;
            kunden_deaktivieren.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kunden_deaktivieren.ForeColor = SystemColors.Control;
            kunden_deaktivieren.Location = new Point(564, 290);
            kunden_deaktivieren.Name = "kunden_deaktivieren";
            kunden_deaktivieren.Size = new Size(211, 90);
            kunden_deaktivieren.TabIndex = 24;
            kunden_deaktivieren.Text = "Konto deaktivieren";
            kunden_deaktivieren.UseVisualStyleBackColor = false;
            kunden_deaktivieren.MouseEnter += mitarbeiter_Kunden_MouseEnter;
            kunden_deaktivieren.MouseLeave += mitarbeiter_Kunden_MouseLeave;
            // 
            // kunden_Zurueck
            // 
            kunden_Zurueck.BackColor = Color.Transparent;
            kunden_Zurueck.FlatStyle = FlatStyle.Popup;
            kunden_Zurueck.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kunden_Zurueck.ForeColor = SystemColors.Control;
            kunden_Zurueck.Location = new Point(564, 466);
            kunden_Zurueck.Name = "kunden_Zurueck";
            kunden_Zurueck.Size = new Size(211, 83);
            kunden_Zurueck.TabIndex = 25;
            kunden_Zurueck.Text = "Zurück";
            kunden_Zurueck.UseVisualStyleBackColor = false;
            kunden_Zurueck.Click += mitarbeiter_Kunden_Abbrechen_Click;
            kunden_Zurueck.MouseEnter += mitarbeiter_Kunden_MouseEnter;
            kunden_Zurueck.MouseLeave += mitarbeiter_Kunden_MouseLeave;
            // 
            // kunden_Reservierungen
            // 
            kunden_Reservierungen.BackColor = Color.Transparent;
            kunden_Reservierungen.FlatStyle = FlatStyle.Popup;
            kunden_Reservierungen.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kunden_Reservierungen.ForeColor = SystemColors.Control;
            kunden_Reservierungen.Location = new Point(287, 466);
            kunden_Reservierungen.Name = "kunden_Reservierungen";
            kunden_Reservierungen.Size = new Size(211, 83);
            kunden_Reservierungen.TabIndex = 26;
            kunden_Reservierungen.Text = "Reservierungen anzeigen";
            kunden_Reservierungen.UseVisualStyleBackColor = false;
            kunden_Reservierungen.MouseEnter += mitarbeiter_Kunden_MouseEnter;
            kunden_Reservierungen.MouseLeave += mitarbeiter_Kunden_MouseLeave;
            // 
            // kunden_Ausgeliehen
            // 
            kunden_Ausgeliehen.BackColor = Color.Transparent;
            kunden_Ausgeliehen.FlatStyle = FlatStyle.Popup;
            kunden_Ausgeliehen.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kunden_Ausgeliehen.ForeColor = SystemColors.Control;
            kunden_Ausgeliehen.Location = new Point(12, 466);
            kunden_Ausgeliehen.Name = "kunden_Ausgeliehen";
            kunden_Ausgeliehen.Size = new Size(211, 83);
            kunden_Ausgeliehen.TabIndex = 27;
            kunden_Ausgeliehen.Text = "Ausgeliehen anzeigen";
            kunden_Ausgeliehen.UseVisualStyleBackColor = false;
            kunden_Ausgeliehen.MouseEnter += mitarbeiter_Kunden_MouseEnter;
            kunden_Ausgeliehen.MouseLeave += mitarbeiter_Kunden_MouseLeave;
            // 
            // Kunden_Testlabel
            // 
            Kunden_Testlabel.AutoSize = true;
            Kunden_Testlabel.Location = new Point(517, 31);
            Kunden_Testlabel.Name = "Kunden_Testlabel";
            Kunden_Testlabel.Size = new Size(52, 15);
            Kunden_Testlabel.TabIndex = 28;
            Kunden_Testlabel.Text = "Testlabel";
            // 
            // Mitarbeiter_Kunden
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Hintergrund800x600;
            ClientSize = new Size(784, 561);
            Controls.Add(Kunden_Testlabel);
            Controls.Add(kunden_Ausgeliehen);
            Controls.Add(kunden_Reservierungen);
            Controls.Add(kunden_Zurueck);
            Controls.Add(kunden_deaktivieren);
            Controls.Add(kunden_Speichern);
            Controls.Add(kunden_PLZ);
            Controls.Add(kunden_Ort);
            Controls.Add(kunden_Strasse);
            Controls.Add(kunden_Vorname);
            Controls.Add(kunden_Name);
            Controls.Add(kunden_Label_PLZ);
            Controls.Add(kunden_Label_Ort);
            Controls.Add(kunden_Label_Strasse);
            Controls.Add(kunden_Label_Vorname);
            Controls.Add(kunden_Label_Name);
            Controls.Add(kunden_Auswahl_neu);
            Controls.Add(kunden_Username);
            Controls.Add(kunden_Label_Username);
            Controls.Add(kunden_Seitenname);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Mitarbeiter_Kunden";
            Text = "Mitarbeiter_Kunden";
            FormClosing += mitarbeiter_Kunden;
            Load += Mitarbeiter_Kunden_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label kunden_Seitenname;
        private Label kunden_Label_Username;
        private TextBox kunden_Username;
        private ComboBox kunden_Auswahl_neu;
        private Label kunden_Label_Name;
        private Label kunden_Label_Vorname;
        private Label kunden_Label_Strasse;
        private Label kunden_Label_Ort;
        private Label kunden_Label_PLZ;
        private TextBox kunden_Name;
        private TextBox kunden_Vorname;
        private TextBox kunden_Strasse;
        private TextBox kunden_Ort;
        private TextBox kunden_PLZ;
        private Button kunden_Speichern;
        private Button kunden_deaktivieren;
        private Button kunden_Zurueck;
        private Button kunden_Reservierungen;
        private Button kunden_Ausgeliehen;
        private Label Kunden_Testlabel;
    }
}