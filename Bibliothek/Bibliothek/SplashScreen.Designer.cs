namespace Bibliothek
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            status = new Label();
            bar = new ProgressBar();
            SuspendLayout();
            // 
            // status
            // 
            status.AutoSize = true;
            status.ForeColor = Color.Black;
            status.Location = new Point(144, 9);
            status.Name = "status";
            status.Size = new Size(59, 23);
            status.TabIndex = 0;
            status.Text = "dasd";
            status.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bar
            // 
            bar.Location = new Point(12, 78);
            bar.Name = "bar";
            bar.Size = new Size(358, 52);
            bar.TabIndex = 1;
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Hintergrund800x600;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(382, 153);
            Controls.Add(bar);
            Controls.Add(status);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(400, 200);
            MinimizeBox = false;
            MinimumSize = new Size(400, 200);
            Name = "SplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Shown += SplashScreen_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label status;
        private ProgressBar bar;
    }
}