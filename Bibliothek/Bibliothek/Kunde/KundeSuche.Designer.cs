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
            KundeSuche_Seitenname = new Label();
            KundeSuche_Zurück = new Button();
            KundeSuche_Ausleihen = new Button();
            KundeSuche_Reservieren = new Button();
            kundeSuche_Menue = new MenuStrip();
            menu_Bücher = new ToolStripMenuItem();
            menu_Autor = new ToolStripMenuItem();
            menu_Genre = new ToolStripMenuItem();
            menu_ISBN = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            kundeSuche_Menue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // KundeSuche_Seitenname
            // 
            KundeSuche_Seitenname.AutoSize = true;
            KundeSuche_Seitenname.BackColor = Color.Transparent;
            KundeSuche_Seitenname.Font = new Font("Microsoft Sans Serif", 28.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KundeSuche_Seitenname.ForeColor = Color.Transparent;
            KundeSuche_Seitenname.Location = new Point(263, 9);
            KundeSuche_Seitenname.Name = "KundeSuche_Seitenname";
            KundeSuche_Seitenname.Size = new Size(240, 44);
            KundeSuche_Seitenname.TabIndex = 8;
            KundeSuche_Seitenname.Text = "Büchersuche";
            KundeSuche_Seitenname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // KundeSuche_Zurück
            // 
            KundeSuche_Zurück.BackColor = Color.Transparent;
            KundeSuche_Zurück.FlatStyle = FlatStyle.Popup;
            KundeSuche_Zurück.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KundeSuche_Zurück.ForeColor = SystemColors.Control;
            KundeSuche_Zurück.Location = new Point(561, 485);
            KundeSuche_Zurück.Name = "KundeSuche_Zurück";
            KundeSuche_Zurück.Size = new Size(211, 64);
            KundeSuche_Zurück.TabIndex = 30;
            KundeSuche_Zurück.Text = "Zurück";
            KundeSuche_Zurück.UseVisualStyleBackColor = false;
            KundeSuche_Zurück.Click += Kunde_Suche_Abbrechen_Click;
            KundeSuche_Zurück.MouseEnter += Kunde_Suche_MouseEnter;
            KundeSuche_Zurück.MouseLeave += Kunde_Suche_MouseLeave;
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
            KundeSuche_Ausleihen.MouseEnter += Kunde_Suche_MouseEnter;
            KundeSuche_Ausleihen.MouseLeave += Kunde_Suche_MouseLeave;
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
            KundeSuche_Reservieren.MouseEnter += Kunde_Suche_MouseEnter;
            KundeSuche_Reservieren.MouseLeave += Kunde_Suche_MouseLeave;
            // 
            // kundeSuche_Menue
            // 
            kundeSuche_Menue.BackColor = Color.Transparent;
            kundeSuche_Menue.Dock = DockStyle.None;
            kundeSuche_Menue.Font = new Font("Microsoft Sans Serif", 12F);
            kundeSuche_Menue.Items.AddRange(new ToolStripItem[] { menu_Bücher, menu_Autor, menu_Genre, menu_ISBN });
            kundeSuche_Menue.Location = new Point(35, 84);
            kundeSuche_Menue.Name = "kundeSuche_Menue";
            kundeSuche_Menue.Size = new Size(828, 52);
            kundeSuche_Menue.TabIndex = 34;
            // 
            // menu_Bücher
            // 
            menu_Bücher.AutoSize = false;
            menu_Bücher.Font = new Font("Microsoft Sans Serif", 18F);
            menu_Bücher.ForeColor = Color.White;
            menu_Bücher.Name = "menu_Bücher";
            menu_Bücher.Size = new Size(175, 48);
            menu_Bücher.Text = "Titel";
            menu_Bücher.MouseEnter += Kunde_Suche_MouseEnter;
            menu_Bücher.MouseLeave += Kunde_Suche_MouseLeave;
            // 
            // menu_Autor
            // 
            menu_Autor.AutoSize = false;
            menu_Autor.Font = new Font("Microsoft Sans Serif", 18F);
            menu_Autor.ForeColor = Color.White;
            menu_Autor.Name = "menu_Autor";
            menu_Autor.Size = new Size(175, 48);
            menu_Autor.Text = "Autor";
            menu_Autor.MouseEnter += Kunde_Suche_MouseEnter;
            menu_Autor.MouseLeave += Kunde_Suche_MouseLeave;
            // 
            // menu_Genre
            // 
            menu_Genre.AutoSize = false;
            menu_Genre.Font = new Font("Microsoft Sans Serif", 18F);
            menu_Genre.ForeColor = Color.White;
            menu_Genre.Name = "menu_Genre";
            menu_Genre.Size = new Size(175, 48);
            menu_Genre.Text = "Genre";
            menu_Genre.MouseEnter += Kunde_Suche_MouseEnter;
            menu_Genre.MouseLeave += Kunde_Suche_MouseLeave;
            // 
            // menu_ISBN
            // 
            menu_ISBN.AutoSize = false;
            menu_ISBN.Font = new Font("Microsoft Sans Serif", 18F);
            menu_ISBN.ForeColor = Color.White;
            menu_ISBN.Name = "menu_ISBN";
            menu_ISBN.Size = new Size(175, 48);
            menu_ISBN.Text = "ISBN";
            menu_ISBN.MouseEnter += Kunde_Suche_MouseEnter;
            menu_ISBN.MouseLeave += Kunde_Suche_MouseLeave;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 158);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(709, 272);
            dataGridView1.TabIndex = 35;
            // 
            // KundeSuche
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.Hintergrund800x600;
            ClientSize = new Size(784, 561);
            Controls.Add(dataGridView1);
            Controls.Add(KundeSuche_Reservieren);
            Controls.Add(KundeSuche_Ausleihen);
            Controls.Add(KundeSuche_Zurück);
            Controls.Add(KundeSuche_Seitenname);
            Controls.Add(kundeSuche_Menue);
            Font = new Font("Microsoft Sans Serif", 12F);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = kundeSuche_Menue;
            MaximizeBox = false;
            MaximumSize = new Size(800, 600);
            MinimizeBox = false;
            MinimumSize = new Size(800, 600);
            Name = "KundeSuche";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KundeSuche";
            FormClosing += Kunde_Suche;
            Load += KundeSuche_Load;
            kundeSuche_Menue.ResumeLayout(false);
            kundeSuche_Menue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label KundeSuche_Seitenname;
        private Button KundeSuche_Zurück;
        private Button KundeSuche_Ausleihen;
        private Button KundeSuche_Reservieren;
        private MenuStrip kundeSuche_Menue;
        private ToolStripMenuItem menu_Bücher;
        private ToolStripMenuItem menu_Autor;
        private ToolStripMenuItem menu_Genre;
        private ToolStripMenuItem menu_ISBN;
        private DataGridView dataGridView1;
    }
}