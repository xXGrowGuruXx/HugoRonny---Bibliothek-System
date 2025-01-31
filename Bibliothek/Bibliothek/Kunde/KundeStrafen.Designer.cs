namespace Bibliothek.Kunde
{
    partial class KundeStrafen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KundeStrafen));
            KundeStrafen_Seitenname = new Label();
            KundeStrafen_Zurück = new Button();
            KundeStrafen_Abgeben = new Button();
            KundeStrafen_AusgelieheneBücher = new DataGridView();
            KundeStrafen_Buchauswahl = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)KundeStrafen_AusgelieheneBücher).BeginInit();
            SuspendLayout();
            // 
            // KundeStrafen_Seitenname
            // 
            KundeStrafen_Seitenname.AutoSize = true;
            KundeStrafen_Seitenname.BackColor = Color.Transparent;
            KundeStrafen_Seitenname.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KundeStrafen_Seitenname.ForeColor = Color.Transparent;
            KundeStrafen_Seitenname.Location = new Point(327, 25);
            KundeStrafen_Seitenname.Name = "KundeStrafen_Seitenname";
            KundeStrafen_Seitenname.Size = new Size(127, 37);
            KundeStrafen_Seitenname.TabIndex = 7;
            KundeStrafen_Seitenname.Text = "Strafen";
            KundeStrafen_Seitenname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // KundeStrafen_Zurück
            // 
            KundeStrafen_Zurück.BackColor = Color.Transparent;
            KundeStrafen_Zurück.FlatStyle = FlatStyle.Popup;
            KundeStrafen_Zurück.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KundeStrafen_Zurück.ForeColor = SystemColors.ButtonHighlight;
            KundeStrafen_Zurück.Location = new Point(114, 497);
            KundeStrafen_Zurück.Margin = new Padding(0);
            KundeStrafen_Zurück.Name = "KundeStrafen_Zurück";
            KundeStrafen_Zurück.Size = new Size(590, 55);
            KundeStrafen_Zurück.TabIndex = 11;
            KundeStrafen_Zurück.Text = "Zurück";
            KundeStrafen_Zurück.UseVisualStyleBackColor = false;
            KundeStrafen_Zurück.Click += KundeStrafen_Abbrechen_Click;
            KundeStrafen_Zurück.MouseEnter += KundeStrafen_MouseEnter;
            KundeStrafen_Zurück.MouseLeave += KundeStrafen_MouseLeave;
            // 
            // KundeStrafen_Abgeben
            // 
            KundeStrafen_Abgeben.BackColor = Color.Transparent;
            KundeStrafen_Abgeben.FlatStyle = FlatStyle.Popup;
            KundeStrafen_Abgeben.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KundeStrafen_Abgeben.ForeColor = SystemColors.ButtonHighlight;
            KundeStrafen_Abgeben.Location = new Point(114, 431);
            KundeStrafen_Abgeben.Margin = new Padding(0);
            KundeStrafen_Abgeben.Name = "KundeStrafen_Abgeben";
            KundeStrafen_Abgeben.Size = new Size(590, 55);
            KundeStrafen_Abgeben.TabIndex = 12;
            KundeStrafen_Abgeben.Text = "Strafe bezahlen";
            KundeStrafen_Abgeben.UseVisualStyleBackColor = false;
            KundeStrafen_Abgeben.Click += KundeStrafen_Buttons_Click;
            KundeStrafen_Abgeben.MouseEnter += KundeStrafen_MouseEnter;
            KundeStrafen_Abgeben.MouseLeave += KundeStrafen_MouseLeave;
            // 
            // KundeStrafen_AusgelieheneBücher
            // 
            KundeStrafen_AusgelieheneBücher.BackgroundColor = Color.White;
            KundeStrafen_AusgelieheneBücher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            KundeStrafen_AusgelieheneBücher.Location = new Point(38, 108);
            KundeStrafen_AusgelieheneBücher.Name = "KundeStrafen_AusgelieheneBücher";
            KundeStrafen_AusgelieheneBücher.Size = new Size(711, 221);
            KundeStrafen_AusgelieheneBücher.TabIndex = 13;
            // 
            // KundeStrafen_Buchauswahl
            // 
            KundeStrafen_Buchauswahl.Font = new Font("Segoe UI", 12F);
            KundeStrafen_Buchauswahl.FormattingEnabled = true;
            KundeStrafen_Buchauswahl.Location = new Point(38, 353);
            KundeStrafen_Buchauswahl.Name = "KundeStrafen_Buchauswahl";
            KundeStrafen_Buchauswahl.Size = new Size(711, 29);
            KundeStrafen_Buchauswahl.TabIndex = 14;
            KundeStrafen_Buchauswahl.Text = "Strafe zum begleichen auswählen";
            // 
            // KundeStrafen
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.Hintergrund800x600;
            ClientSize = new Size(784, 561);
            Controls.Add(KundeStrafen_Buchauswahl);
            Controls.Add(KundeStrafen_AusgelieheneBücher);
            Controls.Add(KundeStrafen_Abgeben);
            Controls.Add(KundeStrafen_Zurück);
            Controls.Add(KundeStrafen_Seitenname);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(800, 600);
            MinimizeBox = false;
            MinimumSize = new Size(800, 600);
            Name = "KundeStrafen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KundeStrafen";
            FormClosing += kundeStrafen;
            Load += KundeStrafen_Load;
            ((System.ComponentModel.ISupportInitialize)KundeStrafen_AusgelieheneBücher).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label KundeStrafen_Seitenname;
        private Button KundeStrafen_Zurück;
        private Button KundeStrafen_Abgeben;
        private DataGridView KundeStrafen_AusgelieheneBücher;
        private ComboBox KundeStrafen_Buchauswahl;
    }
}