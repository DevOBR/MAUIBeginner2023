﻿using MAUIBeginner2023.BindingDemo;
using MAUIBeginner2023.MVVM.Views;

namespace MAUIBeginner2023;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		// var navPage = new NavigationPage(new ContentPageDemo());
		// navPage.BarBackgroundColor = Colors.Chocolate;
		// navPage.BarTextColor = Colors.White;
		// MainPage = navPage;
		MainPage = new NavigationPage(new StyleDemoView());
	}
}

