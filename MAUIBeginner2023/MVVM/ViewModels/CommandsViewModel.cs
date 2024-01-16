using System;
using System.Windows.Input;

namespace MAUIBeginner2023.MVVM.ViewModels
{
	public class CommandsViewModel
	{
		public CommandsViewModel()
		{
		}

		public string SearchTerm { get; set; }
        public ICommand ClickCommand => new Command(() => App.Current.MainPage.DisplayAlert("Title", "Message", "ok"));
        public ICommand SerchCommand => new Command(() => App.Current.MainPage.DisplayAlert("Searhing", $"You searched: {SearchTerm}", "ok"));


	}
}

