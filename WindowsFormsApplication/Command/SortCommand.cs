using System.Collections.Generic;
using Command.Utils;

namespace Command
{
	class SortCommand : ICommand
	{
		private ITarget _target;
		private ITarget _backup;

		public SortCommand()
		{
		}

		public void Execute(ITarget target, string[] args, LinkedList<ICommand> undoStack)
		{
			this._target = target;
			this._backup = target.Clone();
			this._target.Sort();
			undoStack.AddLast(this);
		}

		public void Undo()
		{
			this._target.ReplaceAll(this._backup);
		}

		public bool IsUndoible()
		{
			return true;
		}
	}
}
