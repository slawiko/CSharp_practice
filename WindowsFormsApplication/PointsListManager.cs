using System;
using System.Collections.Generic;
using ListManager.Command.Utils;

namespace Command
{
	class PointsListManager
	{
		private PointsTarget target;
		private LinkedList<ICommand> undoStack;
		private Dictionary<string, Type> commandDictionary;

		public PointsListManager()
		{
			this.target = new PointsTarget(new List<Point>());
			this.undoStack = new LinkedList<ICommand>();
			this.commandDictionary = new Dictionary<string, Type>();
			this.Initialize();
		}

		private void Initialize()
		{
			this.commandDictionary.Add("add", Type.GetType("Command.AddCommand"));
			this.commandDictionary.Add("undo", Type.GetType("Command.UndoCommand"));
			this.commandDictionary.Add("format", Type.GetType("Command.FormatCommand"));
			this.commandDictionary.Add("list", Type.GetType("Command.ListCommand"));
			this.commandDictionary.Add("load", Type.GetType("Command.LoadCommand"));
			this.commandDictionary.Add("path", Type.GetType("Command.PathCommand"));
			this.commandDictionary.Add("remove", Type.GetType("Command.RemoveCommand"));
			this.commandDictionary.Add("save", Type.GetType("Command.SaveCommand"));
			this.commandDictionary.Add("sort", Type.GetType("Command.SortCommand"));
			this.commandDictionary.Add("exit", Type.GetType("Command.ExitCommand"));
			this.commandDictionary.Add("quit", Type.GetType("Command.QuitCommand"));
		}

		public void Execute(ICommand command, string[] args)
		{
			try
			{
				command.Execute(this.target, args, undoStack);
			}
			catch (NoSuchItemException nsi)
			{
				Console.WriteLine("No such item");
			}
			catch (InvalidArgumentsException ia)
			{
				Console.WriteLine("Invalid argument");
			}
			catch (UndoException u)
			{
				Console.WriteLine("Cannot undo");
			}
		}
	}	
}