namespace LEARNING_CONCEPTS
{
	internal static class Program
	{
		static Program()
		{
		}

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

			file.Attribute = File.FileAttribute.Hidden;

			file.Attribute =
				File.FileAttribute.Hidden | File.FileAttribute.System | File.FileAttribute.Archive;

			if (file.Attribute == File.FileAttribute.Hidden)
			{
			}

			if ((file.Attribute & File.FileAttribute.Hidden) == File.FileAttribute.Hidden)
			{
			}

			if ((file.Attribute & (File.FileAttribute.Hidden | File.FileAttribute.System)) ==
				(File.FileAttribute.Hidden | File.FileAttribute.System))
			{
			}

			System.Console.Write("Press [ENTER] To Exit... ");
			System.Console.ReadLine();
		}
	}
}
