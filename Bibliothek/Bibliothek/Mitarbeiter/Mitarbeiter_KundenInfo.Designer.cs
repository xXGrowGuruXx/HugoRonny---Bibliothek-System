namespace Bibliothek.Mitarbeiter
{
    partial class Mitarbeiter_KundenInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mitarbeiter_KundenInfo));
            kundenInfo_Options = new ComboBox();
            kundenInfo_Name = new Label();
            kundenInfo_Grid = new DataGridView();
            kundenInfo_Zurück = new Button();
            ((System.ComponentModel.ISupportInitialize)kundenInfo_Grid).BeginInit();
            SuspendLayout();
            // 
            // kundenInfo_Options
            // 
            kundenInfo_Options.DropDownStyle = ComboBoxStyle.DropDownList;
            kundenInfo_Options.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kundenInfo_Options.FormattingEnabled = true;
            kundenInfo_Options.Items.AddRange(new object[] { "Ausgeliehen", "Reservierungen", "Strafen" });
            kundenInfo_Options.Location = new Point(12, 117);
            kundenInfo_Options.Name = "kundenInfo_Options";
            kundenInfo_Options.Size = new Size(310, 36);
            kundenInfo_Options.TabIndex = 0;
            kundenInfo_Options.SelectedIndexChanged += kundenInfo_Options_SelectedIndexChanged;
            // 
            // kundenInfo_Name
            // 
            kundenInfo_Name.AutoSize = true;
            kundenInfo_Name.BackColor = Color.Transparent;
            kundenInfo_Name.Font = new Font("Vacaciones", 28.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kundenInfo_Name.ForeColor = Color.White;
            kundenInfo_Name.Location = new Point(241, 19);
            kundenInfo_Name.Name = "kundenInfo_Name";
            kundenInfo_Name.Size = new Size(310, 65);
            kundenInfo_Name.TabIndex = 1;
            kundenInfo_Name.Text = "Kunden Info";
            // 
            // kundenInfo_Grid
            // 
            kundenInfo_Grid.AllowUserToAddRows = false;
            kundenInfo_Grid.AllowUserToDeleteRows = false;
            kundenInfo_Grid.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kundenInfo_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            kundenInfo_Grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            kundenInfo_Grid.BackgroundColor = SystemColors.Control;
            kundenInfo_Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kundenInfo_Grid.Location = new Point(12, 178);
            kundenInfo_Grid.Name = "kundenInfo_Grid";
            kundenInfo_Grid.RowHeadersWidth = 51;
            kundenInfo_Grid.Size = new Size(758, 363);
            kundenInfo_Grid.TabIndex = 2;
            // 
            // kundenInfo_Zurück
            // 
            kundenInfo_Zurück.BackColor = Color.Transparent;
            kundenInfo_Zurück.FlatStyle = FlatStyle.Popup;
            kundenInfo_Zurück.Font = new Font("Vacaciones", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kundenInfo_Zurück.ForeColor = Color.White;
            kundenInfo_Zurück.Location = new Point(586, 110);
            kundenInfo_Zurück.Name = "kundenInfo_Zurück";
            kundenInfo_Zurück.Size = new Size(184, 55);
            kundenInfo_Zurück.TabIndex = 3;
            kundenInfo_Zurück.Text = "Zurück";
            kundenInfo_Zurück.UseVisualStyleBackColor = false;
            kundenInfo_Zurück.Click += kundenInfo_Zurück_Click;
            kundenInfo_Zurück.MouseEnter += kundenInfo_Zurück_MouseEnter;
            kundenInfo_Zurück.MouseLeave += kundenInfo_Zurück_MouseLeave;
            // 
            // Mitarbeiter_KundenInfo
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.Hintergrund800x600;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(782, 553);
            Controls.Add(kundenInfo_Zurück);
            Controls.Add(kundenInfo_Grid);
            Controls.Add(kundenInfo_Name);
            Controls.Add(kundenInfo_Options);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(800, 600);
            MinimumSize = new Size(800, 600);
            Name = "Mitarbeiter_KundenInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mitarbeiter_KundenInfo";
            ((System.ComponentModel.ISupportInitialize)kundenInfo_Grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox kundenInfo_Options;
        private Label kundenInfo_Name;
        private DataGridView kundenInfo_Grid;
        private Button kundenInfo_Zurück;
    }
}