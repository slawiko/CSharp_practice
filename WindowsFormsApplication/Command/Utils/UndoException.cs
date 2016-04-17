using System;

namespace ListManager.Command.Utils
{
	class UndoException : Exception
	{
		public UndoException() : base()
		{
		}

		public UndoException(string message) : base(message)
		{
		}

		public UndoException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}
