
using CommunityToolkit.Mvvm.Input;
using MauiHackathon.ViewModel;

namespace MauiHackathon
{
    public partial class MainPage : ContentPage
    {
 

        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = nameof(vm);

            //Array of strings to choose for top label
            string[] randQuotes = new string[]
            {
                "Go Cougs!",
                "I <3 Pullman",
                "Enjoy the sunset today!",
                "Huskies = bad",
                "Got hills?"
            };
            
            Random random = new Random();
            string randString = randQuotes[random.Next(randQuotes.Length)];
            randomQuoteLabel.Text = randString;

            

        }
    }

}
