using MAUIBeginner2023.MVVM.ViewModels;

namespace MAUIBeginner2023.MVVM.Views;

public partial class DemoAutoPropertyChangeView : ContentPage
{
	public DemoAutoPropertyChangeView()
	{
		InitializeComponent();
		BindingContext = new DemoAutoPropertyChangeViewModel();

    }
}
