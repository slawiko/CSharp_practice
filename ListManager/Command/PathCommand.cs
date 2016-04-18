using System;
using System.Collections.Generic;
using ListManager.Command.Utils;

namespace ListManager.Command
{
	class PathCommand : ICommand
	{
		private ITarget _target;
		private int _start;
		private int _finish;

		public PathCommand()
		{
		}

		public void Execute(ITarget target, string[] args, LinkedList<ICommand> undoStack)
		{
			if (int.TryParse(args[1], out this._start) &&
				int.TryParse(args[2], out this._finish))
			{
				this._start--;
				this._finish--;
				this._target = target;
				if (IsInRange(this._finish) && IsInRange(this._start))
				{
					System.Console.WriteLine(this._target.CountPath(this._start, this._finish));
				}
				else
				{
					System.Console.WriteLine(this._target.CountPath(0, this._target.Count() - 1));
				}
			}
			else
			{
				throw new InvalidArgumentsException();
			}
			undoStack.AddLast(this);
		}

		private bool IsInRange(int index)
		{
			bool isInRange;
			if (index >= 0 && index < this._target.Count())
			{
				isInRange = true;
			}
			else
			{
				isInRange = false;
			}

			return isInRange;
		}

		public void Undo()
		{
			throw new UndoException();
		}

		public bool IsUndoible()
		{
			return false;
		}
	}
}
