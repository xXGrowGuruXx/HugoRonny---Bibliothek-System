namespace Bibliothek.Mitarbeiter
{
    partial class Mitarbeiter_Kunden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mitarbeiter_Kunden));
            kunden_Seitenname = new Label();
            mitarbeiterKunden_Label_Username = new Label();
            mitarbeiterKunden_Username = new TextBox();
            mitarbeiterKunden_List = new ComboBox();
            mitarbeiterKunden_Label_Name = new Label();
            mitarbeiterKunden_Label_Vorname = new Label();
            mitarbeiterKunden_Name = new TextBox();
            mitarbeiterKunden_Vorname = new TextBox();
            mitarbeiterKunden_Speichern = new Button();
            mitarbeiterKunden_Zurueck = new Button();
            mitarbeiterKunden_Info = new Button();
            mitarbeiterKunden_Passwort = new TextBox();
            mitarbeiterKunden_Label_Passwort = new Label();
            SuspendLayout();
            // 
            // kunden_Seitenname
            // 
            kunden_Seitenname.AutoSize = true;
            kunden_Seitenname.BackColor = Color.Transparent;
            kunden_Seitenname.Font = new Font("Vacaciones", 28.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kunden_Seitenname.ForeColor = Color.Transparent;
            kunden_Seitenname.Location = new Point(307, 31);
            kunden_Seitenname.Margin = new Padding(2, 0, 2, 0);
            kunden_Seitenname.Name = "kunden_Seitenname";
            kunden_Seitenname.Size = new Size(213, 65);
            kunden_Seitenname.TabIndex = 6;
            kunden_Seitenname.Text = "Kunden ";
            kunden_Seitenname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mitarbeiterKunden_Label_Username
            // 
            mitarbeiterKunden_Label_Username.AutoSize = true;
            mitarbeiterKunden_Label_Username.BackColor = Color.Transparent;
            mitarbeiterKunden_Label_Username.Font = new Font("Vacaciones", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mitarbeiterKunden_Label_Username.ForeColor = SystemColors.ButtonHighlight;
            mitarbeiterKunden_Label_Username.Location = new Point(115, 316);
            mitarbeiterKunden_Label_Username.Margin = new Padding(2, 0, 2, 0);
            mitarbeiterKunden_Label_Username.Name = "mitarbeiterKunden_Label_Username";
            mitarbeiterKunden_Label_Username.Size = new Size(161, 39);
            mitarbeiterKunden_Label_Username.TabIndex = 8;
            mitarbeiterKunden_Label_Username.Text = "Username";
            // 
            // mitarbeiterKunden_Username
            // 
            mitarbeiterKunden_Username.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mitarbeiterKunden_Username.Location = new Point(307, 316);
            mitarbeiterKunden_Username.Margin = new Padding(2, 3, 2, 3);
            mitarbeiterKunden_Username.Name = "mitarbeiterKunden_Username";
            mitarbeiterKunden_Username.Size = new Size(300, 30);
            mitarbeiterKunden_Username.TabIndex = 9;
            mitarbeiterKunden_Username.TextAlign = HorizontalAlignment.Center;
            mitarbeiterKunden_Username.MouseEnter += mitarbeiter_Kunden_MouseEnter;
            mitarbeiterKunden_Username.MouseLeave += mitarbeiter_Kunden_MouseLeave;
            // 
            // mitarbeiterKunden_List
            // 
            mitarbeiterKunden_List.DropDownStyle = ComboBoxStyle.DropDownList;
            mitarbeiterKunden_List.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mitarbeiterKunden_List.FormattingEnabled = true;
            mitarbeiterKunden_List.Location = new Point(172, 147);
            mitarbeiterKunden_List.Margin = new Padding(2, 3, 2, 3);
            mitarbeiterKunden_List.Name = "mitarbeiterKunden_List";
            mitarbeiterKunden_List.Size = new Size(435, 36);
            mitarbeiterKunden_List.TabIndex = 10;
            mitarbeiterKunden_List.SelectedIndexChanged += mitarbeiterKunden_List_SelectedIndexChanged;
            mitarbeiterKunden_List.MouseEnter += mitarbeiter_Kunden_MouseEnter;
            mitarbeiterKunden_List.MouseLeave += mitarbeiter_Kunden_MouseLeave;
            // 
            // mitarbeiterKunden_Label_Name
            // 
            mitarbeiterKunden_Label_Name.AutoSize = true;
            mitarbeiterKunden_Label_Name.BackColor = Color.Transparent;
            mitarbeiterKunden_Label_Name.Font = new Font("Vacaciones", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mitarbeiterKunden_Label_Name.ForeColor = SystemColors.ButtonHighlight;
            mitarbeiterKunden_Label_Name.Location = new Point(152, 211);
            mitarbeiterKunden_Label_Name.Margin = new Padding(2, 0, 2, 0);
            mitarbeiterKunden_Label_Name.Name = "mitarbeiterKunden_Label_Name";
            mitarbeiterKunden_Label_Name.Size = new Size(96, 39);
            mitarbeiterKunden_Label_Name.TabIndex = 11;
            mitarbeiterKunden_Label_Name.Text = "Name";
            // 
            // mitarbeiterKunden_Label_Vorname
            // 
            mitarbeiterKunden_Label_Vorname.AutoSize = true;
            mitarbeiterKunden_Label_Vorname.BackColor = Color.Transparent;
            mitarbeiterKunden_Label_Vorname.Font = new Font("Vacaciones", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mitarbeiterKunden_Label_Vorname.ForeColor = SystemColors.ButtonHighlight;
            mitarbeiterKunden_Label_Vorname.Location = new Point(129, 255);
            mitarbeiterKunden_Label_Vorname.Margin = new Padding(2, 0, 2, 0);
            mitarbeiterKunden_Label_Vorname.Name = "mitarbeiterKunden_Label_Vorname";
            mitarbeiterKunden_Label_Vorname.Size = new Size(147, 39);
            mitarbeiterKunden_Label_Vorname.TabIndex = 12;
            mitarbeiterKunden_Label_Vorname.Text = "Vorname";
            // 
            // mitarbeiterKunden_Name
            // 
            mitarbeiterKunden_Name.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mitarbeiterKunden_Name.Location = new Point(307, 211);
            mitarbeiterKunden_Name.Margin = new Padding(2, 3, 2, 3);
            mitarbeiterKunden_Name.Name = "mitarbeiterKunden_Name";
            mitarbeiterKunden_Name.Size = new Size(300, 30);
            mitarbeiterKunden_Name.TabIndex = 16;
            mitarbeiterKunden_Name.TextAlign = HorizontalAlignment.Center;
            mitarbeiterKunden_Name.MouseEnter += mitarbeiter_Kunden_MouseEnter;
            mitarbeiterKunden_Name.MouseLeave += mitarbeiter_Kunden_MouseLeave;
            // 
            // mitarbeiterKunden_Vorname
            // 
            mitarbeiterKunden_Vorname.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mitarbeiterKunden_Vorname.Location = new Point(307, 262);
            mitarbeiterKunden_Vorname.Margin = new Padding(2, 3, 2, 3);
            mitarbeiterKunden_Vorname.Name = "mitarbeiterKunden_Vorname";
            mitarbeiterKunden_Vorname.Size = new Size(300, 30);
            mitarbeiterKunden_Vorname.TabIndex = 17;
            mitarbeiterKunden_Vorname.TextAlign = HorizontalAlignment.Center;
            mitarbeiterKunden_Vorname.MouseEnter += mitarbeiter_Kunden_MouseEnter;
            mitarbeiterKunden_Vorname.MouseLeave += mitarbeiter_Kunden_MouseLeave;
            // 
            // mitarbeiterKunden_Speichern
            // 
            mitarbeiterKunden_Speichern.BackColor = Color.Transparent;
            mitarbeiterKunden_Speichern.FlatStyle = FlatStyle.Popup;
            mitarbeiterKunden_Speichern.Font = new Font("Vacaciones", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mitarbeiterKunden_Speichern.ForeColor = SystemColors.Control;
            mitarbeiterKunden_Speichern.Location = new Point(75, 464);
            mitarbeiterKunden_Speichern.Margin = new Padding(2, 3, 2, 3);
            mitarbeiterKunden_Speichern.Name = "mitarbeiterKunden_Speichern";
            mitarbeiterKunden_Speichern.Size = new Size(193, 77);
            mitarbeiterKunden_Speichern.TabIndex = 23;
            mitarbeiterKunden_Speichern.Text = "Speichern";
            mitarbeiterKunden_Speichern.UseVisualStyleBackColor = false;
            mitarbeiterKunden_Speichern.Click += mitarbeiterKunden_Speichern_Click;
            mitarbeiterKunden_Speichern.MouseEnter += mitarbeiter_Kunden_MouseEnter;
            mitarbeiterKunden_Speichern.MouseLeave += mitarbeiter_Kunden_MouseLeave;
            // 
            // mitarbeiterKunden_Zurueck
            // 
            mitarbeiterKunden_Zurueck.BackColor = Color.Transparent;
            mitarbeiterKunden_Zurueck.FlatStyle = FlatStyle.Popup;
            mitarbeiterKunden_Zurueck.Font = new Font("Vacaciones", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mitarbeiterKunden_Zurueck.ForeColor = SystemColors.Control;
            mitarbeiterKunden_Zurueck.Location = new Point(520, 464);
            mitarbeiterKunden_Zurueck.Margin = new Padding(2, 3, 2, 3);
            mitarbeiterKunden_Zurueck.Name = "mitarbeiterKunden_Zurueck";
            mitarbeiterKunden_Zurueck.Size = new Size(193, 77);
            mitarbeiterKunden_Zurueck.TabIndex = 25;
            mitarbeiterKunden_Zurueck.Text = "Zurück";
            mitarbeiterKunden_Zurueck.UseVisualStyleBackColor = false;
            mitarbeiterKunden_Zurueck.Click += mitarbeiter_Kunden_Zurück_Click;
            mitarbeiterKunden_Zurueck.MouseEnter += mitarbeiter_Kunden_MouseEnter;
            mitarbeiterKunden_Zurueck.MouseLeave += mitarbeiter_Kunden_MouseLeave;
            // 
            // mitarbeiterKunden_Info
            // 
            mitarbeiterKunden_Info.BackColor = Color.Transparent;
            mitarbeiterKunden_Info.FlatStyle = FlatStyle.Popup;
            mitarbeiterKunden_Info.Font = new Font("Vacaciones", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mitarbeiterKunden_Info.ForeColor = SystemColors.Control;
            mitarbeiterKunden_Info.Location = new Point(287, 464);
            mitarbeiterKunden_Info.Margin = new Padding(2, 3, 2, 3);
            mitarbeiterKunden_Info.Name = "mitarbeiterKunden_Info";
            mitarbeiterKunden_Info.Size = new Size(233, 77);
            mitarbeiterKunden_Info.TabIndex = 27;
            mitarbeiterKunden_Info.Text = "Info";
            mitarbeiterKunden_Info.UseVisualStyleBackColor = false;
            mitarbeiterKunden_Info.Click += mitarbeiterKunden_Info_Click;
            mitarbeiterKunden_Info.MouseEnter += mitarbeiter_Kunden_MouseEnter;
            mitarbeiterKunden_Info.MouseLeave += mitarbeiter_Kunden_MouseLeave;
            // 
            // mitarbeiterKunden_Passwort
            // 
            mitarbeiterKunden_Passwort.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mitarbeiterKunden_Passwort.Location = new Point(307, 375);
            mitarbeiterKunden_Passwort.Margin = new Padding(2, 3, 2, 3);
            mitarbeiterKunden_Passwort.Name = "mitarbeiterKunden_Passwort";
            mitarbeiterKunden_Passwort.Size = new Size(300, 30);
            mitarbeiterKunden_Passwort.TabIndex = 29;
            mitarbeiterKunden_Passwort.TextAlign = HorizontalAlignment.Center;
            // 
            // mitarbeiterKunden_Label_Passwort
            // 
            mitarbeiterKunden_Label_Passwort.AutoSize = true;
            mitarbeiterKunden_Label_Passwort.BackColor = Color.Transparent;
            mitarbeiterKunden_Label_Passwort.Font = new Font("Vacaciones", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mitarbeiterKunden_Label_Passwort.ForeColor = SystemColors.ButtonHighlight;
            mitarbeiterKunden_Label_Passwort.Location = new Point(129, 368);
            mitarbeiterKunden_Label_Passwort.Margin = new Padding(2, 0, 2, 0);
            mitarbeiterKunden_Label_Passwort.Name = "mitarbeiterKunden_Label_Passwort";
            mitarbeiterKunden_Label_Passwort.Size = new Size(151, 39);
            mitarbeiterKunden_Label_Passwort.TabIndex = 28;
            mitarbeiterKunden_Label_Passwort.Text = "Passwort";
            // 
            // Mitarbeiter_Kunden
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.Hintergrund800x600;
            ClientSize = new Size(782, 553);
            Controls.Add(mitarbeiterKunden_Passwort);
            Controls.Add(mitarbeiterKunden_Label_Passwort);
            Controls.Add(mitarbeiterKunden_Info);
            Controls.Add(mitarbeiterKunden_Zurueck);
            Controls.Add(mitarbeiterKunden_Speichern);
            Controls.Add(mitarbeiterKunden_Vorname);
            Controls.Add(mitarbeiterKunden_Name);
            Controls.Add(mitarbeiterKunden_Label_Vorname);
            Controls.Add(mitarbeiterKunden_Label_Name);
            Controls.Add(mitarbeiterKunden_List);
            Controls.Add(mitarbeiterKunden_Username);
            Controls.Add(mitarbeiterKunden_Label_Username);
            Controls.Add(kunden_Seitenname);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            MaximumSize = new Size(800, 600);
            MinimizeBox = false;
            MinimumSize = new Size(800, 600);
            Name = "Mitarbeiter_Kunden";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mitarbeiter_Kunden";
            FormClosing += mitarbeiter_Kunden;
            Load += Mitarbeiter_Kunden_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label kunden_Seitenname;
        private Label mitarbeiterKunden_Label_Username;
        private TextBox mitarbeiterKunden_Username;
        private ComboBox mitarbeiterKunden_List;
        private Label mitarbeiterKunden_Label_Name;
        private Label mitarbeiterKunden_Label_Vorname;
        private TextBox mitarbeiterKunden_Name;
        private TextBox mitarbeiterKunden_Vorname;
        private Button mitarbeiterKunden_Speichern;
        private Button mitarbeiterKunden_Zurueck;
        private Button mitarbeiterKunden_Reservierungen;
        private Button mitarbeiterKunden_Info;
        private TextBox mitarbeiterKunden_Passwort;
        private Label mitarbeiterKunden_Label_Passwort;
    }
}