namespace Bibliothek.Admin
{
    partial class Statistik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistik));
            statistik_DataGrid = new DataGridView();
            statistik_Name = new Label();
            statistik_Optionen = new ComboBox();
            statistik_Label_Optionen = new Label();
            statistik_Erstellen = new Button();
            statistik_Abbrechen = new Button();
            ((System.ComponentModel.ISupportInitialize)statistik_DataGrid).BeginInit();
            SuspendLayout();
            // 
            // statistik_DataGrid
            // 
            statistik_DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            statistik_DataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            statistik_DataGrid.BackgroundColor = SystemColors.Control;
            statistik_DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            statistik_DataGrid.Location = new Point(12, 165);
            statistik_DataGrid.Name = "statistik_DataGrid";
            statistik_DataGrid.RowHeadersWidth = 51;
            statistik_DataGrid.Size = new Size(758, 306);
            statistik_DataGrid.TabIndex = 0;
            // 
            // statistik_Name
            // 
            statistik_Name.AutoSize = true;
            statistik_Name.BackColor = Color.Transparent;
            statistik_Name.Font = new Font("Vacaciones", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statistik_Name.ForeColor = SystemColors.ButtonHighlight;
            statistik_Name.Location = new Point(284, 20);
            statistik_Name.Name = "statistik_Name";
            statistik_Name.Size = new Size(205, 55);
            statistik_Name.TabIndex = 1;
            statistik_Name.Text = "Statistik";
            // 
            // statistik_Optionen
            // 
            statistik_Optionen.FormattingEnabled = true;
            statistik_Optionen.Items.AddRange(new object[] { "Bücher", "Strafen", "Alles" });
            statistik_Optionen.Location = new Point(362, 92);
            statistik_Optionen.Name = "statistik_Optionen";
            statistik_Optionen.Size = new Size(312, 36);
            statistik_Optionen.TabIndex = 2;
            // 
            // statistik_Label_Optionen
            // 
            statistik_Label_Optionen.AutoSize = true;
            statistik_Label_Optionen.BackColor = Color.Transparent;
            statistik_Label_Optionen.Font = new Font("Vacaciones", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statistik_Label_Optionen.ForeColor = SystemColors.ButtonFace;
            statistik_Label_Optionen.Location = new Point(199, 92);
            statistik_Label_Optionen.Name = "statistik_Label_Optionen";
            statistik_Label_Optionen.Size = new Size(121, 41);
            statistik_Label_Optionen.TabIndex = 3;
            statistik_Label_Optionen.Text = "Option";
            // 
            // statistik_Erstellen
            // 
            statistik_Erstellen.BackColor = Color.Transparent;
            statistik_Erstellen.FlatStyle = FlatStyle.Popup;
            statistik_Erstellen.Font = new Font("Vacaciones", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statistik_Erstellen.ForeColor = Color.White;
            statistik_Erstellen.Location = new Point(67, 484);
            statistik_Erstellen.Name = "statistik_Erstellen";
            statistik_Erstellen.Size = new Size(217, 57);
            statistik_Erstellen.TabIndex = 4;
            statistik_Erstellen.Text = "Erstellen";
            statistik_Erstellen.UseVisualStyleBackColor = false;
            statistik_Erstellen.MouseEnter += statistik_MouseEnter;
            statistik_Erstellen.MouseLeave += statistik_MouseLeave;
            // 
            // statistik_Abbrechen
            // 
            statistik_Abbrechen.BackColor = Color.Transparent;
            statistik_Abbrechen.FlatStyle = FlatStyle.Popup;
            statistik_Abbrechen.Font = new Font("Vacaciones", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statistik_Abbrechen.ForeColor = Color.White;
            statistik_Abbrechen.Location = new Point(457, 484);
            statistik_Abbrechen.Name = "statistik_Abbrechen";
            statistik_Abbrechen.Size = new Size(217, 57);
            statistik_Abbrechen.TabIndex = 5;
            statistik_Abbrechen.Text = "Abbrechen";
            statistik_Abbrechen.UseVisualStyleBackColor = false;
            statistik_Abbrechen.Click += statistik_Abbrechen_Click;
            statistik_Abbrechen.MouseEnter += statistik_MouseEnter;
            statistik_Abbrechen.MouseLeave += statistik_MouseLeave;
            // 
            // Statistik
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Hintergrund800x600;
            ClientSize = new Size(782, 553);
            Controls.Add(statistik_Abbrechen);
            Controls.Add(statistik_Erstellen);
            Controls.Add(statistik_Label_Optionen);
            Controls.Add(statistik_Optionen);
            Controls.Add(statistik_Name);
            Controls.Add(statistik_DataGrid);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Statistik";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Statistik";
            FormClosing += Statistik_FormClosing;
            Load += Statistik_Load;
            ((System.ComponentModel.ISupportInitialize)statistik_DataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView statistik_DataGrid;
        public Label statistik_Name;
        private ComboBox statistik_Optionen;
        private Label statistik_Label_Optionen;
        private Button statistik_Erstellen;
        private Button statistik_Abbrechen;
    }
}