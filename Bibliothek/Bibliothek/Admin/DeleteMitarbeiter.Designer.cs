namespace Bibliothek.Admin
{
    partial class DeleteMitarbeiter
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
            delMitarbeiter_List = new ComboBox();
            label1 = new Label();
            delMitarbeiter_Löschen = new Button();
            delMitarbeiter_Abbrechen = new Button();
            SuspendLayout();
            // 
            // delMitarbeiter_List
            // 
            delMitarbeiter_List.FormattingEnabled = true;
            delMitarbeiter_List.Location = new Point(63, 89);
            delMitarbeiter_List.Name = "delMitarbeiter_List";
            delMitarbeiter_List.Size = new Size(274, 36);
            delMitarbeiter_List.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(54, 18);
            label1.Name = "label1";
            label1.Size = new Size(294, 41);
            label1.TabIndex = 1;
            label1.Text = "Mitarbeiter löschen";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // delMitarbeiter_Löschen
            // 
            delMitarbeiter_Löschen.Location = new Point(63, 153);
            delMitarbeiter_Löschen.Name = "delMitarbeiter_Löschen";
            delMitarbeiter_Löschen.Size = new Size(129, 48);
            delMitarbeiter_Löschen.TabIndex = 2;
            delMitarbeiter_Löschen.Text = "Löschen";
            delMitarbeiter_Löschen.UseVisualStyleBackColor = true;
            // 
            // delMitarbeiter_Abbrechen
            // 
            delMitarbeiter_Abbrechen.Location = new Point(208, 153);
            delMitarbeiter_Abbrechen.Name = "delMitarbeiter_Abbrechen";
            delMitarbeiter_Abbrechen.Size = new Size(129, 48);
            delMitarbeiter_Abbrechen.TabIndex = 3;
            delMitarbeiter_Abbrechen.Text = "Abbrechen";
            delMitarbeiter_Abbrechen.UseVisualStyleBackColor = true;
            // 
            // DeleteMitarbeiter
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Hintergrund800x600;
            ClientSize = new Size(388, 224);
            Controls.Add(delMitarbeiter_Abbrechen);
            Controls.Add(delMitarbeiter_Löschen);
            Controls.Add(label1);
            Controls.Add(delMitarbeiter_List);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DeleteMitarbeiter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Delete Mitarbeiter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox delMitarbeiter_List;
        private Label label1;
        private Button delMitarbeiter_Löschen;
        private Button delMitarbeiter_Abbrechen;
    }
}