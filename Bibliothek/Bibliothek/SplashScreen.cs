using Bibliothek.utils;

namespace Bibliothek
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void CenterLabel(Label status)
        {
            // Berechne die X-Position, um das Label horizontal zu zentrieren
            int x = (this.ClientSize.Width - status.Width) / 2;

            // Setze die Position des Labels
            status.Location = new Point(x, status.Location.Y);
        }

        private async void SplashScreen_Shown(object sender, EventArgs e)
        {
            status.Text = "Ressourcen werden geladen.\nBitte warte einen Moment...";
            CenterLabel(status);

            await Task.Delay(2000);

            status.Text = "Wende Schriftart an...";
            CenterLabel(status);

            await Task.Delay(2000);

            // Lese Schriftarten im Hintergrund
            await Task.Run(() => CustomFonts.LoadSchriftarten());

            // Update den Fortschritt auf 50%
            bar.Value = 50;

            await Task.Delay(2000);

            status.Text = "Kopiere Datenbank...";
            CenterLabel(status);

            await Task.Delay(2000);

            // Lade Datenbank im Hintergrund
            await Task.Run(() => Database.LoadDatabase());

            // Update den Fortschritt auf 100%
            bar.Value = 100;

            status.Text = "Ressourcen wurden geladen.";
            CenterLabel(status);

            // Warte ein wenig, bevor der Login gestartet wird
            await Task.Delay(1000);

            // SplashScreen schließen
            this.Hide();

            // Login-Form anzeigen
            Login login = new Login();
            login.Show();
        }
    }
}