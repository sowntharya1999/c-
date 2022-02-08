using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class StartEnd
    {
		public StartEnd(string cities)
		{
			Cities  = cities;

		}

		public string Cities { get; set; }
		
	}
	class PrintCity{
		public void showCity()
        {
			var Citiess = new List<StartEnd>()
		{
			new StartEnd("ROME"),
			new StartEnd("LONDON"),
			new StartEnd("NAIROBI"),
			new StartEnd("CALIFORNIA"),
			new StartEnd("ZURICH" ),
			new StartEnd("NEW DELHI" ),
			new StartEnd("AMSTERDAM" ),
			new StartEnd("ABU DHABI" ),
			new StartEnd("PARIS" ),
			
		};

			//write linq statement for people with last name that starts with the letter D
			var result  = from CityObj in Citiess
						  where CityObj.Cities.StartsWith("A") && CityObj.Cities.EndsWith("M")
						  select CityObj.Cities;
			foreach (var city in result)
            {
				Console.WriteLine("The city starting with A and ending with M is : " + city);
            }

		}


	}
}
