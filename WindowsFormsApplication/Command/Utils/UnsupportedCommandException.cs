using System;

namespace ListManager.Command.Utils
{
	class UnsupportedCommandException : Exception
	{
		public UnsupportedCommandException() : base("Unsupported command!")
		{
		}

		public UnsupportedCommandException(string message) : base(message)
		{
		}

		public UnsupportedCommandException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}
