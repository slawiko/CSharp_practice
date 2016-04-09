using System.Collections.Generic;

namespace CSharp_practice
{
	class SortCommand : ICommand
	{
		private ITarget _target;
		private ITarget _backup;
		private bool _executed;

		public SortCommand()
		{
		}

		public void Execute(ITarget target, string[] args, LinkedList<ICommand> undoStack)
		{
			this._target = target;
			this._backup = target.Clone();
			this._target.Sort();
			this._executed = true;
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
