using System;

namespace ListManager.Command.Utils
{
	class InvalidArgumentsException : Exception
	{
		public InvalidArgumentsException() : base("Invaild arguments!")
		{
		}

		public InvalidArgumentsException(string message) : base(message)
		{
		}

		public InvalidArgumentsException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}
