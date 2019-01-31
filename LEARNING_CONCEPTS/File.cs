namespace LEARNING_CONCEPTS
{
	public class File
	{
		public enum FileAttribute : byte
		{
			System = 1,
			Hidden = 2,
			Archive = 4,
			Compress = 8,
			ReadOnly = 16,
		}

		public File()
		{
		}

		public int Size;

		public string Name;

		public FileAttribute Attribute;
	}
}
