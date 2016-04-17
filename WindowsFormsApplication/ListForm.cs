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
		public ListForm()
		{
			InitializeComponent();
			InitializeListManager();
		}

		private void RefreshListBox()
		{
			PointsList.DataSource = null;
			PointsList.DataSource = this.target.GetCollection();
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
	}
}
