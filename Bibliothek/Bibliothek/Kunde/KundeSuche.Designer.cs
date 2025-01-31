namespace Bibliothek.Kunde
{
    partial class KundeSuche
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
            KundenSuche_Seitenname = new Label();
            KundenSuche_Suche = new TextBox();
            KundenSuche_Suchen = new Button();
            buecher_Zurueck = new Button();
            dataGridView1 = new DataGridView();
            KundeSuche_Ausleihen = new Button();
            KundeSuche_Reservieren = new Button();
            Titel = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            Genre = new DataGridViewTextBoxColumn();
            ISBN = new DataGridViewTextBoxColumn();
            KundeSuche_Sortieren = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // KundenSuche_Seitenname
            // 
            KundenSuche_Seitenname.AutoSize = true;
            KundenSuche_Seitenname.BackColor = Color.Transparent;
            KundenSuche_Seitenname.Font = new Font("Microsoft Sans Serif", 28.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KundenSuche_Seitenname.ForeColor = Color.Transparent;
            KundenSuche_Seitenname.Location = new Point(263, 9);
            KundenSuche_Seitenname.Name = "KundenSuche_Seitenname";
            KundenSuche_Seitenname.Size = new Size(240, 44);
            KundenSuche_Seitenname.TabIndex = 8;
            KundenSuche_Seitenname.Text = "Büchersuche";
            KundenSuche_Seitenname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // KundenSuche_Suche
            // 
            KundenSuche_Suche.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KundenSuche_Suche.Location = new Point(35, 79);
            KundenSuche_Suche.Name = "KundenSuche_Suche";
            KundenSuche_Suche.Size = new Size(453, 26);
            KundenSuche_Suche.TabIndex = 14;
            KundenSuche_Suche.Text = "Suche - Titel - Autor oder Genre eingeben";
            KundenSuche_Suche.TextAlign = HorizontalAlignment.Center;
            // 
            // KundenSuche_Suchen
            // 
            KundenSuche_Suchen.BackColor = Color.Transparent;
            KundenSuche_Suchen.FlatStyle = FlatStyle.Popup;
            KundenSuche_Suchen.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KundenSuche_Suchen.ForeColor = SystemColors.Control;
            KundenSuche_Suchen.Location = new Point(533, 69);
            KundenSuche_Suchen.Name = "KundenSuche_Suchen";
            KundenSuche_Suchen.Size = new Size(211, 41);
            KundenSuche_Suchen.TabIndex = 29;
            KundenSuche_Suchen.Text = "Suchen";
            KundenSuche_Suchen.UseVisualStyleBackColor = false;
            // 
            // buecher_Zurueck
            // 
            buecher_Zurueck.BackColor = Color.Transparent;
            buecher_Zurueck.FlatStyle = FlatStyle.Popup;
            buecher_Zurueck.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buecher_Zurueck.ForeColor = SystemColors.Control;
            buecher_Zurueck.Location = new Point(561, 485);
            buecher_Zurueck.Name = "buecher_Zurueck";
            buecher_Zurueck.Size = new Size(211, 64);
            buecher_Zurueck.TabIndex = 30;
            buecher_Zurueck.Text = "Zurück";
            buecher_Zurueck.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Titel, Autor, Genre, ISBN });
            dataGridView1.Location = new Point(12, 145);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(760, 334);
            dataGridView1.TabIndex = 31;
            // 
            // KundeSuche_Ausleihen
            // 
            KundeSuche_Ausleihen.BackColor = Color.Transparent;
            KundeSuche_Ausleihen.FlatStyle = FlatStyle.Popup;
            KundeSuche_Ausleihen.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KundeSuche_Ausleihen.ForeColor = SystemColors.Control;
            KundeSuche_Ausleihen.Location = new Point(12, 485);
            KundeSuche_Ausleihen.Name = "KundeSuche_Ausleihen";
            KundeSuche_Ausleihen.Size = new Size(211, 64);
            KundeSuche_Ausleihen.TabIndex = 32;
            KundeSuche_Ausleihen.Text = "Ausleihen";
            KundeSuche_Ausleihen.UseVisualStyleBackColor = false;
            // 
            // KundeSuche_Reservieren
            // 
            KundeSuche_Reservieren.BackColor = Color.Transparent;
            KundeSuche_Reservieren.FlatStyle = FlatStyle.Popup;
            KundeSuche_Reservieren.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KundeSuche_Reservieren.ForeColor = SystemColors.Control;
            KundeSuche_Reservieren.Location = new Point(277, 485);
            KundeSuche_Reservieren.Name = "KundeSuche_Reservieren";
            KundeSuche_Reservieren.Size = new Size(211, 64);
            KundeSuche_Reservieren.TabIndex = 33;
            KundeSuche_Reservieren.Text = "Reservieren";
            KundeSuche_Reservieren.UseVisualStyleBackColor = false;
            // 
            // Titel
            // 
            Titel.HeaderText = "Titel";
            Titel.Name = "Titel";
            Titel.Width = 250;
            // 
            // Autor
            // 
            Autor.HeaderText = "Autor";
            Autor.Name = "Autor";
            Autor.Width = 150;
            // 
            // Genre
            // 
            Genre.HeaderText = "Genre";
            Genre.Name = "Genre";
            Genre.Width = 120;
            // 
            // ISBN
            // 
            ISBN.HeaderText = "ISBN";
            ISBN.Name = "ISBN";
            ISBN.Width = 150;
            // 
            // KundeSuche_Sortieren
            // 
            KundeSuche_Sortieren.FormattingEnabled = true;
            KundeSuche_Sortieren.Location = new Point(35, 111);
            KundeSuche_Sortieren.Name = "KundeSuche_Sortieren";
            KundeSuche_Sortieren.Size = new Size(142, 28);
            KundeSuche_Sortieren.TabIndex = 34;
            KundeSuche_Sortieren.Text = "Sortieren nach";
            // 
            // KundeSuche
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.Hintergrund800x600;
            ClientSize = new Size(784, 561);
            Controls.Add(KundeSuche_Sortieren);
            Controls.Add(KundeSuche_Reservieren);
            Controls.Add(KundeSuche_Ausleihen);
            Controls.Add(dataGridView1);
            Controls.Add(buecher_Zurueck);
            Controls.Add(KundenSuche_Suchen);
            Controls.Add(KundenSuche_Suche);
            Controls.Add(KundenSuche_Seitenname);
            Font = new Font("Microsoft Sans Serif", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(800, 600);
            MinimizeBox = false;
            MinimumSize = new Size(800, 600);
            Name = "KundeSuche";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KundeSuche";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label KundenSuche_Seitenname;
        private TextBox KundenSuche_Suche;
        private Button KundenSuche_Suchen;
        private Button buecher_Zurueck;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Titel;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn Genre;
        private DataGridViewTextBoxColumn ISBN;
        private Button KundeSuche_Ausleihen;
        private Button KundeSuche_Reservieren;
        private ComboBox KundeSuche_Sortieren;
    }
}