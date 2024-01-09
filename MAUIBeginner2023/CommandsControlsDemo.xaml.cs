namespace MAUIBeginner2023;

public partial class CommandsControlsDemo : ContentPage
{
	public CommandsControlsDemo()
	{
		InitializeComponent();
	}

    void btnTest_Clicked(System.Object sender, System.EventArgs e)
    {
		DisplayAlert("Test", "this is a demo", "ok");
    }

    void RadioButton_CheckedChanged(System.Object sender, Microsoft.Maui.Controls.CheckedChangedEventArgs e)
    {
        DisplayAlert("radio", "test", "ok");
    }

    void SwipeItem_Invoked(System.Object sender, System.EventArgs e)
    {
        DisplayAlert("radio", "element tapped", "ok");
    }
}
