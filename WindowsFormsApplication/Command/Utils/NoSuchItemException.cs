using System;

namespace ListManager.Command.Utils
{
	class NoSuchItemException : Exception
	{
		public NoSuchItemException() : base("No such item!")
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
