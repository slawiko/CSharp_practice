using System;
using System.Collections.Generic;
using ListManager.Command.Utils;
using System.Windows.Forms;

namespace ListManager
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
			this.commandDictionary.Add("add", Type.GetType("ListManager.Command.AddCommand", true));
			this.commandDictionary.Add("undo", Type.GetType("ListManager.Command.UndoCommand", true));
			this.commandDictionary.Add("format", Type.GetType("ListManager.Command.FormatCommand", true));
			this.commandDictionary.Add("list", Type.GetType("ListManager.Command.ListCommand", true));
			this.commandDictionary.Add("load", Type.GetType("ListManager.Command.LoadCommand", true));
			this.commandDictionary.Add("path", Type.GetType("ListManager.Command.PathCommand", true));
			this.commandDictionary.Add("remove", Type.GetType("ListManager.Command.RemoveCommand", true));
			this.commandDictionary.Add("save", Type.GetType("ListManager.Command.SaveCommand", true));
			this.commandDictionary.Add("sort", Type.GetType("ListManager.Command.SortCommand", true));
			this.commandDictionary.Add("exit", Type.GetType("ListManager.Command.ExitCommand", true));
			this.commandDictionary.Add("quit", Type.GetType("ListManager.Command.QuitCommand", true));
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
			string caption = "Error";
			MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
			MessageBox.Show(message, caption, buttons);
		}

		private void ProduceCommand(string name, string[] args)
		{
			Execute((ICommand)Activator.CreateInstance(Instance(name)), args);
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(AddXTextBox.Text) || String.IsNullOrEmpty(AddYTextBox.Text))
			{
				return;
			}
			string x = AddXTextBox.Text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)[0];
			string y = AddYTextBox.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[0];
			string[] arguments = new string[] { x, y };

			AddXTextBox.Text = "";
			AddYTextBox.Text = "";
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

		private void LoadButton_Click(object sender, EventArgs e)
		{
			DialogResult result = LoadCommandDialog.ShowDialog();
			if (DialogResult.OK.Equals(result))
			{
				ProduceCommand("load", new string[] { LoadCommandDialog.FileName });
				RefreshListBox();
			}
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			DialogResult result = SaveCommandDialog.ShowDialog();
			if (DialogResult.OK.Equals(result))
			{
				ProduceCommand("save", new string[] { SaveCommandDialog.FileName });
			}
		}
	}
}
