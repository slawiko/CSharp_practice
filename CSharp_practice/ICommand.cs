using System.Collections.Generic;

namespace CSharp_practice
{
	interface ICommand
	{
		void Execute(ITarget target, string[] args, LinkedList<ICommand> undoStack);
		void Undo();
		bool IsUndoible();
	}
}
