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
            KundeStrafen_Bezahlen = new Button();
            KundeStrafen_Grid = new DataGridView();
            KundeStrafen_Strafauswahl = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)KundeStrafen_Grid).BeginInit();
            SuspendLayout();
            // 
            // KundeStrafen_Seitenname
            // 
            KundeStrafen_Seitenname.AutoSize = true;
            KundeStrafen_Seitenname.BackColor = Color.Transparent;
            KundeStrafen_Seitenname.Font = new Font("Vacaciones", 28.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KundeStrafen_Seitenname.ForeColor = Color.Transparent;
            KundeStrafen_Seitenname.Location = new Point(283, 23);
            KundeStrafen_Seitenname.Name = "KundeStrafen_Seitenname";
            KundeStrafen_Seitenname.Size = new Size(214, 65);
            KundeStrafen_Seitenname.TabIndex = 7;
            KundeStrafen_Seitenname.Text = "Strafen";
            KundeStrafen_Seitenname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // KundeStrafen_Zurück
            // 
            KundeStrafen_Zurück.BackColor = Color.Transparent;
            KundeStrafen_Zurück.FlatStyle = FlatStyle.Popup;
            KundeStrafen_Zurück.Font = new Font("Vacaciones", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KundeStrafen_Zurück.ForeColor = SystemColors.ButtonHighlight;
            KundeStrafen_Zurück.Location = new Point(469, 459);
            KundeStrafen_Zurück.Margin = new Padding(0);
            KundeStrafen_Zurück.Name = "KundeStrafen_Zurück";
            KundeStrafen_Zurück.Size = new Size(218, 55);
            KundeStrafen_Zurück.TabIndex = 11;
            KundeStrafen_Zurück.Text = "Zurück";
            KundeStrafen_Zurück.UseVisualStyleBackColor = false;
            KundeStrafen_Zurück.Click += KundeStrafen_Abbrechen_Click;
            KundeStrafen_Zurück.MouseEnter += KundeStrafen_MouseEnter;
            KundeStrafen_Zurück.MouseLeave += KundeStrafen_MouseLeave;
            // 
            // KundeStrafen_Bezahlen
            // 
            KundeStrafen_Bezahlen.BackColor = Color.Transparent;
            KundeStrafen_Bezahlen.FlatStyle = FlatStyle.Popup;
            KundeStrafen_Bezahlen.Font = new Font("Vacaciones", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KundeStrafen_Bezahlen.ForeColor = SystemColors.ButtonHighlight;
            KundeStrafen_Bezahlen.Location = new Point(50, 459);
            KundeStrafen_Bezahlen.Margin = new Padding(0);
            KundeStrafen_Bezahlen.Name = "KundeStrafen_Bezahlen";
            KundeStrafen_Bezahlen.Size = new Size(316, 55);
            KundeStrafen_Bezahlen.TabIndex = 12;
            KundeStrafen_Bezahlen.Text = "Strafe bezahlen";
            KundeStrafen_Bezahlen.UseVisualStyleBackColor = false;
            KundeStrafen_Bezahlen.Visible = false;
            KundeStrafen_Bezahlen.Click += KundeStrafen_Buttons_Click;
            KundeStrafen_Bezahlen.MouseEnter += KundeStrafen_MouseEnter;
            KundeStrafen_Bezahlen.MouseLeave += KundeStrafen_MouseLeave;
            // 
            // KundeStrafen_Grid
            // 
            KundeStrafen_Grid.AllowUserToAddRows = false;
            KundeStrafen_Grid.AllowUserToDeleteRows = false;
            KundeStrafen_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            KundeStrafen_Grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            KundeStrafen_Grid.BackgroundColor = Color.White;
            KundeStrafen_Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            KundeStrafen_Grid.Location = new Point(38, 108);
            KundeStrafen_Grid.Name = "KundeStrafen_Grid";
            KundeStrafen_Grid.RowHeadersWidth = 51;
            KundeStrafen_Grid.Size = new Size(711, 221);
            KundeStrafen_Grid.TabIndex = 13;
            // 
            // KundeStrafen_Strafauswahl
            // 
            KundeStrafen_Strafauswahl.DropDownStyle = ComboBoxStyle.DropDownList;
            KundeStrafen_Strafauswahl.Font = new Font("Segoe UI", 12F);
            KundeStrafen_Strafauswahl.FormattingEnabled = true;
            KundeStrafen_Strafauswahl.Location = new Point(38, 353);
            KundeStrafen_Strafauswahl.Name = "KundeStrafen_Strafauswahl";
            KundeStrafen_Strafauswahl.Size = new Size(711, 36);
            KundeStrafen_Strafauswahl.TabIndex = 14;
            KundeStrafen_Strafauswahl.SelectedIndexChanged += KundeStrafen_Strafauswahl_SelectedIndexChanged;
            // 
            // KundeStrafen
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.Hintergrund800x600;
            ClientSize = new Size(782, 553);
            Controls.Add(KundeStrafen_Strafauswahl);
            Controls.Add(KundeStrafen_Grid);
            Controls.Add(KundeStrafen_Bezahlen);
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
            ((System.ComponentModel.ISupportInitialize)KundeStrafen_Grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label KundeStrafen_Seitenname;
        private Button KundeStrafen_Zurück;
        private Button KundeStrafen_Bezahlen;
        private DataGridView KundeStrafen_Grid;
        private ComboBox KundeStrafen_Strafauswahl;
    }
}