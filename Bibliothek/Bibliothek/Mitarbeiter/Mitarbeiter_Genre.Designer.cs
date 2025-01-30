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
            Genre_Auswahl_neu = new ComboBox();
            Genre_Label_Genre = new Label();
            Genre_Name = new TextBox();
            Genre_Speichern = new Button();
            Genre_Zurueck = new Button();
            SuspendLayout();
            // 
            // Genre_Seitenname
            // 
            Genre_Seitenname.AutoSize = true;
            Genre_Seitenname.BackColor = Color.Transparent;
            Genre_Seitenname.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Genre_Seitenname.ForeColor = Color.Transparent;
            Genre_Seitenname.Location = new Point(307, 9);
            Genre_Seitenname.Name = "Genre_Seitenname";
            Genre_Seitenname.Size = new Size(110, 37);
            Genre_Seitenname.TabIndex = 8;
            Genre_Seitenname.Text = "Genre";
            Genre_Seitenname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Genre_Auswahl_neu
            // 
            Genre_Auswahl_neu.FormattingEnabled = true;
            Genre_Auswahl_neu.Location = new Point(176, 76);
            Genre_Auswahl_neu.Name = "Genre_Auswahl_neu";
            Genre_Auswahl_neu.Size = new Size(399, 23);
            Genre_Auswahl_neu.TabIndex = 12;
            Genre_Auswahl_neu.Text = "Genre auswählen";
            Genre_Auswahl_neu.MouseEnter += mitarbeiter_Genre_MouseEnter;
            Genre_Auswahl_neu.MouseLeave += mitarbeiter_Genre_MouseLeave;
            // 
            // Genre_Label_Genre
            // 
            Genre_Label_Genre.AutoSize = true;
            Genre_Label_Genre.BackColor = Color.Transparent;
            Genre_Label_Genre.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Genre_Label_Genre.ForeColor = SystemColors.ButtonHighlight;
            Genre_Label_Genre.Location = new Point(176, 133);
            Genre_Label_Genre.Name = "Genre_Label_Genre";
            Genre_Label_Genre.Size = new Size(59, 20);
            Genre_Label_Genre.TabIndex = 13;
            Genre_Label_Genre.Text = "Genre";
            // 
            // Genre_Name
            // 
            Genre_Name.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Genre_Name.Location = new Point(261, 130);
            Genre_Name.Name = "Genre_Name";
            Genre_Name.Size = new Size(314, 26);
            Genre_Name.TabIndex = 18;
            Genre_Name.TextAlign = HorizontalAlignment.Center;
            Genre_Name.MouseEnter += mitarbeiter_Genre_MouseEnter;
            Genre_Name.MouseLeave += mitarbeiter_Genre_MouseLeave;
            // 
            // Genre_Speichern
            // 
            Genre_Speichern.BackColor = Color.Transparent;
            Genre_Speichern.FlatStyle = FlatStyle.Popup;
            Genre_Speichern.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Genre_Speichern.ForeColor = SystemColors.Control;
            Genre_Speichern.Location = new Point(561, 270);
            Genre_Speichern.Name = "Genre_Speichern";
            Genre_Speichern.Size = new Size(211, 165);
            Genre_Speichern.TabIndex = 25;
            Genre_Speichern.Text = "Speichern";
            Genre_Speichern.UseVisualStyleBackColor = false;
            Genre_Speichern.MouseEnter += mitarbeiter_Genre_MouseEnter;
            Genre_Speichern.MouseLeave += mitarbeiter_Genre_MouseLeave;
            // 
            // Genre_Zurueck
            // 
            Genre_Zurueck.BackColor = Color.Transparent;
            Genre_Zurueck.FlatStyle = FlatStyle.Popup;
            Genre_Zurueck.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Genre_Zurueck.ForeColor = SystemColors.Control;
            Genre_Zurueck.Location = new Point(561, 466);
            Genre_Zurueck.Name = "Genre_Zurueck";
            Genre_Zurueck.Size = new Size(211, 83);
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
            ClientSize = new Size(784, 561);
            Controls.Add(Genre_Zurueck);
            Controls.Add(Genre_Speichern);
            Controls.Add(Genre_Name);
            Controls.Add(Genre_Label_Genre);
            Controls.Add(Genre_Auswahl_neu);
            Controls.Add(Genre_Seitenname);
            MaximizeBox = false;
            MaximumSize = new Size(800, 600);
            MinimizeBox = false;
            MinimumSize = new Size(800, 600);
            Name = "Mitarbeiter_Genre";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mitarbeiter_Genre";
            FormClosing += mitarbeiter_Genre;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Genre_Seitenname;
        private ComboBox Genre_Auswahl_neu;
        private Label Genre_Label_Genre;
        private TextBox Genre_Name;
        private Button Genre_Speichern;
        private Button Genre_Zurueck;
    }
}