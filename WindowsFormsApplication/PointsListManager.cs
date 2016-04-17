using System;
using System.Collections.Generic;
using Command.Utils;

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
			this.commandDictionary.Add("add", Type.GetType("Command.Utils.AddCommand"));
			this.commandDictionary.Add("undo", Type.GetType("Command.Utils.UndoCommand"));
			this.commandDictionary.Add("format", Type.GetType("Command.Utils.FormatCommand"));
			this.commandDictionary.Add("list", Type.GetType("Command.Utils.ListCommand"));
			this.commandDictionary.Add("load", Type.GetType("Command.Utils.LoadCommand"));
			this.commandDictionary.Add("path", Type.GetType("Command.Utils.PathCommand"));
			this.commandDictionary.Add("remove", Type.GetType("Command.Utils.RemoveCommand"));
			this.commandDictionary.Add("save", Type.GetType("Command.Utils.SaveCommand"));
			this.commandDictionary.Add("sort", Type.GetType("Command.Utils.SortCommand"));
			this.commandDictionary.Add("exit", Type.GetType("Command.Utils.ExitCommand"));
			this.commandDictionary.Add("quit", Type.GetType("Command.Utils.QuitCommand"));
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
		//if (listManager.commandDictionary.TryGetValue(arguments[0], out type))
		//{
		//	listManager.Execute((ICommand)Activator.CreateInstance(type), arguments);
		//}	
	}	
}