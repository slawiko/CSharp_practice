﻿using System;
using System.Collections.Generic;
using System.IO;

namespace CSharp_practice
{
	class LoadCommand : ICommand
	{
		private ITarget _target;
		private ITarget _backup;
		private string _path;

		public void Execute(ITarget target, string[] args, LinkedList<ICommand> undoStack)
		{
			if (String.IsNullOrEmpty(args[1]))
			{
				throw new InvalidArgumentsException();
			}
			this._path = args[1];
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
			bool y = false;

			foreach (var word in words)
			{
				if (!x && double.TryParse(word, out p.x))
				{
					x = true;
					continue;
				}
				if (double.TryParse(word, out p.y))
				{
					y = true;
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
