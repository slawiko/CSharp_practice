using System;
using System.Collections.Generic;
using System.Reflection;
using System.Xml.Linq;

namespace Reflection
{
	class XMLTypeRepresenter
	{
		private Type _type;
		private XElement _xml;

		public XMLTypeRepresenter(Type type)
		{
			this._type = type;
		}

		private void MakeRepresentation()
		{
			List<XElement> methods = new List<XElement>();
			List<XElement> events = new List<XElement>();
			List<XElement> properties = new List<XElement>();
			List<XElement> attributes = new List<XElement>();
			List<XElement> fields = new List<XElement>();

			foreach (var m in this._type.GetMethods())
			{
				methods.Add(new XElement("Method", m));
			}
			foreach (var f in this._type.GetFields(BindingFlags.Public |
														BindingFlags.NonPublic |
														BindingFlags.DeclaredOnly |
														BindingFlags.Static |
														BindingFlags.Instance))
			{
				fields.Add(new XElement("Field", f));
			}
			foreach (var e in this._type.GetEvents())
			{
				events.Add(new XElement("Event", e));
			}
			foreach (var p in this._type.GetProperties())
			{
				properties.Add(new XElement("Property", p));
			}
			foreach (var a in this._type.GetCustomAttributes())
			{
				attributes.Add(new XElement("Attribute", a));
			}

			this._xml = 
				new XElement("Class",
					new XElement("Name", this._type.Name),
					new XElement("Methods", methods.ToArray()),
					new XElement("Properties", properties.ToArray()),
					new XElement("Attirbutes", attributes.ToArray()),
					new XElement("Fields", fields.ToArray()),
					new XElement("Events", events.ToArray())
				);
		}

		public XElement GetRepresentation()
		{
			MakeRepresentation();
			return this._xml;
		}
	}
}
