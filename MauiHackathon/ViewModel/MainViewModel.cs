using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiHackathon.ViewModel;
public partial class MainViewModel : ObservableObject
{
    [RelayCommand]
    async Task Tap()
    {
        //await Shell.Current.GoToAsync($"{nameof(FlashcardsPage)}?Text={s}");
        await Shell.Current.GoToAsync(nameof(FlashcardsPage));
    }
}
