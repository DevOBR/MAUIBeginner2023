namespace MAUIBeginner2023;

public partial class InputControlsDemo : ContentPage
{
	public InputControlsDemo()
	{
		InitializeComponent();
        labelSlider.Text = "0";

    }

    void slider_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
		labelSlider.Text = slider.Value.ToString();
    }

    void stepper_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
        labelSlider.Text = stepper.Value.ToString();
    }
}
