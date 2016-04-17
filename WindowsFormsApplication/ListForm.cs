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

		private void button1_Click(object sender, EventArgs e)
		{
			var arguments = AddTextBox.Text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
			Execute((ICommand)Activator.CreateInstance(Instance("add")), arguments);
			BindData();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			PointsList.DataSource = this.target.GetCollection();
		}
	}
}
