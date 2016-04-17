using System;

namespace ListManager.Command.Utils
{
	class UndoException : Exception
	{
		public UndoException() : base("Undo error!")
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
