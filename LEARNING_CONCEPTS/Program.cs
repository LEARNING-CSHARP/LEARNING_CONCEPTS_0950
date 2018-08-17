namespace LEARNING_CONCEPTS
{
	class Program
	{
		static void Main(string[] args)
		{
			Person person = new Person();

			person.FullName = "Ali Reza Alavi";

			person.Gender = Enums.Gender.Male;
			person.Marriage = Enums.Marriage.Married;

			if (person.Gender == Enums.Gender.Female)
			{
				System.Console.WriteLine("You are female!");
			}

			System.Console.WriteLine(person.Gender);
			System.Console.WriteLine((byte)person.Gender);

			switch (person.Marriage)
			{
				case Enums.Marriage.Single:
				{
					break;
				}

				case Enums.Marriage.Married:
				{
					break;
				}

				case Enums.Marriage.Divorced:
				{
					break;
				}
			}

			File file = new File();

			file.Size = 1234;
			file.Name = "Somefile.txt";
			file.Attribute = Enums.FileAttribute.Hidden;
			file.Attribute = Enums.FileAttribute.Hidden | Enums.FileAttribute.System | Enums.FileAttribute.Archive;

			if (file.Attribute == Enums.FileAttribute.Hidden)
			{
			}

			if ((file.Attribute & Enums.FileAttribute.Hidden) == Enums.FileAttribute.Hidden)
			{
			}

			if ((file.Attribute & (Enums.FileAttribute.Hidden | Enums.FileAttribute.System)) ==
				(Enums.FileAttribute.Hidden | Enums.FileAttribute.System))
			{
			}

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
