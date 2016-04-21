using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;

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
			if ((type.BaseType == null) || OBJECT_TYPE.Equals((type.BaseType.FullName)))
			{
				return;
			}
			else if (type.BaseType.BaseType.FullName.Equals(CONTROL_TYPE))
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

		private DialogResult ShowWarningBox(Exception e)
		{
			string message = e.Message;
			string caption = "Error";
			MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
			return MessageBox.Show(message, caption, buttons);
		}

		private void RefreshListBox()
		{
			BindingControlsHashSet.DataSource = null;
			FieldListBox.DataSource = null;
			MethodsListBox.DataSource = null;
			EventsListBox.DataSource = null;
			AttributesListBox.DataSource = null;
			PropertiesListBox.DataSource = null;
			ExampleGroupBox.Controls.Clear();
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
					this._controls.Clear();
					RefreshListBox();
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
			if (ControlsListBox.SelectedIndex >= 0 && ControlsListBox.SelectedIndex < this._controls.Count)
			{
				this._selectedType = this._controls.ElementAt(ControlsListBox.SelectedIndex);
				FieldListBox.DataSource = this._selectedType.GetFields(BindingFlags.Public |
																		BindingFlags.NonPublic |
																		BindingFlags.DeclaredOnly |
																		BindingFlags.Static |
																		BindingFlags.Instance);
				MethodsListBox.DataSource = this._selectedType.GetMethods();
				EventsListBox.DataSource = this._selectedType.GetEvents();
				AttributesListBox.DataSource = this._selectedType.GetCustomAttributes();
				PropertiesListBox.DataSource = this._selectedType.GetProperties();
				ExampleGroupBox.Controls.Clear();
				Control control = (Control) Activator.CreateInstance(this._selectedType);
				control.Text = this._selectedType.Name;
				control.Location = new Point(ExampleGroupBox.Size.Width/2 - control.Size.Width/2, 
											ExampleGroupBox.Size.Height/2 - control.Size.Height/2);
				ExampleGroupBox.Controls.Add(control);
			}
		}

		private void LoadBuildButton_Click(object sender, EventArgs e)
		{
			ShowLoadDialog();
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void SaveXMLButton_Click(object sender, EventArgs e)
		{
			DialogResult result = SaveXMLDialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				XMLTypeRepresenter.GetRepresentation(this._selectedType).Save(SaveXMLDialog.FileName);
			}
		}

		private void LoadXMLButton_Click(object sender, EventArgs e)
		{
			OpenBuildDialog.Filter = "XML files (.xml)|*.xml";
			DialogResult result = LoadXMLDialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				RefreshListBox();
				this._controls.Clear();
				this._controls.Add(XMLTypeRepresenter.GetType(XElement.Load(LoadXMLDialog.FileName)));
			}
		}
	}
}
