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
		private Assembly _assembly;
		private HashSet<Type> _controls;
		private readonly string CONTROL_TYPE = "System.Windows.Forms.Control";
		private readonly string OBJECT_TYPE = "System.Object";

		public Reflection()
		{
			this._controls = new HashSet<Type>();
			InitializeComponent();
		}

		private void SearchBaseType(Type type)
		{
			if ((type.BaseType == null) || (type.BaseType.FullName.Equals(OBJECT_TYPE)))
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

		private void Reflection_Load(object sender, EventArgs e)
		{
			OpenBuildDialog.Filter = "Executable files (.exe)|*.exe| Dynamic Libraries files (.dll)|*.dll";
			DialogResult result = OpenBuildDialog.ShowDialog();
			if (DialogResult.OK.Equals(result))
			{
				this._assembly = Assembly.LoadFrom(OpenBuildDialog.FileName);
				foreach (var type in this._assembly.GetTypes())
				{
					foreach (var field in type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
					{
						SearchBaseType(field.FieldType);
					}
				}
			}
		}
	}
}
