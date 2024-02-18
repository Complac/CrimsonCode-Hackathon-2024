using MauiHackathon.ViewModel;

namespace MauiHackathon;

public partial class FlashcardsPage : ContentPage
{
	public FlashcardsPage(FlashcardsViewModel vm)
	{
		
		InitializeComponent();
		BindingContext = vm;
		
	}
}