using System;
using System.Collections.Generic;
using ListManager.Command.Utils;

namespace ListManager.Command
{
	class ExitCommand : ICommand
	{
		public void Execute(ITarget target, string[] args, LinkedList<ICommand> undoStack)
		{
			Environment.Exit(0);
		}

		public bool IsUndoible()
		{
			return false;
		}

		public void Undo()
		{
			throw new NotImplementedException();
		}
	}
}
