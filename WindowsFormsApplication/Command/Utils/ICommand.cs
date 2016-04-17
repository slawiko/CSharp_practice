using System.Collections.Generic;

namespace Command.Utils
{
	interface ICommand
	{
		void Execute(ITarget target, string[] args, LinkedList<ICommand> undoStack);
		void Undo();
		bool IsUndoible();
	}
}
