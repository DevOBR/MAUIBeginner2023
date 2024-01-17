using System;
using System.Windows.Input;
using PropertyChanged;

namespace MAUIBeginner2023.MVVM.ViewModels
{
	[AddINotifyPropertyChangedInterface]
	public class DemoAutoPropertyChangeViewModel
	{
		public DemoAutoPropertyChangeViewModel()
		{
		}

		public int Number1 { get; set; }
        public int Number2 { get; set; }
        public int Result { get; set; }

		public ICommand AddCommand => new Command(() => Result = Number1 + Number2);
	}
}

