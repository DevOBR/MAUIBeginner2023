namespace MAUIBeginner2023.BindingDemo;

public partial class BindingDemoPage : ContentPage
{
	public BindingDemoPage()
	{
		InitializeComponent();
	}

    void btnOk_Clicked(System.Object sender, System.EventArgs e)
    {
		var person = new Person
		{
			Name = "know paces",
			Phone = "1231324554",
			Address = "Known"
		};

		//var personBinding = new Binding();
		//personBinding.Source = person;
		//personBinding.Path = "Phone";

		//lblName.SetBinding(Label.TextProperty, personBinding);

		BindingContext = person;
		//lblName.SetBinding(Label.TextProperty, "Name");
	}
}
