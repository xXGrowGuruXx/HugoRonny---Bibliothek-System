namespace Bibliothek.Mitarbeiter
{
    partial class Mitarbeiter_Autoren
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mitarbeiter_Autoren));
            autoren_Seitenname = new Label();
            autoren_List = new ComboBox();
            autoren_Label_Name = new Label();
            autoren_Name = new TextBox();
            autoren_Speichern = new Button();
            autoren_Zurueck = new Button();
            SuspendLayout();
            // 
            // autoren_Seitenname
            // 
            autoren_Seitenname.AutoSize = true;
            autoren_Seitenname.BackColor = Color.Transparent;
            autoren_Seitenname.Font = new Font("Vacaciones", 28.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            autoren_Seitenname.ForeColor = Color.Transparent;
            autoren_Seitenname.Location = new Point(287, 54);
            autoren_Seitenname.Name = "autoren_Seitenname";
            autoren_Seitenname.Size = new Size(225, 65);
            autoren_Seitenname.TabIndex = 7;
            autoren_Seitenname.Text = "Autoren";
            autoren_Seitenname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // autoren_List
            // 
            autoren_List.DropDownStyle = ComboBoxStyle.DropDownList;
            autoren_List.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            autoren_List.FormattingEnabled = true;
            autoren_List.Location = new Point(135, 195);
            autoren_List.Name = "autoren_List";
            autoren_List.Size = new Size(512, 45);
            autoren_List.TabIndex = 11;
            autoren_List.SelectedIndexChanged += autoren_List_SelectedIndexChanged;
            autoren_List.MouseEnter += mitarbeiter_Autoren_MouseEnter;
            autoren_List.MouseLeave += mitarbeiter_Autoren_MouseLeave;
            // 
            // autoren_Label_Name
            // 
            autoren_Label_Name.AutoSize = true;
            autoren_Label_Name.BackColor = Color.Transparent;
            autoren_Label_Name.Font = new Font("Vacaciones", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            autoren_Label_Name.ForeColor = SystemColors.ButtonHighlight;
            autoren_Label_Name.Location = new Point(122, 298);
            autoren_Label_Name.Name = "autoren_Label_Name";
            autoren_Label_Name.Size = new Size(115, 47);
            autoren_Label_Name.TabIndex = 12;
            autoren_Label_Name.Text = "Name";
            // 
            // autoren_Name
            // 
            autoren_Name.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            autoren_Name.Location = new Point(287, 306);
            autoren_Name.Name = "autoren_Name";
            autoren_Name.Size = new Size(360, 38);
            autoren_Name.TabIndex = 17;
            autoren_Name.TextAlign = HorizontalAlignment.Center;
            autoren_Name.MouseEnter += mitarbeiter_Autoren_MouseEnter;
            autoren_Name.MouseLeave += mitarbeiter_Autoren_MouseLeave;
            // 
            // autoren_Speichern
            // 
            autoren_Speichern.BackColor = Color.Transparent;
            autoren_Speichern.FlatStyle = FlatStyle.Popup;
            autoren_Speichern.Font = new Font("Vacaciones", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            autoren_Speichern.ForeColor = SystemColors.Control;
            autoren_Speichern.Location = new Point(122, 481);
            autoren_Speichern.Name = "autoren_Speichern";
            autoren_Speichern.Size = new Size(213, 53);
            autoren_Speichern.TabIndex = 24;
            autoren_Speichern.Text = "Speichern";
            autoren_Speichern.UseVisualStyleBackColor = false;
            autoren_Speichern.Click += autoren_Speichern_Click;
            autoren_Speichern.MouseEnter += mitarbeiter_Autoren_MouseEnter;
            autoren_Speichern.MouseLeave += mitarbeiter_Autoren_MouseLeave;
            // 
            // autoren_Zurueck
            // 
            autoren_Zurueck.BackColor = Color.Transparent;
            autoren_Zurueck.FlatStyle = FlatStyle.Popup;
            autoren_Zurueck.Font = new Font("Vacaciones", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            autoren_Zurueck.ForeColor = SystemColors.Control;
            autoren_Zurueck.Location = new Point(436, 481);
            autoren_Zurueck.Name = "autoren_Zurueck";
            autoren_Zurueck.Size = new Size(211, 53);
            autoren_Zurueck.TabIndex = 26;
            autoren_Zurueck.Text = "Zurück";
            autoren_Zurueck.UseVisualStyleBackColor = false;
            autoren_Zurueck.Click += mitarbeiter_Autoren_Abbrechen_Click;
            autoren_Zurueck.MouseEnter += mitarbeiter_Autoren_MouseEnter;
            autoren_Zurueck.MouseLeave += mitarbeiter_Autoren_MouseLeave;
            // 
            // Mitarbeiter_Autoren
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.Hintergrund800x600;
            ClientSize = new Size(782, 553);
            Controls.Add(autoren_Zurueck);
            Controls.Add(autoren_Speichern);
            Controls.Add(autoren_Name);
            Controls.Add(autoren_Label_Name);
            Controls.Add(autoren_List);
            Controls.Add(autoren_Seitenname);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(800, 600);
            MinimizeBox = false;
            MinimumSize = new Size(800, 600);
            Name = "Mitarbeiter_Autoren";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mitarbeiter_Autoren";
            FormClosing += mitarbeiter_Autoren;
            Load += mitarbeiter_Autoren_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label autoren_Seitenname;
        private ComboBox autoren_List;
        private Label autoren_Label_Name;
        private TextBox autoren_Name;
        private Button autoren_Speichern;
        private Button autoren_Zurueck;
    }
}