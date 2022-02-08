using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
	internal class EvenNumber
	{
		public EvenNumber(int number)
		{
			Number = number;

		}


		public int Number { get; set; }

	}
	class Numbereven
	{
		public void PrintEven()
		{
			var WholeNumber = new List<EvenNumber>()
			
		{
			new EvenNumber( 41),
			new EvenNumber( 22),
			new EvenNumber( 21),
			new EvenNumber( 19 ),
			new EvenNumber( 50 ),
			new EvenNumber( 51 ),
			new EvenNumber(19),


		};

			//write linq statement for people with last name that starts with the letter D
			//var result = from NumberObj in WholeNumber
			//			  where NumberObj.Number % 2 == 0
			//			  select NumberObj.Number;

			var result = from NumberObj in WholeNumber
						 orderby NumberObj.Number descending

						 select NumberObj.Number;

			int count = 0;

			foreach (var numberObj in result)
            {
				Console.WriteLine("Even number is :  " + numberObj);
				count++;
				if(count == 3)
                {
					break;
                }
			}

		}
	}
}
