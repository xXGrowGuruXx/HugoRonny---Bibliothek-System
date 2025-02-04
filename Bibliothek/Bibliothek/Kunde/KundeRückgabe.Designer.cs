namespace Bibliothek.Kunde
{
    partial class KundeRückgabe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KundeRückgabe));
            kundeRückgabe_Seitenname = new Label();
            kundeRückgabe_Zurück = new Button();
            kundeRückgabe_Abgeben = new Button();
            kundeRückgabe_Grid = new DataGridView();
            kundeRückgabe_Buchauswahl = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)kundeRückgabe_Grid).BeginInit();
            SuspendLayout();
            // 
            // kundeRückgabe_Seitenname
            // 
            kundeRückgabe_Seitenname.AutoSize = true;
            kundeRückgabe_Seitenname.BackColor = Color.Transparent;
            kundeRückgabe_Seitenname.Font = new Font("Vacaciones", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kundeRückgabe_Seitenname.ForeColor = Color.Transparent;
            kundeRückgabe_Seitenname.Location = new Point(216, 32);
            kundeRückgabe_Seitenname.Name = "kundeRückgabe_Seitenname";
            kundeRückgabe_Seitenname.Size = new Size(360, 55);
            kundeRückgabe_Seitenname.TabIndex = 7;
            kundeRückgabe_Seitenname.Text = "Bücherrückgabe";
            kundeRückgabe_Seitenname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // kundeRückgabe_Zurück
            // 
            kundeRückgabe_Zurück.BackColor = Color.Transparent;
            kundeRückgabe_Zurück.FlatStyle = FlatStyle.Popup;
            kundeRückgabe_Zurück.Font = new Font("Vacaciones", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kundeRückgabe_Zurück.ForeColor = SystemColors.ButtonHighlight;
            kundeRückgabe_Zurück.Location = new Point(475, 463);
            kundeRückgabe_Zurück.Margin = new Padding(0);
            kundeRückgabe_Zurück.Name = "kundeRückgabe_Zurück";
            kundeRückgabe_Zurück.Size = new Size(201, 55);
            kundeRückgabe_Zurück.TabIndex = 11;
            kundeRückgabe_Zurück.Text = "Zurück";
            kundeRückgabe_Zurück.UseVisualStyleBackColor = false;
            kundeRückgabe_Zurück.Click += kundeRückgabe_Abbrechen_Click;
            kundeRückgabe_Zurück.MouseEnter += kundeRückgabe_MouseEnter;
            kundeRückgabe_Zurück.MouseLeave += kundeRückgabe_MouseLeave;
            // 
            // kundeRückgabe_Abgeben
            // 
            kundeRückgabe_Abgeben.BackColor = Color.Transparent;
            kundeRückgabe_Abgeben.FlatStyle = FlatStyle.Popup;
            kundeRückgabe_Abgeben.Font = new Font("Vacaciones", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kundeRückgabe_Abgeben.ForeColor = SystemColors.ButtonHighlight;
            kundeRückgabe_Abgeben.Location = new Point(102, 463);
            kundeRückgabe_Abgeben.Margin = new Padding(0);
            kundeRückgabe_Abgeben.Name = "kundeRückgabe_Abgeben";
            kundeRückgabe_Abgeben.Size = new Size(212, 55);
            kundeRückgabe_Abgeben.TabIndex = 12;
            kundeRückgabe_Abgeben.Text = "Abgeben";
            kundeRückgabe_Abgeben.UseVisualStyleBackColor = false;
            kundeRückgabe_Abgeben.Visible = false;
            kundeRückgabe_Abgeben.Click += kundeRückgabe_Buttons_Click;
            kundeRückgabe_Abgeben.MouseEnter += kundeRückgabe_MouseEnter;
            kundeRückgabe_Abgeben.MouseLeave += kundeRückgabe_MouseLeave;
            // 
            // kundeRückgabe_Grid
            // 
            kundeRückgabe_Grid.AllowUserToAddRows = false;
            kundeRückgabe_Grid.AllowUserToDeleteRows = false;
            kundeRückgabe_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            kundeRückgabe_Grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            kundeRückgabe_Grid.BackgroundColor = Color.White;
            kundeRückgabe_Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kundeRückgabe_Grid.Location = new Point(38, 108);
            kundeRückgabe_Grid.Name = "kundeRückgabe_Grid";
            kundeRückgabe_Grid.RowHeadersWidth = 51;
            kundeRückgabe_Grid.Size = new Size(711, 221);
            kundeRückgabe_Grid.TabIndex = 13;
            // 
            // kundeRückgabe_Buchauswahl
            // 
            kundeRückgabe_Buchauswahl.DropDownStyle = ComboBoxStyle.DropDownList;
            kundeRückgabe_Buchauswahl.Font = new Font("Segoe UI", 12F);
            kundeRückgabe_Buchauswahl.FormattingEnabled = true;
            kundeRückgabe_Buchauswahl.Location = new Point(38, 353);
            kundeRückgabe_Buchauswahl.Name = "kundeRückgabe_Buchauswahl";
            kundeRückgabe_Buchauswahl.Size = new Size(711, 36);
            kundeRückgabe_Buchauswahl.TabIndex = 14;
            kundeRückgabe_Buchauswahl.SelectedIndexChanged += kundeRückgabe_Buchauswahl_SelectedIndexChanged;
            // 
            // KundeRückgabe
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.Hintergrund800x600;
            ClientSize = new Size(782, 553);
            Controls.Add(kundeRückgabe_Buchauswahl);
            Controls.Add(kundeRückgabe_Grid);
            Controls.Add(kundeRückgabe_Abgeben);
            Controls.Add(kundeRückgabe_Zurück);
            Controls.Add(kundeRückgabe_Seitenname);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(800, 600);
            MinimizeBox = false;
            MinimumSize = new Size(800, 600);
            Name = "KundeRückgabe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KundeRückgabe";
            FormClosing += kundeRückgabe;
            Load += KundeRückgabe_Load;
            ((System.ComponentModel.ISupportInitialize)kundeRückgabe_Grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label kundeRückgabe_Seitenname;
        private Button kundeRückgabe_Zurück;
        private Button kundeRückgabe_Abgeben;
        private DataGridView kundeRückgabe_Grid;
        private ComboBox kundeRückgabe_Buchauswahl;
    }
}