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
            KundeReservierungen_Delete = new Button();
            KundeReservierungen_Grid = new DataGridView();
            KundeReservierungen_Auswahl = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)KundeReservierungen_Grid).BeginInit();
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
            KundeReservierungen_Seitenname.Size = new Size(313, 46);
            KundeReservierungen_Seitenname.TabIndex = 7;
            KundeReservierungen_Seitenname.Text = "Reservierungen";
            KundeReservierungen_Seitenname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // KundeReservierungen_Zurück
            // 
            KundeReservierungen_Zurück.BackColor = Color.Transparent;
            KundeReservierungen_Zurück.FlatStyle = FlatStyle.Popup;
            KundeReservierungen_Zurück.Font = new Font("Vacaciones", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KundeReservierungen_Zurück.ForeColor = SystemColors.ButtonHighlight;
            KundeReservierungen_Zurück.Location = new Point(552, 461);
            KundeReservierungen_Zurück.Margin = new Padding(0);
            KundeReservierungen_Zurück.Name = "KundeReservierungen_Zurück";
            KundeReservierungen_Zurück.Size = new Size(197, 55);
            KundeReservierungen_Zurück.TabIndex = 11;
            KundeReservierungen_Zurück.Text = "Zurück";
            KundeReservierungen_Zurück.UseVisualStyleBackColor = false;
            KundeReservierungen_Zurück.Click += KundeReservierungen_Abbrechen_Click;
            KundeReservierungen_Zurück.MouseEnter += KundeReservierungen_MouseEnter;
            KundeReservierungen_Zurück.MouseLeave += KundeReservierungen_MouseLeave;
            // 
            // KundeReservierungen_Delete
            // 
            KundeReservierungen_Delete.BackColor = Color.Transparent;
            KundeReservierungen_Delete.FlatStyle = FlatStyle.Popup;
            KundeReservierungen_Delete.Font = new Font("Vacaciones", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KundeReservierungen_Delete.ForeColor = SystemColors.ButtonHighlight;
            KundeReservierungen_Delete.Location = new Point(38, 461);
            KundeReservierungen_Delete.Margin = new Padding(0);
            KundeReservierungen_Delete.Name = "KundeReservierungen_Delete";
            KundeReservierungen_Delete.Size = new Size(422, 55);
            KundeReservierungen_Delete.TabIndex = 12;
            KundeReservierungen_Delete.Text = "Reservierung auflösen";
            KundeReservierungen_Delete.UseVisualStyleBackColor = false;
            KundeReservierungen_Delete.Visible = false;
            KundeReservierungen_Delete.Click += KundeReservierungen_Buttons_Click;
            KundeReservierungen_Delete.MouseEnter += KundeReservierungen_MouseEnter;
            KundeReservierungen_Delete.MouseLeave += KundeReservierungen_MouseLeave;
            // 
            // KundeReservierungen_Grid
            // 
            KundeReservierungen_Grid.AllowUserToAddRows = false;
            KundeReservierungen_Grid.AllowUserToDeleteRows = false;
            KundeReservierungen_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            KundeReservierungen_Grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            KundeReservierungen_Grid.BackgroundColor = Color.White;
            KundeReservierungen_Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            KundeReservierungen_Grid.Location = new Point(38, 108);
            KundeReservierungen_Grid.Name = "KundeReservierungen_Grid";
            KundeReservierungen_Grid.RowHeadersWidth = 51;
            KundeReservierungen_Grid.Size = new Size(711, 221);
            KundeReservierungen_Grid.TabIndex = 13;
            // 
            // KundeReservierungen_Auswahl
            // 
            KundeReservierungen_Auswahl.DropDownStyle = ComboBoxStyle.DropDownList;
            KundeReservierungen_Auswahl.Font = new Font("Segoe UI", 12F);
            KundeReservierungen_Auswahl.FormattingEnabled = true;
            KundeReservierungen_Auswahl.Location = new Point(38, 353);
            KundeReservierungen_Auswahl.Name = "KundeReservierungen_Auswahl";
            KundeReservierungen_Auswahl.Size = new Size(711, 36);
            KundeReservierungen_Auswahl.TabIndex = 14;
            KundeReservierungen_Auswahl.SelectedIndexChanged += KundeReservierungen_Auswahl_SelectedIndexChanged;
            // 
            // KundeReservierungen
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.Hintergrund800x600;
            ClientSize = new Size(782, 553);
            Controls.Add(KundeReservierungen_Auswahl);
            Controls.Add(KundeReservierungen_Grid);
            Controls.Add(KundeReservierungen_Delete);
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
            ((System.ComponentModel.ISupportInitialize)KundeReservierungen_Grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label KundeReservierungen_Seitenname;
        private Button KundeReservierungen_Zurück;
        private Button KundeReservierungen_Delete;
        private DataGridView KundeReservierungen_Grid;
        private ComboBox KundeReservierungen_Auswahl;
    }
}