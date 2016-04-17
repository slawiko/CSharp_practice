using System.Collections.Generic;
using ListManager.Command.Utils;

namespace ListManager.Command
{
	class FormatCommand : ICommand
	{
		private ITarget _target;
		private Format _backup;
		private Format _format;

		public FormatCommand()
		{
		}

		public void Execute(ITarget target, string[] args, LinkedList<ICommand> undoStack)
		{
			if (string.IsNullOrEmpty(args[1]))
			{
				throw new InvalidArgumentsException();
			}
			if (args[1].Equals("?"))
			{
				System.Console.WriteLine(Format.SupportedFormats());
				return;
			}
			if (!args[1].Equals("short") && 
				!args[1].Equals("long") &&
				!args[1].Equals("json") &&
				!args[1].Equals("tag"))
			{
				throw new InvalidArgumentsException();
			}
			this._format = new Format(args[1]);
			this._target = target;
			this._backup = this._target.GetFormat();
			this._target.SetFormat(this._format);
			undoStack.AddLast(this);
		}

		public void Undo()
		{
			this._format = this._backup;
			this._target.SetFormat(this._format);
		}

		public bool IsUndoible()
		{
			return true;
		}
	}
}
