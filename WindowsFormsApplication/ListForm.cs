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

		private void BindData()
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
			BindData();
		}

		private void RemoveButton_Click(object sender, EventArgs e)
		{
			//if (PointsList.SelectedIndices != null)
			//{
			//}
		}

		private void ListForm_Load(object sender, EventArgs e)
		{
			PointsList.DataSource = (List<Point>)this.target.GetCollection();
		}

		private void UndoButton_Click(object sender, EventArgs e)
		{
			ProduceCommand("undo", new string[] { });
			BindData();
		}
	}
}
