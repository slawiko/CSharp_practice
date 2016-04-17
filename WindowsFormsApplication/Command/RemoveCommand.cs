using System.Collections.Generic;
using ListManager.Command.Utils;

namespace CommandListManager.Command
{
	class RemoveCommand : ICommand
	{
		private ITarget _target;
		private ITarget _backup;
		private Point _item;
		private int _index;

		public RemoveCommand()
		{
		}

		public void Execute(ITarget target, string[] args, LinkedList<ICommand> undoStack)
		{
			if (int.TryParse(args[1], out this._index))
			{
				this._target = target;
				try
				{
					this._item = this._target.ElementAt(this._index - 1);
				}
				catch (System.ArgumentOutOfRangeException aoor)
				{
					throw new NoSuchItemException();
				}
				if (!target.Remove(this._item))
				{
					throw new NoSuchItemException();
				}
			}
			else if (args[1] == "all")
			{
				this._target = target;
				this._backup = target.Clone();
				this._target.Clear();
			}
			else
			{
				throw new InvalidArgumentsException();
			}
			undoStack.AddLast(this);
		}

		public void Undo()
		{
			if (this._target.Contains(this._item))
			{
				throw new UndoException();
			}
			else if (this._backup != null)
			{
				this._target.ReplaceAll(this._backup);
			}
			else
			{
				this._target.Add(this._item);
			}
		}

		public bool IsUndoible()
		{
			return true;
		}
	}
}
