using System.Collections.Generic;
using ListManager.Command.Utils;

namespace ListManager.Command
{
	class AddCommand : ICommand
	{
		private ITarget _target;
		private Point _point;

		public AddCommand()
		{
		}

		public void Execute(ITarget target, string[] args, LinkedList<ICommand> undoStack)
		{
			this._point = new Point();
			if (args.Length != 2 ||
				!double.TryParse(args[0], out this._point.x) ||
				!double.TryParse(args[1], out this._point.y))
			{
				throw new InvalidArgumentsException();
			}
			
			this._target = target;
			this._target.Add(this._point);
			undoStack.AddLast(this);
		}

		public bool IsUndoible()
		{
			return true;
		}

		public void Undo()
		{
			if (this._target.Contains(this._point))
			{
				this._target.RemoveAt(this._target.IndexOf(this._point));
			}
			else
			{
				throw new UndoException();
			}
		}
	}
}
