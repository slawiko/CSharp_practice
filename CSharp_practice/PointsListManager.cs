using System;
using System.Collections.Generic;

namespace CSharp_practice
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
			this.commandDictionary.Add("add", Type.GetType("Sharp_dev_1.AddCommand"));
			this.commandDictionary.Add("undo", Type.GetType("Sharp_dev_1.UndoCommand"));
			this.commandDictionary.Add("format", Type.GetType("Sharp_dev_1.FormatCommand"));
			this.commandDictionary.Add("list", Type.GetType("Sharp_dev_1.ListCommand"));
			this.commandDictionary.Add("load", Type.GetType("Sharp_dev_1.LoadCommand"));
			this.commandDictionary.Add("path", Type.GetType("Sharp_dev_1.PathCommand"));
			this.commandDictionary.Add("remove", Type.GetType("Sharp_dev_1.RemoveCommand"));
			this.commandDictionary.Add("save", Type.GetType("Sharp_dev_1.SaveCommand"));
			this.commandDictionary.Add("sort", Type.GetType("Sharp_dev_1.SortCommand"));
			this.commandDictionary.Add("exit", Type.GetType("Sharp_dev_1.ExitCommand"));
			this.commandDictionary.Add("quit", Type.GetType("Sharp_dev_1.QuitCommand"));
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

		static void Main(string[] args)
		{
			PointsListManager listManager = new PointsListManager();
			Type type;

			while (true)
			{
				Console.Write("$ ");
				var arguments = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

				if (arguments.Length == 0) continue;

				if (listManager.commandDictionary.TryGetValue(arguments[0], out type))
				{
					listManager.Execute((ICommand)Activator.CreateInstance(type), arguments);
				}
				else
				{
					Console.WriteLine("Unsupported command!");
				}
			}
		}
	}
}