using System;


namespace TodoIt.Data
{
	public class PersonSeqvencer
	{
		private static int personId = 0;

		public static int NextPersonId()
        {
			return personId++;
        }

		public static void Reset()
		{ 
			personId = 0;
		}
	}
}

