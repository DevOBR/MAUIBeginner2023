using System;
using MAUIBeginner2023.MVVM.Models;

namespace MAUIBeginner2023.MVVM.ViewModels
{
	public class PersonViewModel
	{
		public PersonViewModel()
		{
			Person = new()
			{
				Name = "Person View Model",
				Age = 25,
				BirthDate = new DateTime(1981, 3, 2),
				IsMarried = true,
				LaunchTime = new TimeSpan(3, 0, 0),
				Weight = 70
			};
		}

		public Person Person { get; set; }
	}
}

