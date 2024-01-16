using MAUIBeginner2023.MVVM.ViewModels;

namespace MAUIBeginner2023.MVVM.Views;

public partial class PeopleView : ContentPage
{
	public PeopleView()
	{
		InitializeComponent();
		BindingContext = new PeopleViewModel();
	}
}
