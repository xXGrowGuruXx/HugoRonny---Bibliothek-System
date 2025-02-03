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
            bücher_Label_Titel = new Label();
            bücher_Titel = new TextBox();
            buecher_Zurueck = new Button();
            buecher_Speichern = new Button();
            bücher_Label_ISBN = new Label();
            bücher_Label_Autor = new Label();
            bücher_Label_Genre = new Label();
            bücher_ISBN = new TextBox();
            bücher_Menu = new MenuStrip();
            menu_Bücher = new ToolStripMenuItem();
            menu_Autoren = new ToolStripMenuItem();
            menu_Genre = new ToolStripMenuItem();
            bücher_Autor = new ComboBox();
            bücher_Genre = new ComboBox();
            bücher_Menu.SuspendLayout();
            SuspendLayout();
            // 
            // buch_Seitenname
            // 
            buch_Seitenname.AutoSize = true;
            buch_Seitenname.BackColor = Color.Transparent;
            buch_Seitenname.Font = new Font("Vacaciones", 28.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buch_Seitenname.ForeColor = Color.Transparent;
            buch_Seitenname.Location = new Point(300, 31);
            buch_Seitenname.Name = "buch_Seitenname";
            buch_Seitenname.Size = new Size(196, 65);
            buch_Seitenname.TabIndex = 7;
            buch_Seitenname.Text = "Bücher";
            buch_Seitenname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bücher_Label_Titel
            // 
            bücher_Label_Titel.AutoSize = true;
            bücher_Label_Titel.BackColor = Color.Transparent;
            bücher_Label_Titel.Font = new Font("Vacaciones", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bücher_Label_Titel.ForeColor = SystemColors.ButtonHighlight;
            bücher_Label_Titel.Location = new Point(116, 168);
            bücher_Label_Titel.Name = "bücher_Label_Titel";
            bücher_Label_Titel.Size = new Size(85, 39);
            bücher_Label_Titel.TabIndex = 12;
            bücher_Label_Titel.Text = "Titel";
            // 
            // bücher_Titel
            // 
            bücher_Titel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bücher_Titel.Location = new Point(276, 175);
            bücher_Titel.Name = "bücher_Titel";
            bücher_Titel.Size = new Size(377, 30);
            bücher_Titel.TabIndex = 13;
            bücher_Titel.TextAlign = HorizontalAlignment.Center;
            bücher_Titel.TextChanged += TextBox_Changed;
            bücher_Titel.MouseEnter += mitarbeiter_Bücher_MouseEnter;
            bücher_Titel.MouseLeave += mitarbeiter_Bücher_MouseLeave;
            // 
            // buecher_Zurueck
            // 
            buecher_Zurueck.BackColor = Color.Transparent;
            buecher_Zurueck.FlatStyle = FlatStyle.Popup;
            buecher_Zurueck.Font = new Font("Vacaciones", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buecher_Zurueck.ForeColor = SystemColors.Control;
            buecher_Zurueck.Location = new Point(509, 438);
            buecher_Zurueck.Name = "buecher_Zurueck";
            buecher_Zurueck.Size = new Size(211, 64);
            buecher_Zurueck.TabIndex = 26;
            buecher_Zurueck.Text = "Zurück";
            buecher_Zurueck.UseVisualStyleBackColor = false;
            buecher_Zurueck.Click += mitarbeiter_Buecher_Abbrechen_Click;
            buecher_Zurueck.MouseEnter += mitarbeiter_Bücher_MouseEnter;
            buecher_Zurueck.MouseLeave += mitarbeiter_Bücher_MouseLeave;
            // 
            // buecher_Speichern
            // 
            buecher_Speichern.BackColor = Color.Transparent;
            buecher_Speichern.FlatStyle = FlatStyle.Popup;
            buecher_Speichern.Font = new Font("Vacaciones", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buecher_Speichern.ForeColor = SystemColors.Control;
            buecher_Speichern.Location = new Point(62, 438);
            buecher_Speichern.Name = "buecher_Speichern";
            buecher_Speichern.Size = new Size(211, 64);
            buecher_Speichern.TabIndex = 28;
            buecher_Speichern.Text = "Speichern";
            buecher_Speichern.UseVisualStyleBackColor = false;
            buecher_Speichern.Click += buecher_Speichern_Click;
            buecher_Speichern.MouseEnter += mitarbeiter_Bücher_MouseEnter;
            buecher_Speichern.MouseLeave += mitarbeiter_Bücher_MouseLeave;
            // 
            // bücher_Label_ISBN
            // 
            bücher_Label_ISBN.AutoSize = true;
            bücher_Label_ISBN.BackColor = Color.Transparent;
            bücher_Label_ISBN.Font = new Font("Vacaciones", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bücher_Label_ISBN.ForeColor = SystemColors.ButtonHighlight;
            bücher_Label_ISBN.Location = new Point(117, 340);
            bücher_Label_ISBN.Name = "bücher_Label_ISBN";
            bücher_Label_ISBN.Size = new Size(84, 39);
            bücher_Label_ISBN.TabIndex = 31;
            bücher_Label_ISBN.Text = "ISBN";
            // 
            // bücher_Label_Autor
            // 
            bücher_Label_Autor.AutoSize = true;
            bücher_Label_Autor.BackColor = Color.Transparent;
            bücher_Label_Autor.Font = new Font("Vacaciones", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bücher_Label_Autor.ForeColor = SystemColors.ButtonHighlight;
            bücher_Label_Autor.Location = new Point(116, 227);
            bücher_Label_Autor.Name = "bücher_Label_Autor";
            bücher_Label_Autor.Size = new Size(101, 39);
            bücher_Label_Autor.TabIndex = 32;
            bücher_Label_Autor.Text = "Autor";
            // 
            // bücher_Label_Genre
            // 
            bücher_Label_Genre.AutoSize = true;
            bücher_Label_Genre.BackColor = Color.Transparent;
            bücher_Label_Genre.Font = new Font("Vacaciones", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bücher_Label_Genre.ForeColor = SystemColors.ButtonHighlight;
            bücher_Label_Genre.Location = new Point(116, 279);
            bücher_Label_Genre.Name = "bücher_Label_Genre";
            bücher_Label_Genre.Size = new Size(104, 39);
            bücher_Label_Genre.TabIndex = 33;
            bücher_Label_Genre.Text = "Genre";
            // 
            // bücher_ISBN
            // 
            bücher_ISBN.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bücher_ISBN.Location = new Point(276, 347);
            bücher_ISBN.Name = "bücher_ISBN";
            bücher_ISBN.Size = new Size(377, 30);
            bücher_ISBN.TabIndex = 34;
            bücher_ISBN.TextAlign = HorizontalAlignment.Center;
            bücher_ISBN.MouseEnter += mitarbeiter_Bücher_MouseEnter;
            bücher_ISBN.MouseLeave += mitarbeiter_Bücher_MouseLeave;
            // 
            // bücher_Menu
            // 
            bücher_Menu.BackColor = Color.Transparent;
            bücher_Menu.Dock = DockStyle.None;
            bücher_Menu.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bücher_Menu.ImageScalingSize = new Size(20, 20);
            bücher_Menu.Items.AddRange(new ToolStripItem[] { menu_Bücher, menu_Autoren, menu_Genre });
            bücher_Menu.Location = new Point(210, 107);
            bücher_Menu.Name = "bücher_Menu";
            bücher_Menu.Size = new Size(547, 46);
            bücher_Menu.TabIndex = 38;
            // 
            // menu_Bücher
            // 
            menu_Bücher.AutoSize = false;
            menu_Bücher.BackColor = Color.Transparent;
            menu_Bücher.Font = new Font("Vacaciones", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menu_Bücher.ForeColor = Color.White;
            menu_Bücher.Name = "menu_Bücher";
            menu_Bücher.Size = new Size(152, 42);
            menu_Bücher.Text = "Bücher";
            menu_Bücher.MouseEnter += bücher_Menu_MouseEnter;
            menu_Bücher.MouseLeave += bücher_Menu_MouseLeave;
            // 
            // menu_Autoren
            // 
            menu_Autoren.AutoSize = false;
            menu_Autoren.BackColor = Color.Transparent;
            menu_Autoren.Font = new Font("Vacaciones", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menu_Autoren.ForeColor = Color.White;
            menu_Autoren.Name = "menu_Autoren";
            menu_Autoren.Size = new Size(131, 42);
            menu_Autoren.Text = "Autoren";
            menu_Autoren.MouseEnter += bücher_Menu_MouseEnter;
            menu_Autoren.MouseLeave += bücher_Menu_MouseLeave;
            // 
            // menu_Genre
            // 
            menu_Genre.AutoSize = false;
            menu_Genre.BackColor = Color.Transparent;
            menu_Genre.Font = new Font("Vacaciones", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menu_Genre.ForeColor = Color.White;
            menu_Genre.Name = "menu_Genre";
            menu_Genre.Size = new Size(106, 42);
            menu_Genre.Text = "Genre";
            menu_Genre.MouseEnter += bücher_Menu_MouseEnter;
            menu_Genre.MouseLeave += bücher_Menu_MouseLeave;
            // 
            // bücher_Autor
            // 
            bücher_Autor.DropDownStyle = ComboBoxStyle.DropDownList;
            bücher_Autor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bücher_Autor.FormattingEnabled = true;
            bücher_Autor.ItemHeight = 28;
            bücher_Autor.Location = new Point(276, 231);
            bücher_Autor.Name = "bücher_Autor";
            bücher_Autor.Size = new Size(377, 36);
            bücher_Autor.TabIndex = 39;
            bücher_Autor.MouseEnter += mitarbeiter_Bücher_MouseEnter;
            bücher_Autor.MouseLeave += mitarbeiter_Bücher_MouseLeave;
            // 
            // bücher_Genre
            // 
            bücher_Genre.DropDownStyle = ComboBoxStyle.DropDownList;
            bücher_Genre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bücher_Genre.FormattingEnabled = true;
            bücher_Genre.Location = new Point(276, 283);
            bücher_Genre.Name = "bücher_Genre";
            bücher_Genre.Size = new Size(377, 36);
            bücher_Genre.TabIndex = 40;
            bücher_Genre.MouseEnter += mitarbeiter_Bücher_MouseEnter;
            bücher_Genre.MouseLeave += mitarbeiter_Bücher_MouseLeave;
            // 
            // Mitarbeiter_Buecher
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.Hintergrund800x600;
            ClientSize = new Size(782, 553);
            Controls.Add(bücher_Genre);
            Controls.Add(bücher_Autor);
            Controls.Add(bücher_ISBN);
            Controls.Add(bücher_Label_Genre);
            Controls.Add(bücher_Label_Autor);
            Controls.Add(bücher_Label_ISBN);
            Controls.Add(buecher_Speichern);
            Controls.Add(buecher_Zurueck);
            Controls.Add(bücher_Titel);
            Controls.Add(bücher_Label_Titel);
            Controls.Add(buch_Seitenname);
            Controls.Add(bücher_Menu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = bücher_Menu;
            MaximizeBox = false;
            MaximumSize = new Size(800, 600);
            MinimizeBox = false;
            MinimumSize = new Size(800, 600);
            Name = "Mitarbeiter_Buecher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mitarbeiter_Buecher";
            FormClosing += mitarbeiter_Buecher_Closing;
            Load += Mitarbeiter_Buecher_Load;
            bücher_Menu.ResumeLayout(false);
            bücher_Menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label buch_Seitenname;
        private Label bücher_Label_Titel;
        private TextBox bücher_Titel;
        private Button buecher_Zurueck;
        private Button buecher_Speichern;
        private Label bücher_Label_ISBN;
        private Label bücher_Label_Autor;
        private Label bücher_Label_Genre;
        private TextBox bücher_ISBN;
        private MenuStrip bücher_Menu;
        private ComboBox bücher_Autor;
        private ComboBox bücher_Genre;
        private ToolStripMenuItem menu_Autoren;
        private ToolStripMenuItem menu_Genre;
        private ToolStripMenuItem menu_Bücher;
    }
}