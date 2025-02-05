namespace Bibliothek.Mitarbeiter
{
    partial class Mitarbeiter_Genre
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
            Genre_Seitenname = new Label();
            genre_Auswahl = new ComboBox();
            genre_Label_Name = new Label();
            genre_Name = new TextBox();
            Genre_Speichern = new Button();
            Genre_Zurueck = new Button();
            SuspendLayout();
            // 
            // Genre_Seitenname
            // 
            Genre_Seitenname.AutoSize = true;
            Genre_Seitenname.BackColor = Color.Transparent;
            Genre_Seitenname.Font = new Font("Vacaciones", 28.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Genre_Seitenname.ForeColor = Color.Transparent;
            Genre_Seitenname.Location = new Point(294, 59);
            Genre_Seitenname.Name = "Genre_Seitenname";
            Genre_Seitenname.Size = new Size(170, 65);
            Genre_Seitenname.TabIndex = 8;
            Genre_Seitenname.Text = "Genre";
            Genre_Seitenname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // genre_Auswahl
            // 
            genre_Auswahl.DropDownStyle = ComboBoxStyle.DropDownList;
            genre_Auswahl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genre_Auswahl.FormattingEnabled = true;
            genre_Auswahl.Location = new Point(146, 174);
            genre_Auswahl.Name = "genre_Auswahl";
            genre_Auswahl.Size = new Size(462, 39);
            genre_Auswahl.TabIndex = 12;
            genre_Auswahl.SelectedIndexChanged += genre_Auswahl_SelectedIndexChanged;
            genre_Auswahl.MouseEnter += mitarbeiter_Genre_MouseEnter;
            genre_Auswahl.MouseLeave += mitarbeiter_Genre_MouseLeave;
            // 
            // genre_Label_Name
            // 
            genre_Label_Name.AutoSize = true;
            genre_Label_Name.BackColor = Color.Transparent;
            genre_Label_Name.Font = new Font("Vacaciones", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genre_Label_Name.ForeColor = SystemColors.ButtonHighlight;
            genre_Label_Name.Location = new Point(146, 299);
            genre_Label_Name.Name = "genre_Label_Name";
            genre_Label_Name.Size = new Size(124, 47);
            genre_Label_Name.TabIndex = 13;
            genre_Label_Name.Text = "Genre";
            // 
            // genre_Name
            // 
            genre_Name.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genre_Name.Location = new Point(294, 304);
            genre_Name.Name = "genre_Name";
            genre_Name.Size = new Size(314, 41);
            genre_Name.TabIndex = 18;
            genre_Name.TextAlign = HorizontalAlignment.Center;
            genre_Name.MouseEnter += mitarbeiter_Genre_MouseEnter;
            genre_Name.MouseLeave += mitarbeiter_Genre_MouseLeave;
            // 
            // Genre_Speichern
            // 
            Genre_Speichern.BackColor = Color.Transparent;
            Genre_Speichern.FlatStyle = FlatStyle.Popup;
            Genre_Speichern.Font = new Font("Vacaciones", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Genre_Speichern.ForeColor = SystemColors.Control;
            Genre_Speichern.Location = new Point(146, 443);
            Genre_Speichern.Name = "Genre_Speichern";
            Genre_Speichern.Size = new Size(211, 66);
            Genre_Speichern.TabIndex = 25;
            Genre_Speichern.Text = "Speichern";
            Genre_Speichern.UseVisualStyleBackColor = false;
            Genre_Speichern.Click += Genre_Speichern_Click;
            Genre_Speichern.MouseEnter += mitarbeiter_Genre_MouseEnter;
            Genre_Speichern.MouseLeave += mitarbeiter_Genre_MouseLeave;
            // 
            // Genre_Zurueck
            // 
            Genre_Zurueck.BackColor = Color.Transparent;
            Genre_Zurueck.FlatStyle = FlatStyle.Popup;
            Genre_Zurueck.Font = new Font("Vacaciones", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Genre_Zurueck.ForeColor = SystemColors.Control;
            Genre_Zurueck.Location = new Point(397, 443);
            Genre_Zurueck.Name = "Genre_Zurueck";
            Genre_Zurueck.Size = new Size(211, 66);
            Genre_Zurueck.TabIndex = 27;
            Genre_Zurueck.Text = "Zurück";
            Genre_Zurueck.UseVisualStyleBackColor = false;
            Genre_Zurueck.Click += mitarbeiter_Genre_Abbrechen_Click;
            Genre_Zurueck.MouseEnter += mitarbeiter_Genre_MouseEnter;
            Genre_Zurueck.MouseLeave += mitarbeiter_Genre_MouseLeave;
            // 
            // Mitarbeiter_Genre
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.Hintergrund800x600;
            ClientSize = new Size(782, 553);
            Controls.Add(Genre_Zurueck);
            Controls.Add(Genre_Speichern);
            Controls.Add(genre_Name);
            Controls.Add(genre_Label_Name);
            Controls.Add(genre_Auswahl);
            Controls.Add(Genre_Seitenname);
            MaximizeBox = false;
            MaximumSize = new Size(800, 600);
            MinimizeBox = false;
            MinimumSize = new Size(800, 600);
            Name = "Mitarbeiter_Genre";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mitarbeiter_Genre";
            FormClosing += mitarbeiter_Genre;
            Load += mitarbeiter_Genre_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Genre_Seitenname;
        private ComboBox genre_Auswahl;
        private Label genre_Label_Name;
        private TextBox genre_Name;
        private Button Genre_Speichern;
        private Button Genre_Zurueck;
    }
}