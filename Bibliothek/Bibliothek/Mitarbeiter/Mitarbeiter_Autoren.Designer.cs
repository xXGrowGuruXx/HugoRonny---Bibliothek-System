namespace Bibliothek.Mitarbeiter
{
    partial class Mitarbeiter_Autoren
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mitarbeiter_Autoren));
            Autoren_Seitenname = new Label();
            Autoren_Auswahl_neu = new ComboBox();
            Autoren_Label_Name = new Label();
            Autoren_Name = new TextBox();
            Autoren_Speichern = new Button();
            Autoren_Zurueck = new Button();
            SuspendLayout();
            // 
            // Autoren_Seitenname
            // 
            Autoren_Seitenname.AutoSize = true;
            Autoren_Seitenname.BackColor = Color.Transparent;
            Autoren_Seitenname.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Autoren_Seitenname.ForeColor = Color.Transparent;
            Autoren_Seitenname.Location = new Point(312, 9);
            Autoren_Seitenname.Name = "Autoren_Seitenname";
            Autoren_Seitenname.Size = new Size(137, 37);
            Autoren_Seitenname.TabIndex = 7;
            Autoren_Seitenname.Text = "Autoren";
            Autoren_Seitenname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Autoren_Auswahl_neu
            // 
            Autoren_Auswahl_neu.FormattingEnabled = true;
            Autoren_Auswahl_neu.Location = new Point(174, 73);
            Autoren_Auswahl_neu.Name = "Autoren_Auswahl_neu";
            Autoren_Auswahl_neu.Size = new Size(399, 23);
            Autoren_Auswahl_neu.TabIndex = 11;
            Autoren_Auswahl_neu.Text = "Autor auswählen";
            Autoren_Auswahl_neu.MouseEnter += mitarbeiter_Autoren_MouseEnter;
            Autoren_Auswahl_neu.MouseLeave += mitarbeiter_Autoren_MouseLeave;
            // 
            // Autoren_Label_Name
            // 
            Autoren_Label_Name.AutoSize = true;
            Autoren_Label_Name.BackColor = Color.Transparent;
            Autoren_Label_Name.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Autoren_Label_Name.ForeColor = SystemColors.ButtonHighlight;
            Autoren_Label_Name.Location = new Point(174, 137);
            Autoren_Label_Name.Name = "Autoren_Label_Name";
            Autoren_Label_Name.Size = new Size(55, 20);
            Autoren_Label_Name.TabIndex = 12;
            Autoren_Label_Name.Text = "Name";
            // 
            // Autoren_Name
            // 
            Autoren_Name.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Autoren_Name.Location = new Point(259, 131);
            Autoren_Name.Name = "Autoren_Name";
            Autoren_Name.Size = new Size(314, 26);
            Autoren_Name.TabIndex = 17;
            Autoren_Name.TextAlign = HorizontalAlignment.Center;
            Autoren_Name.MouseEnter += mitarbeiter_Autoren_MouseEnter;
            Autoren_Name.MouseLeave += mitarbeiter_Autoren_MouseLeave;
            // 
            // Autoren_Speichern
            // 
            Autoren_Speichern.BackColor = Color.Transparent;
            Autoren_Speichern.FlatStyle = FlatStyle.Popup;
            Autoren_Speichern.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Autoren_Speichern.ForeColor = SystemColors.Control;
            Autoren_Speichern.Location = new Point(561, 216);
            Autoren_Speichern.Name = "Autoren_Speichern";
            Autoren_Speichern.Size = new Size(211, 165);
            Autoren_Speichern.TabIndex = 24;
            Autoren_Speichern.Text = "Speichern";
            Autoren_Speichern.UseVisualStyleBackColor = false;
            Autoren_Speichern.MouseEnter += mitarbeiter_Autoren_MouseEnter;
            Autoren_Speichern.MouseLeave += mitarbeiter_Autoren_MouseLeave;
            // 
            // Autoren_Zurueck
            // 
            Autoren_Zurueck.BackColor = Color.Transparent;
            Autoren_Zurueck.FlatStyle = FlatStyle.Popup;
            Autoren_Zurueck.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Autoren_Zurueck.ForeColor = SystemColors.Control;
            Autoren_Zurueck.Location = new Point(561, 466);
            Autoren_Zurueck.Name = "Autoren_Zurueck";
            Autoren_Zurueck.Size = new Size(211, 83);
            Autoren_Zurueck.TabIndex = 26;
            Autoren_Zurueck.Text = "Zurück";
            Autoren_Zurueck.UseVisualStyleBackColor = false;
            Autoren_Zurueck.Click += mitarbeiter_Autoren_Abbrechen_Click;
            Autoren_Zurueck.MouseEnter += mitarbeiter_Autoren_MouseEnter;
            Autoren_Zurueck.MouseLeave += mitarbeiter_Autoren_MouseLeave;
            // 
            // Mitarbeiter_Autoren
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.Hintergrund800x600;
            ClientSize = new Size(784, 561);
            Controls.Add(Autoren_Zurueck);
            Controls.Add(Autoren_Speichern);
            Controls.Add(Autoren_Name);
            Controls.Add(Autoren_Label_Name);
            Controls.Add(Autoren_Auswahl_neu);
            Controls.Add(Autoren_Seitenname);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(800, 600);
            MinimizeBox = false;
            MinimumSize = new Size(800, 600);
            Name = "Mitarbeiter_Autoren";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mitarbeiter_Autoren";
            FormClosing += mitarbeiter_Autoren;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Autoren_Seitenname;
        private ComboBox Autoren_Auswahl_neu;
        private Label Autoren_Label_Name;
        private TextBox Autoren_Name;
        private Button Autoren_Speichern;
        private Button Autoren_Zurueck;
    }
}