using System;

namespace ListManager.Command.Utils
{
	class UnsupportedFormatException : Exception
	{
		public UnsupportedFormatException() : base("Unsupported format!")
		{
		}

		public UnsupportedFormatException(string message) : base(message)
		{
		}

		public UnsupportedFormatException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}
