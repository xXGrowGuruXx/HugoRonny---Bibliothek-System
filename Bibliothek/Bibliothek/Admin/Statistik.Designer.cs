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
            ((System.ComponentModel.ISupportInitialize)statistik_DataGrid).BeginInit();
            SuspendLayout();
            // 
            // statistik_DataGrid
            // 
            statistik_DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            statistik_DataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            statistik_DataGrid.BackgroundColor = SystemColors.Control;
            statistik_DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            statistik_DataGrid.Location = new Point(12, 90);
            statistik_DataGrid.Name = "statistik_DataGrid";
            statistik_DataGrid.RowHeadersWidth = 51;
            statistik_DataGrid.Size = new Size(758, 451);
            statistik_DataGrid.TabIndex = 0;
            // 
            // statistik_Name
            // 
            statistik_Name.AutoSize = true;
            statistik_Name.BackColor = Color.Transparent;
            statistik_Name.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statistik_Name.ForeColor = SystemColors.ButtonHighlight;
            statistik_Name.Location = new Point(299, 22);
            statistik_Name.Name = "statistik_Name";
            statistik_Name.Size = new Size(134, 41);
            statistik_Name.TabIndex = 1;
            statistik_Name.Text = "Statistik";
            // 
            // Statistik
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Hintergrund800x600;
            ClientSize = new Size(782, 553);
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
            ((System.ComponentModel.ISupportInitialize)statistik_DataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView statistik_DataGrid;
        public Label statistik_Name;
    }
}