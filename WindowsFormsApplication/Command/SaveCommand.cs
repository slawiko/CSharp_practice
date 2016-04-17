using System;
using System.Collections.Generic;
using System.IO;
using ListManager.Command.Utils;

namespace ListManager.Command
{
	class SaveCommand : ICommand
	{
		private string _path;

		public SaveCommand()
		{
		}

		public void Execute(ITarget target, string[] args, LinkedList<ICommand> undoStack)
		{
			if (String.IsNullOrEmpty(args[1]))
			{
				throw new InvalidArgumentsException();
			}
			this._path = args[1];

			int i = 1;
			try
			{
				using (StreamWriter file = new StreamWriter(this._path))
				{
					foreach (var point in target)
					{
						file.WriteLine(point);
						i++;
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex + " file error");
			}
			undoStack.AddLast(this);
		}

		public void Undo()
		{
			try
			{
				File.Delete(this._path);
			}
			catch (DirectoryNotFoundException dnf)
			{
				throw new UndoException();
			}
		}

		public bool IsUndoible()
		{
			return true;
		}
	}
}
