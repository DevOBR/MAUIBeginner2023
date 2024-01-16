using System;
using MAUIBeginner2023.MVVM.Models;

namespace MAUIBeginner2023.MVVM.ViewModels
{
	public class PeopleViewModel
	{
		public PeopleViewModel()
		{
			People = new()
			{
				new() { Name = "Arcad", Weight = 40, Age = 34, BirthDate = new DateTime(2007,01,01), IsMarried = true, LaunchTime = new TimeSpan() },
                new() { Name = "Pepo", Weight = 31, Age = 41, BirthDate = new DateTime(2010,10,11), IsMarried = true, LaunchTime = new TimeSpan() },
                new() { Name = "Dari", Weight = 21, Age = 33, BirthDate = new DateTime(1999,12,22), IsMarried = false, LaunchTime = new TimeSpan() },
                new() { Name = "Bakar", Weight = 44, Age = 25, BirthDate = new DateTime(1981,03,13), IsMarried = false, LaunchTime = new TimeSpan() },
            };
		}

		public List<Person> People { get; set; }
	}
}

