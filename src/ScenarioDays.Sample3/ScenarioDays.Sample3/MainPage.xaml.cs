using ScenarioDays.Sample3.ViewModels;

namespace ScenarioDays.Sample3;

public partial class MainPage : ContentPage
{ 
	public MainPage()
	{
		InitializeComponent();

        BindingContext = new SneakersViewModel();
    }
}


