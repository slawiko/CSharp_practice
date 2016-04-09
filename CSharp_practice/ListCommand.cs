using System;
using System.Collections.Generic;

namespace CSharp_practice
{
	class ListCommand : ICommand
	{
		private ITarget _target;
		private int _start;
		private int _finish;

		public ListCommand()
		{
		}

		public void Execute(ITarget target, string[] args, LinkedList<ICommand> undoStack)
		{
			this._target = target;
			if (args.Length == 3 &&
				int.TryParse(args[1], out this._start) &&
				int.TryParse(args[2], out this._finish))
			{
				this._start--;
				this._finish--;
				if (IsInRange(this._finish) && IsInRange(this._start))
				{
					if (this._start <= this._finish)
					{
						for (var i = this._start; i <= this._finish; i++)
						{
							PrintItem(i);
						}
					}
					else
					{
						for (var i = this._start; i >= this._finish; i--)
						{
							PrintItem(i);
						}
					}
				}
				else
				{
					for (var i = 0; i < this._target.Count(); i++)
					{
						PrintItem(i);
					}
				}
			}
			else if (args[1] == "all")
			{
				for (var i = 0; i < this._target.Count(); i++)
				{
					PrintItem(i);
				}
			}
			else
			{
				throw new InvalidArgumentsException();
			}
			undoStack.AddLast(this);
		}

		public void Undo()
		{
			throw new UndoException();
		}

		private void PrintItem(int index)
		{
			Console.WriteLine(this._target.ElementAt(index));
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

		public bool IsUndoible()
		{
			return false;
		}
	}
}
