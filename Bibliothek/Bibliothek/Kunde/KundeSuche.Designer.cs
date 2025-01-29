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
            Suche_Seitenueberschrift = new Label();
            Kunde_Suche = new Button();
            Suche_Zurück = new Button();
            Suche_Eingabe = new TextBox();
            statistik_DataGrid = new DataGridView();
            Suche_Sortieroptionen = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)statistik_DataGrid).BeginInit();
            SuspendLayout();
            // 
            // Suche_Seitenueberschrift
            // 
            Suche_Seitenueberschrift.AutoSize = true;
            Suche_Seitenueberschrift.BackColor = Color.Transparent;
            Suche_Seitenueberschrift.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Suche_Seitenueberschrift.ForeColor = Color.Transparent;
            Suche_Seitenueberschrift.Location = new Point(270, 9);
            Suche_Seitenueberschrift.Name = "Suche_Seitenueberschrift";
            Suche_Seitenueberschrift.Size = new Size(214, 37);
            Suche_Seitenueberschrift.TabIndex = 7;
            Suche_Seitenueberschrift.Text = "Büchersuche";
            Suche_Seitenueberschrift.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Kunde_Suche
            // 
            Kunde_Suche.BackColor = Color.Transparent;
            Kunde_Suche.FlatStyle = FlatStyle.Popup;
            Kunde_Suche.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Kunde_Suche.ForeColor = SystemColors.ButtonHighlight;
            Kunde_Suche.Location = new Point(572, 444);
            Kunde_Suche.Margin = new Padding(0);
            Kunde_Suche.Name = "Kunde_Suche";
            Kunde_Suche.Size = new Size(203, 55);
            Kunde_Suche.TabIndex = 8;
            Kunde_Suche.Text = "Büchersuche";
            Kunde_Suche.UseVisualStyleBackColor = false;
            // 
            // Suche_Zurück
            // 
            Suche_Zurück.BackColor = Color.Transparent;
            Suche_Zurück.FlatStyle = FlatStyle.Popup;
            Suche_Zurück.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Suche_Zurück.ForeColor = SystemColors.ButtonHighlight;
            Suche_Zurück.Location = new Point(9, 508);
            Suche_Zurück.Margin = new Padding(0);
            Suche_Zurück.Name = "Suche_Zurück";
            Suche_Zurück.Size = new Size(766, 44);
            Suche_Zurück.TabIndex = 11;
            Suche_Zurück.Text = "Zurück";
            Suche_Zurück.UseVisualStyleBackColor = false;
            // 
            // Suche_Eingabe
            // 
            Suche_Eingabe.Location = new Point(12, 62);
            Suche_Eingabe.Name = "Suche_Eingabe";
            Suche_Eingabe.Size = new Size(607, 23);
            Suche_Eingabe.TabIndex = 12;
            Suche_Eingabe.Text = "Suche - Titel / Autor / Genre / ISBN eingeben";
            // 
            // statistik_DataGrid
            // 
            statistik_DataGrid.AllowUserToAddRows = false;
            statistik_DataGrid.AllowUserToDeleteRows = false;
            statistik_DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            statistik_DataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            statistik_DataGrid.BackgroundColor = SystemColors.Control;
            statistik_DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            statistik_DataGrid.Location = new Point(9, 135);
            statistik_DataGrid.Name = "statistik_DataGrid";
            statistik_DataGrid.RowHeadersWidth = 51;
            statistik_DataGrid.Size = new Size(610, 306);
            statistik_DataGrid.TabIndex = 13;
            // 
            // Suche_Sortieroptionen
            // 
            Suche_Sortieroptionen.FormattingEnabled = true;
            Suche_Sortieroptionen.Location = new Point(12, 91);
            Suche_Sortieroptionen.Name = "Suche_Sortieroptionen";
            Suche_Sortieroptionen.Size = new Size(121, 23);
            Suche_Sortieroptionen.TabIndex = 14;
            Suche_Sortieroptionen.Text = "Sortieroptionen";
            // 
            // KundeSuche
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Hintergrund800x600;
            ClientSize = new Size(784, 561);
            Controls.Add(Suche_Sortieroptionen);
            Controls.Add(statistik_DataGrid);
            Controls.Add(Suche_Eingabe);
            Controls.Add(Suche_Zurück);
            Controls.Add(Kunde_Suche);
            Controls.Add(Suche_Seitenueberschrift);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "KundeSuche";
            Text = "KundeSuche";
            ((System.ComponentModel.ISupportInitialize)statistik_DataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Suche_Seitenueberschrift;
        private Button Kunde_Suche;
        private Button Suche_Zurück;
        private TextBox Suche_Eingabe;
        private DataGridView statistik_DataGrid;
        private ComboBox Suche_Sortieroptionen;
    }
}