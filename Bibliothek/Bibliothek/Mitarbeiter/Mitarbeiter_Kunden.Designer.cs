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
            kunden_Auswahl = new ComboBox();
            kunden_Label_Name = new Label();
            kunden_Label_Vorname = new Label();
            kunden_Name = new TextBox();
            kunden_Vorname = new TextBox();
            kunden_Speichern = new Button();
            kunden_Zurueck = new Button();
            kunden_Reservierungen = new Button();
            kunden_Ausgeliehen = new Button();
            SuspendLayout();
            // 
            // kunden_Seitenname
            // 
            kunden_Seitenname.AutoSize = true;
            kunden_Seitenname.BackColor = Color.Transparent;
            kunden_Seitenname.Font = new Font("Vacaciones", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kunden_Seitenname.ForeColor = Color.Transparent;
            kunden_Seitenname.Location = new Point(304, 9);
            kunden_Seitenname.Name = "kunden_Seitenname";
            kunden_Seitenname.Size = new Size(182, 55);
            kunden_Seitenname.TabIndex = 6;
            kunden_Seitenname.Text = "Kunden ";
            kunden_Seitenname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // kunden_Label_Username
            // 
            kunden_Label_Username.AutoSize = true;
            kunden_Label_Username.BackColor = Color.Transparent;
            kunden_Label_Username.Font = new Font("Vacaciones", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kunden_Label_Username.ForeColor = SystemColors.ButtonHighlight;
            kunden_Label_Username.Location = new Point(47, 207);
            kunden_Label_Username.Name = "kunden_Label_Username";
            kunden_Label_Username.Size = new Size(115, 28);
            kunden_Label_Username.TabIndex = 8;
            kunden_Label_Username.Text = "Username";
            // 
            // kunden_Username
            // 
            kunden_Username.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kunden_Username.Location = new Point(216, 199);
            kunden_Username.Margin = new Padding(3, 4, 3, 4);
            kunden_Username.Name = "kunden_Username";
            kunden_Username.Size = new Size(286, 30);
            kunden_Username.TabIndex = 9;
            kunden_Username.TextAlign = HorizontalAlignment.Center;
            kunden_Username.MouseEnter += mitarbeiter_Kunden_MouseEnter;
            kunden_Username.MouseLeave += mitarbeiter_Kunden_MouseLeave;
            // 
            // kunden_Auswahl
            // 
            kunden_Auswahl.DropDownStyle = ComboBoxStyle.DropDownList;
            kunden_Auswahl.FormattingEnabled = true;
            kunden_Auswahl.Location = new Point(47, 150);
            kunden_Auswahl.Margin = new Padding(3, 4, 3, 4);
            kunden_Auswahl.Name = "kunden_Auswahl";
            kunden_Auswahl.Size = new Size(455, 28);
            kunden_Auswahl.TabIndex = 10;
            kunden_Auswahl.MouseEnter += mitarbeiter_Kunden_MouseEnter;
            kunden_Auswahl.MouseLeave += mitarbeiter_Kunden_MouseLeave;
            // 
            // kunden_Label_Name
            // 
            kunden_Label_Name.AutoSize = true;
            kunden_Label_Name.BackColor = Color.Transparent;
            kunden_Label_Name.Font = new Font("Vacaciones", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kunden_Label_Name.ForeColor = SystemColors.ButtonHighlight;
            kunden_Label_Name.Location = new Point(47, 274);
            kunden_Label_Name.Name = "kunden_Label_Name";
            kunden_Label_Name.Size = new Size(69, 28);
            kunden_Label_Name.TabIndex = 11;
            kunden_Label_Name.Text = "Name";
            // 
            // kunden_Label_Vorname
            // 
            kunden_Label_Vorname.AutoSize = true;
            kunden_Label_Vorname.BackColor = Color.Transparent;
            kunden_Label_Vorname.Font = new Font("Vacaciones", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kunden_Label_Vorname.ForeColor = SystemColors.ButtonHighlight;
            kunden_Label_Vorname.Location = new Point(47, 338);
            kunden_Label_Vorname.Name = "kunden_Label_Vorname";
            kunden_Label_Vorname.Size = new Size(105, 28);
            kunden_Label_Vorname.TabIndex = 12;
            kunden_Label_Vorname.Text = "Vorname";
            // 
            // kunden_Name
            // 
            kunden_Name.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kunden_Name.Location = new Point(216, 266);
            kunden_Name.Margin = new Padding(3, 4, 3, 4);
            kunden_Name.Name = "kunden_Name";
            kunden_Name.Size = new Size(286, 30);
            kunden_Name.TabIndex = 16;
            kunden_Name.TextAlign = HorizontalAlignment.Center;
            kunden_Name.MouseEnter += mitarbeiter_Kunden_MouseEnter;
            kunden_Name.MouseLeave += mitarbeiter_Kunden_MouseLeave;
            // 
            // kunden_Vorname
            // 
            kunden_Vorname.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kunden_Vorname.Location = new Point(216, 330);
            kunden_Vorname.Margin = new Padding(3, 4, 3, 4);
            kunden_Vorname.Name = "kunden_Vorname";
            kunden_Vorname.Size = new Size(286, 30);
            kunden_Vorname.TabIndex = 17;
            kunden_Vorname.TextAlign = HorizontalAlignment.Center;
            kunden_Vorname.MouseEnter += mitarbeiter_Kunden_MouseEnter;
            kunden_Vorname.MouseLeave += mitarbeiter_Kunden_MouseLeave;
            // 
            // kunden_Speichern
            // 
            kunden_Speichern.BackColor = Color.Transparent;
            kunden_Speichern.FlatStyle = FlatStyle.Popup;
            kunden_Speichern.Font = new Font("Vacaciones", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kunden_Speichern.ForeColor = SystemColors.Control;
            kunden_Speichern.Location = new Point(87, 449);
            kunden_Speichern.Margin = new Padding(3, 4, 3, 4);
            kunden_Speichern.Name = "kunden_Speichern";
            kunden_Speichern.Size = new Size(197, 91);
            kunden_Speichern.TabIndex = 23;
            kunden_Speichern.Text = "Speichern";
            kunden_Speichern.UseVisualStyleBackColor = false;
            kunden_Speichern.MouseEnter += mitarbeiter_Kunden_MouseEnter;
            kunden_Speichern.MouseLeave += mitarbeiter_Kunden_MouseLeave;
            // 
            // kunden_Zurueck
            // 
            kunden_Zurueck.BackColor = Color.Transparent;
            kunden_Zurueck.FlatStyle = FlatStyle.Popup;
            kunden_Zurueck.Font = new Font("Vacaciones", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kunden_Zurueck.ForeColor = SystemColors.Control;
            kunden_Zurueck.Location = new Point(498, 459);
            kunden_Zurueck.Margin = new Padding(3, 4, 3, 4);
            kunden_Zurueck.Name = "kunden_Zurueck";
            kunden_Zurueck.Size = new Size(169, 70);
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
            kunden_Reservierungen.Font = new Font("Vacaciones", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kunden_Reservierungen.ForeColor = SystemColors.Control;
            kunden_Reservierungen.Location = new Point(508, 269);
            kunden_Reservierungen.Margin = new Padding(3, 4, 3, 4);
            kunden_Reservierungen.Name = "kunden_Reservierungen";
            kunden_Reservierungen.Size = new Size(262, 91);
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
            kunden_Ausgeliehen.Font = new Font("Vacaciones", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kunden_Ausgeliehen.ForeColor = SystemColors.Control;
            kunden_Ausgeliehen.Location = new Point(525, 150);
            kunden_Ausgeliehen.Margin = new Padding(3, 4, 3, 4);
            kunden_Ausgeliehen.Name = "kunden_Ausgeliehen";
            kunden_Ausgeliehen.Size = new Size(214, 91);
            kunden_Ausgeliehen.TabIndex = 27;
            kunden_Ausgeliehen.Text = "Ausgeliehen anzeigen";
            kunden_Ausgeliehen.UseVisualStyleBackColor = false;
            kunden_Ausgeliehen.MouseEnter += mitarbeiter_Kunden_MouseEnter;
            kunden_Ausgeliehen.MouseLeave += mitarbeiter_Kunden_MouseLeave;
            // 
            // Mitarbeiter_Kunden
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Hintergrund800x600;
            ClientSize = new Size(782, 553);
            Controls.Add(kunden_Ausgeliehen);
            Controls.Add(kunden_Reservierungen);
            Controls.Add(kunden_Zurueck);
            Controls.Add(kunden_Speichern);
            Controls.Add(kunden_Vorname);
            Controls.Add(kunden_Name);
            Controls.Add(kunden_Label_Vorname);
            Controls.Add(kunden_Label_Name);
            Controls.Add(kunden_Auswahl);
            Controls.Add(kunden_Username);
            Controls.Add(kunden_Label_Username);
            Controls.Add(kunden_Seitenname);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Mitarbeiter_Kunden";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mitarbeiter Kunden";
            FormClosing += mitarbeiter_Kunden;
            Load += Mitarbeiter_Kunden_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label kunden_Seitenname;
        private Label kunden_Label_Username;
        private TextBox kunden_Username;
        private ComboBox kunden_Auswahl;
        private Label kunden_Label_Name;
        private Label kunden_Label_Vorname;
        private TextBox kunden_Name;
        private TextBox kunden_Vorname;
        private Button kunden_Speichern;
        private Button kunden_Zurueck;
        private Button kunden_Reservierungen;
        private Button kunden_Ausgeliehen;
    }
}