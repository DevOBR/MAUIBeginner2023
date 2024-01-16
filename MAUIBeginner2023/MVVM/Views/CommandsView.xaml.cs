using MAUIBeginner2023.MVVM.ViewModels;

namespace MAUIBeginner2023.MVVM.Views;

public partial class CommandsView : ContentPage
{
	public CommandsView()
	{
		InitializeComponent();
		BindingContext = new CommandsViewModel();
	}
}
