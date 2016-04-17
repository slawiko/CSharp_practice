using System;

namespace Command.Utils
{
	class NoSuchItemException : Exception
	{
		public NoSuchItemException() : base()
		{
		}

		public NoSuchItemException(string message) : base(message)
		{
		}

		public NoSuchItemException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}
