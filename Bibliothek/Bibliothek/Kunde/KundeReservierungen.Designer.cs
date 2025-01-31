namespace Bibliothek.Kunde
{
    partial class KundeReservierungen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KundeReservierungen));
            KundeReservierungen_Seitenname = new Label();
            KundeReservierungen_Zurück = new Button();
            KundeReservierungen_Abgeben = new Button();
            KundeReservierungen_AusgelieheneBücher = new DataGridView();
            KundeReservierungen_Buchauswahl = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)KundeReservierungen_AusgelieheneBücher).BeginInit();
            SuspendLayout();
            // 
            // KundeReservierungen_Seitenname
            // 
            KundeReservierungen_Seitenname.AutoSize = true;
            KundeReservierungen_Seitenname.BackColor = Color.Transparent;
            KundeReservierungen_Seitenname.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KundeReservierungen_Seitenname.ForeColor = Color.Transparent;
            KundeReservierungen_Seitenname.Location = new Point(255, 22);
            KundeReservierungen_Seitenname.Name = "KundeReservierungen_Seitenname";
            KundeReservierungen_Seitenname.Size = new Size(253, 37);
            KundeReservierungen_Seitenname.TabIndex = 7;
            KundeReservierungen_Seitenname.Text = "Reservierungen";
            KundeReservierungen_Seitenname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // KundeReservierungen_Zurück
            // 
            KundeReservierungen_Zurück.BackColor = Color.Transparent;
            KundeReservierungen_Zurück.FlatStyle = FlatStyle.Popup;
            KundeReservierungen_Zurück.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KundeReservierungen_Zurück.ForeColor = SystemColors.ButtonHighlight;
            KundeReservierungen_Zurück.Location = new Point(114, 497);
            KundeReservierungen_Zurück.Margin = new Padding(0);
            KundeReservierungen_Zurück.Name = "KundeReservierungen_Zurück";
            KundeReservierungen_Zurück.Size = new Size(590, 55);
            KundeReservierungen_Zurück.TabIndex = 11;
            KundeReservierungen_Zurück.Text = "Zurück";
            KundeReservierungen_Zurück.UseVisualStyleBackColor = false;
            KundeReservierungen_Zurück.Click += KundeReservierungen_Abbrechen_Click;
            KundeReservierungen_Zurück.MouseEnter += KundeReservierungen_MouseEnter;
            KundeReservierungen_Zurück.MouseLeave += KundeReservierungen_MouseLeave;
            // 
            // KundeReservierungen_Abgeben
            // 
            KundeReservierungen_Abgeben.BackColor = Color.Transparent;
            KundeReservierungen_Abgeben.FlatStyle = FlatStyle.Popup;
            KundeReservierungen_Abgeben.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KundeReservierungen_Abgeben.ForeColor = SystemColors.ButtonHighlight;
            KundeReservierungen_Abgeben.Location = new Point(114, 431);
            KundeReservierungen_Abgeben.Margin = new Padding(0);
            KundeReservierungen_Abgeben.Name = "KundeReservierungen_Abgeben";
            KundeReservierungen_Abgeben.Size = new Size(590, 55);
            KundeReservierungen_Abgeben.TabIndex = 12;
            KundeReservierungen_Abgeben.Text = "Reservierung auflösen";
            KundeReservierungen_Abgeben.UseVisualStyleBackColor = false;
            KundeReservierungen_Abgeben.Click += KundeReservierungen_Buttons_Click;
            KundeReservierungen_Abgeben.MouseEnter += KundeReservierungen_MouseEnter;
            KundeReservierungen_Abgeben.MouseLeave += KundeReservierungen_MouseLeave;
            // 
            // KundeReservierungen_AusgelieheneBücher
            // 
            KundeReservierungen_AusgelieheneBücher.BackgroundColor = Color.White;
            KundeReservierungen_AusgelieheneBücher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            KundeReservierungen_AusgelieheneBücher.Location = new Point(38, 108);
            KundeReservierungen_AusgelieheneBücher.Name = "KundeReservierungen_AusgelieheneBücher";
            KundeReservierungen_AusgelieheneBücher.Size = new Size(711, 221);
            KundeReservierungen_AusgelieheneBücher.TabIndex = 13;
            // 
            // KundeReservierungen_Buchauswahl
            // 
            KundeReservierungen_Buchauswahl.Font = new Font("Segoe UI", 12F);
            KundeReservierungen_Buchauswahl.FormattingEnabled = true;
            KundeReservierungen_Buchauswahl.Location = new Point(38, 353);
            KundeReservierungen_Buchauswahl.Name = "KundeReservierungen_Buchauswahl";
            KundeReservierungen_Buchauswahl.Size = new Size(711, 29);
            KundeReservierungen_Buchauswahl.TabIndex = 14;
            KundeReservierungen_Buchauswahl.Text = "Reservierung auswählen";
            // 
            // KundeReservierungen
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.Hintergrund800x600;
            ClientSize = new Size(784, 561);
            Controls.Add(KundeReservierungen_Buchauswahl);
            Controls.Add(KundeReservierungen_AusgelieheneBücher);
            Controls.Add(KundeReservierungen_Abgeben);
            Controls.Add(KundeReservierungen_Zurück);
            Controls.Add(KundeReservierungen_Seitenname);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(800, 600);
            MinimizeBox = false;
            MinimumSize = new Size(800, 600);
            Name = "KundeReservierungen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KundeReservierungen";
            FormClosing += kundeReservierungen;
            Load += KundeReservierungen_Load;
            ((System.ComponentModel.ISupportInitialize)KundeReservierungen_AusgelieheneBücher).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label KundeReservierungen_Seitenname;
        private Button KundeReservierungen_Zurück;
        private Button KundeReservierungen_Abgeben;
        private DataGridView KundeReservierungen_AusgelieheneBücher;
        private ComboBox KundeReservierungen_Buchauswahl;
    }
}