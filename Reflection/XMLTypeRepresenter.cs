using System;
using System.Collections.Generic;
using System.Reflection;
using System.Xml.Linq;

namespace Reflection
{
	class XMLTypeRepresenter
	{
		public XMLTypeRepresenter()
		{
		}

		private static XElement MakeRepresentation(Type type)
		{
			List<XElement> methods = new List<XElement>();
			List<XElement> events = new List<XElement>();
			List<XElement> properties = new List<XElement>();
			List<XElement> attributes = new List<XElement>();
			List<XElement> fields = new List<XElement>();

			foreach (var m in type.GetMethods())
			{
				methods.Add(new XElement("Method", m));
			}
			foreach (var f in type.GetFields(BindingFlags.Public |
														BindingFlags.NonPublic |
														BindingFlags.DeclaredOnly |
														BindingFlags.Static |
														BindingFlags.Instance))
			{
				fields.Add(new XElement("Field", f));
			}
			foreach (var e in type.GetEvents())
			{
				events.Add(new XElement("Event", e));
			}
			foreach (var p in type.GetProperties())
			{
				properties.Add(new XElement("Property", p));
			}
			foreach (var a in type.GetCustomAttributes())
			{
				attributes.Add(new XElement("Attribute", a));
			}

			XElement xml = 
				new XElement("Class",
					new XElement("Name", type.FullName),
					new XElement("Methods", methods.ToArray()),
					new XElement("Properties", properties.ToArray()),
					new XElement("Attirbutes", attributes.ToArray()),
					new XElement("Fields", fields.ToArray()),
					new XElement("Events", events.ToArray())
				);

			return xml;
		}

		public static XElement GetRepresentation(Type type)
		{
			return MakeRepresentation(type);
		}

		public static Type GetType(XElement xml)
		{
			return Type.GetType(xml.Element("Name").Value);
		}
	}
}
