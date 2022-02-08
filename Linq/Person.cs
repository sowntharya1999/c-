using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Person
    {
		public Person(string firstName, string lastName, int age)
		{
			FirstName = firstName;
			LastName = lastName;
			Age = age;
		}

		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }

		//override ToString to return the person's FirstName LastName Age

	}
	class people
    {
		public void display()
        {
			var people = new List<Person>()
		{
			new Person("Bill", "Smith", 41),
			new Person("Sarah", "Jones", 22),
			new Person("Stacy","Baker", 21),
			new Person("Vivianne","Dexter", 19 ),
			new Person("Bob","Smith", 49 ),
			new Person("Brett","Baker", 51 ),
			new Person("Mark","Parker", 19),
			new Person("Alice","Thompson", 18),
			new Person("Evelyn","Thompson", 58 ),
			new Person("Mort","Martin", 58),
			new Person("Eugene","deLauter", 84 ),
			new Person("Gail","Dawson", 19 ),

		};

			//write linq statement for people with last name that starts with the letter D
			var people1 = from PeopleObj in people
						  where PeopleObj.LastName.StartsWith("D")
						  select PeopleObj;
			



			Console.WriteLine("Number of people who's last name starts with the letter D " + people1.Count());

						  //Write linq statement for first Person Older Than 40 In Descending Alphabetical Order By First Name
			 var person2 = from PeopleObj2 in people
						   where PeopleObj2.Age >=40
						   orderby PeopleObj2.FirstName descending
						   select PeopleObj2.FirstName;
			foreach (var person in person2)
            {
				Console.WriteLine("First Person Older Than 40 in Descending Order by First Name " + person);
			}
			
		}

	}
}

