using System;
using System.Collections.Generic;
using System.IO;
using ListManager.Command.Utils;

namespace ListManager.Command
{
	class LoadCommand : ICommand
	{
		private ITarget _target;
		private ITarget _backup;
		private string _path;

		public void Execute(ITarget target, string[] args, LinkedList<ICommand> undoStack)
		{
			if (String.IsNullOrEmpty(args[0]))
			{
				throw new InvalidArgumentsException();
			}
			this._path = args[0];
			this._target = target;
			this._backup = target.Clone();
			try
			{
				using (StreamReader file = new StreamReader(this._path))
				{
					string line;
					while ((line = file.ReadLine()) != null)
					{
						this._target.Add(this.ParseLine(line));
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
			this._target.ReplaceAll(this._backup);
		}

		private Point ParseLine(string line)
		{
			Point p = new Point();
			char[] delims = {' ', ',', ';', '<', '>', '\"'};
			string[] words = line.Split(delims);
			bool x = false;

			foreach (var word in words)
			{
				if (!x && double.TryParse(word, out p.x))
				{
					x = true;
					continue;
				}
				if (double.TryParse(word, out p.y))
				{
					break;
				}
			}

			return p;
		}

		public bool IsUndoible()
		{
			return true;
		}
	}
}
