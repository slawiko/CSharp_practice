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
			if (string.IsNullOrEmpty(args[0]))
			{
				throw new InvalidArgumentsException();
			}
			if (args[0].Equals("?"))
			{
				System.Console.WriteLine(Format.SupportedFormats());
				return;
			}
			if (!args[0].Equals("short") && 
				!args[0].Equals("long") &&
				!args[0].Equals("json") &&
				!args[0].Equals("tag"))
			{
				throw new InvalidArgumentsException();
			}
			this._format = new Format(args[0]);
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
