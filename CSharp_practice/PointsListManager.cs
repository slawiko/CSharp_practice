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
			this.commandDictionary.Add("add", Type.GetType("CSharp_practice.AddCommand"));
			this.commandDictionary.Add("undo", Type.GetType("CSharp_practice.UndoCommand"));
			this.commandDictionary.Add("format", Type.GetType("CSharp_practice.FormatCommand"));
			this.commandDictionary.Add("list", Type.GetType("CSharp_practice.ListCommand"));
			this.commandDictionary.Add("load", Type.GetType("CSharp_practice.LoadCommand"));
			this.commandDictionary.Add("path", Type.GetType("CSharp_practice.PathCommand"));
			this.commandDictionary.Add("remove", Type.GetType("CSharp_practice.RemoveCommand"));
			this.commandDictionary.Add("save", Type.GetType("CSharp_practice.SaveCommand"));
			this.commandDictionary.Add("sort", Type.GetType("CSharp_practice.SortCommand"));
			this.commandDictionary.Add("exit", Type.GetType("CSharp_practice.ExitCommand"));
			this.commandDictionary.Add("quit", Type.GetType("CSharp_practice.QuitCommand"));
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