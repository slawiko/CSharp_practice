using System;
using System.Collections.Generic;
using ListManager.Command.Utils;

namespace ListManager.Command
{
	class UndoCommand : ICommand
	{
		public bool IsUndoible()
		{
			return false;
		}

		public void Undo()
		{
			throw new UndoException();
		}

		public void Execute(ITarget target, string[] args, LinkedList<ICommand> undoStack)
		{
			int n;
			if (args.Length == 0)
			{
				try
				{
					if (undoStack.Last == null)
					{
						throw new UndoException();
					}
					if (undoStack.Last.Value.IsUndoible())
					{
						undoStack.Last.Value.Undo();
						undoStack.RemoveLast();
					}
					else
					{
						undoStack.RemoveLast();
					}
				}
				catch (UndoException u)
				{
					Console.WriteLine(u.Message);
				}
			}
			else if (args[0].Equals("list"))
			{
				Console.WriteLine("Previous commands:");
				foreach (var command in undoStack)
				{
					Console.WriteLine("    " + command);
				}
				return;
			}
			else if (int.TryParse(args[0], out n))
			{
				while (undoStack.Last != null && n > 0)
				{
					if (undoStack.Last.Value.IsUndoible())
					{
						undoStack.Last.Value.Undo();
						undoStack.RemoveLast();
					}
					else
					{
						undoStack.RemoveLast();
					}
					n--;
				}
			}
			else
			{
				throw new InvalidArgumentsException();
			}
		}
	}
}
