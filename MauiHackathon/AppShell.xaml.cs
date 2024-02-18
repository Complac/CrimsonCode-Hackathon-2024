namespace MauiHackathon
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(FlashcardsPage), typeof(FlashcardsPage));
        }
    }
}
