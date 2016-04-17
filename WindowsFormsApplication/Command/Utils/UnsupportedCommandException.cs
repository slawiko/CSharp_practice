using System;

namespace ListManager.Command.Utils
{
	class UnsupportedCommandException : Exception
	{
		public UnsupportedCommandException() : base()
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
