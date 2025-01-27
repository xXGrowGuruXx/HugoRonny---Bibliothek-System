namespace Bibliothek.Mitarbeiter
{
    partial class Mitarbeiter_Buecher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mitarbeiter_Buecher));
            buch_Seitenname = new Label();
            buecher_Label_Titel = new Label();
            buecher_Titel = new TextBox();
            buecher_Zurueck = new Button();
            buecher_Loeschen = new Button();
            buecher_Speichern = new Button();
            buecher_Label_ISBN = new Label();
            buecher_Label_Autor = new Label();
            buecher_Label_Genre = new Label();
            buecher_ISBN = new TextBox();
            buecher_Titel_Autor = new MenuStrip();
            buecher_Autor = new TextBox();
            buecher_Genre = new TextBox();
            SuspendLayout();
            // 
            // buch_Seitenname
            // 
            buch_Seitenname.AutoSize = true;
            buch_Seitenname.BackColor = Color.Transparent;
            buch_Seitenname.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buch_Seitenname.ForeColor = Color.Transparent;
            buch_Seitenname.Location = new Point(319, 9);
            buch_Seitenname.Name = "buch_Seitenname";
            buch_Seitenname.Size = new Size(124, 37);
            buch_Seitenname.TabIndex = 7;
            buch_Seitenname.Text = "Bücher";
            buch_Seitenname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buecher_Label_Titel
            // 
            buecher_Label_Titel.AutoSize = true;
            buecher_Label_Titel.BackColor = Color.Transparent;
            buecher_Label_Titel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buecher_Label_Titel.ForeColor = SystemColors.ButtonHighlight;
            buecher_Label_Titel.Location = new Point(44, 113);
            buecher_Label_Titel.Name = "buecher_Label_Titel";
            buecher_Label_Titel.Size = new Size(43, 20);
            buecher_Label_Titel.TabIndex = 12;
            buecher_Label_Titel.Text = "Titel";
            // 
            // buecher_Titel
            // 
            buecher_Titel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buecher_Titel.Location = new Point(156, 113);
            buecher_Titel.Name = "buecher_Titel";
            buecher_Titel.Size = new Size(377, 26);
            buecher_Titel.TabIndex = 13;
            buecher_Titel.TextAlign = HorizontalAlignment.Center;
            buecher_Titel.MouseEnter += mitarbeiter_Buecher_MouseEnter;
            buecher_Titel.MouseLeave += mitarbeiter_Kunden_MouseLeave;
            // 
            // buecher_Zurueck
            // 
            buecher_Zurueck.BackColor = Color.Transparent;
            buecher_Zurueck.FlatStyle = FlatStyle.Popup;
            buecher_Zurueck.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buecher_Zurueck.ForeColor = SystemColors.Control;
            buecher_Zurueck.Location = new Point(561, 466);
            buecher_Zurueck.Name = "buecher_Zurueck";
            buecher_Zurueck.Size = new Size(211, 83);
            buecher_Zurueck.TabIndex = 26;
            buecher_Zurueck.Text = "Zurück";
            buecher_Zurueck.UseVisualStyleBackColor = false;
            buecher_Zurueck.Click += mitarbeiter_Buecher_Abbrechen_Click;
            buecher_Zurueck.MouseEnter += mitarbeiter_Buecher_MouseEnter;
            buecher_Zurueck.MouseLeave += mitarbeiter_Kunden_MouseLeave;
            // 
            // buecher_Loeschen
            // 
            buecher_Loeschen.BackColor = Color.Transparent;
            buecher_Loeschen.FlatStyle = FlatStyle.Popup;
            buecher_Loeschen.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buecher_Loeschen.ForeColor = SystemColors.Control;
            buecher_Loeschen.Location = new Point(12, 466);
            buecher_Loeschen.Name = "buecher_Loeschen";
            buecher_Loeschen.Size = new Size(211, 83);
            buecher_Loeschen.TabIndex = 27;
            buecher_Loeschen.Text = "Löschen";
            buecher_Loeschen.UseVisualStyleBackColor = false;
            buecher_Loeschen.MouseEnter += mitarbeiter_Buecher_MouseEnter;
            buecher_Loeschen.MouseLeave += mitarbeiter_Kunden_MouseLeave;
            // 
            // buecher_Speichern
            // 
            buecher_Speichern.BackColor = Color.Transparent;
            buecher_Speichern.FlatStyle = FlatStyle.Popup;
            buecher_Speichern.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buecher_Speichern.ForeColor = SystemColors.Control;
            buecher_Speichern.Location = new Point(561, 62);
            buecher_Speichern.Name = "buecher_Speichern";
            buecher_Speichern.Size = new Size(211, 353);
            buecher_Speichern.TabIndex = 28;
            buecher_Speichern.Text = "Speichern";
            buecher_Speichern.UseVisualStyleBackColor = false;
            buecher_Speichern.MouseEnter += mitarbeiter_Buecher_MouseEnter;
            buecher_Speichern.MouseLeave += mitarbeiter_Kunden_MouseLeave;
            // 
            // buecher_Label_ISBN
            // 
            buecher_Label_ISBN.AutoSize = true;
            buecher_Label_ISBN.BackColor = Color.Transparent;
            buecher_Label_ISBN.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buecher_Label_ISBN.ForeColor = SystemColors.ButtonHighlight;
            buecher_Label_ISBN.Location = new Point(44, 274);
            buecher_Label_ISBN.Name = "buecher_Label_ISBN";
            buecher_Label_ISBN.Size = new Size(51, 20);
            buecher_Label_ISBN.TabIndex = 31;
            buecher_Label_ISBN.Text = "ISBN";
            // 
            // buecher_Label_Autor
            // 
            buecher_Label_Autor.AutoSize = true;
            buecher_Label_Autor.BackColor = Color.Transparent;
            buecher_Label_Autor.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buecher_Label_Autor.ForeColor = SystemColors.ButtonHighlight;
            buecher_Label_Autor.Location = new Point(44, 168);
            buecher_Label_Autor.Name = "buecher_Label_Autor";
            buecher_Label_Autor.Size = new Size(53, 20);
            buecher_Label_Autor.TabIndex = 32;
            buecher_Label_Autor.Text = "Autor";
            // 
            // buecher_Label_Genre
            // 
            buecher_Label_Genre.AutoSize = true;
            buecher_Label_Genre.BackColor = Color.Transparent;
            buecher_Label_Genre.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buecher_Label_Genre.ForeColor = SystemColors.ButtonHighlight;
            buecher_Label_Genre.Location = new Point(44, 220);
            buecher_Label_Genre.Name = "buecher_Label_Genre";
            buecher_Label_Genre.Size = new Size(59, 20);
            buecher_Label_Genre.TabIndex = 33;
            buecher_Label_Genre.Text = "Genre";
            // 
            // buecher_ISBN
            // 
            buecher_ISBN.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buecher_ISBN.Location = new Point(156, 268);
            buecher_ISBN.Name = "buecher_ISBN";
            buecher_ISBN.Size = new Size(377, 26);
            buecher_ISBN.TabIndex = 34;
            buecher_ISBN.TextAlign = HorizontalAlignment.Center;
            buecher_ISBN.MouseEnter += mitarbeiter_Buecher_MouseEnter;
            buecher_ISBN.MouseLeave += mitarbeiter_Kunden_MouseLeave;
            // 
            // buecher_Titel_Autor
            // 
            buecher_Titel_Autor.Dock = DockStyle.None;
            buecher_Titel_Autor.Location = new Point(44, 62);
            buecher_Titel_Autor.Name = "buecher_Titel_Autor";
            buecher_Titel_Autor.Size = new Size(202, 24);
            buecher_Titel_Autor.TabIndex = 35;
            buecher_Titel_Autor.Text = "buecher_Titel_Autor";
            buecher_Titel_Autor.MouseEnter += mitarbeiter_Buecher_MouseEnter;
            buecher_Titel_Autor.MouseLeave += mitarbeiter_Kunden_MouseLeave;
            // 
            // buecher_Autor
            // 
            buecher_Autor.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buecher_Autor.Location = new Point(156, 162);
            buecher_Autor.Name = "buecher_Autor";
            buecher_Autor.Size = new Size(377, 26);
            buecher_Autor.TabIndex = 36;
            buecher_Autor.TextAlign = HorizontalAlignment.Center;
            // 
            // buecher_Genre
            // 
            buecher_Genre.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buecher_Genre.Location = new Point(156, 214);
            buecher_Genre.Name = "buecher_Genre";
            buecher_Genre.Size = new Size(377, 26);
            buecher_Genre.TabIndex = 37;
            buecher_Genre.TextAlign = HorizontalAlignment.Center;
            buecher_Genre.MouseEnter += mitarbeiter_Buecher_MouseEnter;
            buecher_Genre.MouseLeave += mitarbeiter_Kunden_MouseLeave;
            // 
            // Mitarbeiter_Buecher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Hintergrund800x600;
            ClientSize = new Size(784, 561);
            Controls.Add(buecher_Genre);
            Controls.Add(buecher_Autor);
            Controls.Add(buecher_ISBN);
            Controls.Add(buecher_Label_Genre);
            Controls.Add(buecher_Label_Autor);
            Controls.Add(buecher_Label_ISBN);
            Controls.Add(buecher_Speichern);
            Controls.Add(buecher_Loeschen);
            Controls.Add(buecher_Zurueck);
            Controls.Add(buecher_Titel);
            Controls.Add(buecher_Label_Titel);
            Controls.Add(buch_Seitenname);
            Controls.Add(buecher_Titel_Autor);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Mitarbeiter_Buecher";
            Text = "Mitarbeiter_Buecher";
            FormClosing += mitarbeiter_Buecher;
            Load += Mitarbeiter_Buecher_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label buch_Seitenname;
        private Label buecher_Label_Titel;
        private TextBox buecher_Titel;
        private Button buecher_Zurueck;
        private Button buecher_Loeschen;
        private Button buecher_Speichern;
        private Label buecher_Label_ISBN;
        private Label buecher_Label_Autor;
        private Label buecher_Label_Genre;
        private TextBox buecher_ISBN;
        private MenuStrip buecher_Titel_Autor;
        private TextBox buecher_Autor;
        private TextBox buecher_Genre;
    }
}