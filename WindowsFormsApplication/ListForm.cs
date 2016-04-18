using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using ListManager.Command.Utils;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListManagerApp
{
	public partial class ListForm : Form
	{
		private PointsTarget target;
		private LinkedList<ICommand> undoStack;
		private Dictionary<string, Type> commandDictionary;
		private Format checkedFormat;

		public ListForm()
		{
			InitializeComponent();
			InitializeListManager();
		}

		private void InitializeListManager()
		{
			this.target = new PointsTarget(new List<Point>());
			this.undoStack = new LinkedList<ICommand>();
			this.commandDictionary = new Dictionary<string, Type>();
			this.checkedFormat = new Format();
			this.InitializeCommands();
		}

		private void InitializeCommands()
		{
			this.commandDictionary.Add("add", Type.GetType("ListManager.Command.AddCommand"));
			this.commandDictionary.Add("undo", Type.GetType("ListManager.Command.UndoCommand"));
			this.commandDictionary.Add("format", Type.GetType("ListManager.Command.FormatCommand"));
			this.commandDictionary.Add("list", Type.GetType("ListManager.Command.ListCommand"));
			this.commandDictionary.Add("load", Type.GetType("ListManager.Command.LoadCommand"));
			this.commandDictionary.Add("path", Type.GetType("ListManager.Command.PathCommand"));
			this.commandDictionary.Add("remove", Type.GetType("ListManager.Command.RemoveCommand"));
			this.commandDictionary.Add("save", Type.GetType("ListManager.Command.SaveCommand"));
			this.commandDictionary.Add("sort", Type.GetType("ListManager.Command.SortCommand"));
			this.commandDictionary.Add("exit", Type.GetType("ListManager.Command.ExitCommand"));
			this.commandDictionary.Add("quit", Type.GetType("ListManager.Command.QuitCommand"));
		}

		private void Execute(ICommand command, string[] args)
		{
			try
			{
				command.Execute(this.target, args, undoStack);
			}
			catch (NoSuchItemException nsi)
			{
				ShowWarningBox(nsi);
			}
			catch (InvalidArgumentsException ia)
			{
				ShowWarningBox(ia);
			}
			catch (UndoException u)
			{
				ShowWarningBox(u);
			}
		}

		private Type Instance(string type)
		{
			Type instance;
			if (this.commandDictionary.TryGetValue(type, out instance))
			{
				return instance;
			}
			else
			{
				throw new UnsupportedCommandException();
			}
		}

		private void RefreshListBox()
		{
			PointsList.DataSource = null;
			PointsList.DataSource = this.target.GetCollection();
		}

		private void ShowWarningBox(Exception e)
		{
			string message = e.Message;
			string caption = e.Message;
			MessageBoxButtons buttons = MessageBoxButtons.OK;
			MessageBox.Show(message, caption, buttons);
		}

		private void ProduceCommand(string name, string[] args)
		{
			Execute((ICommand)Activator.CreateInstance(Instance(name)), args);
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			var arguments = AddTextBox.Text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
			AddTextBox.Text = "";
			ProduceCommand("add", arguments);
			RefreshListBox();
		}

		private void RemoveButton_Click(object sender, EventArgs e)
		{
			if (PointsList.SelectedIndices != null)
			{
				for(var index = PointsList.SelectedIndices.Count - 1; index >= 0; --index)
				{
					ProduceCommand("remove", new string[] { PointsList.SelectedIndices[index].ToString() });
				}
				RefreshListBox();
			}
		}

		private void ListForm_Load(object sender, EventArgs e)
		{
			PointsList.DataSource = (List<Point>)this.target.GetCollection();
		}

		private void UndoButton_Click(object sender, EventArgs e)
		{
			ProduceCommand("undo", new string[] { });
			RefreshListBox();
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			ProduceCommand("exit", new string[] { });
		}

		private void SortButton_Click(object sender, EventArgs e)
		{
			ProduceCommand("sort", new string[] { });
			RefreshListBox();
		}

		private void LongRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			this.checkedFormat = new Format(Format.FORMAT_LONG);
		}

		private void ShortRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			this.checkedFormat = new Format(Format.FORMAT_SHORT);
		}

		private void TagRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			this.checkedFormat = new Format(Format.FORMAT_TAG);
		}

		private void JSONRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			this.checkedFormat = new Format(Format.FORMAT_JSON);
		}

		private void FormatButton_Click(object sender, EventArgs e)
		{
			this.target.SetFormat(this.checkedFormat);
			RefreshListBox();
		}
	}
}
