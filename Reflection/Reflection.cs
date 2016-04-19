using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reflection
{
	public partial class Reflection : Form
	{
		private HashSet<Type> _controls;
		private Type _selectedType;
		private readonly string CONTROL_TYPE = "System.Windows.Forms.Control";
		private readonly string OBJECT_TYPE = "System.Object";

		public Reflection()
		{
			this._controls = new HashSet<Type>();
			InitializeComponent();
		}

		private void SearchBaseType(Type type)
		{
			if (type.BaseType == null)
			{
				return;
			}
			else if (type.BaseType.FullName.Equals(CONTROL_TYPE))
			{
				this._controls.Add(type);
			}
			else
			{
				SearchBaseType(type.BaseType);
			}
		}

		private void SearchControls(Assembly assembly)
		{
			foreach (var type in assembly.GetTypes())
			{
				foreach (var field in type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
				{
					SearchBaseType(field.FieldType);
				}
			}
		}

		private void Reflection_Load(object sender, EventArgs e)
		{
			ShowLoadDialog();
		}

		private DialogResult ShowWarningBox(Exception e)
		{
			string message = e.Message;
			string caption = "Error";
			MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
			return MessageBox.Show(message, caption, buttons);
		}

		private void ShowLoadDialog()
		{
			OpenBuildDialog.Filter = "Executable files (.exe)|*.exe| Dynamic Libraries files (.dll)|*.dll";
			DialogResult result = OpenBuildDialog.ShowDialog();
			if (DialogResult.OK.Equals(result))
			{
				try
				{
					Assembly assembly = Assembly.LoadFrom(OpenBuildDialog.FileName);
					SearchControls(assembly);
				}
				catch (BadImageFormatException bif)
				{
					if (ShowWarningBox(bif) == DialogResult.OK)
					{
						ShowLoadDialog();
					}
					else
					{
						return;
					}
				}

				BindingControlsHashSet.DataSource = this._controls;
				ControlsListBox.DataSource = BindingControlsHashSet;
			}
			else
			{
				return;
			}
		}

		private void ControlsListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			this._selectedType = this._controls.ElementAt(ControlsListBox.SelectedIndex);
		}

		private void LoadButton_Click(object sender, EventArgs e)
		{
			ShowLoadDialog();
		}
	}
}
