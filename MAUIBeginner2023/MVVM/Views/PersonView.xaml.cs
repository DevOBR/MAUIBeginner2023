using MAUIBeginner2023.MVVM.ViewModels;

namespace MAUIBeginner2023.MVVM.Views;

public partial class PersonView : ContentPage
{
	public PersonView()
	{
		InitializeComponent();
		BindingContext = new PersonViewModel();
	}
}
