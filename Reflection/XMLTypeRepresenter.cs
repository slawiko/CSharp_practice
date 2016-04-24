using System;
using System.Collections.Generic;
using System.Linq;
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
					new XElement("Attributes", attributes.ToArray()),
					new XElement("Fields", fields.ToArray()),
					new XElement("Events", events.ToArray())
				);

			return xml;
		}

		public static XElement GetRepresentation(Type type)
		{
			return MakeRepresentation(type);
		}

		private static List<string> GetFields(List<XElement> list, string nodeName)
		{
			List<string> fields = new List<string>();
			foreach (var node in list)
			{
				fields.Add(node.Value);
			}

			return fields;
		}

		public static CustomType GetType(XElement xml)
		{
			CustomType type = new CustomType(xml.Element("Name").Value);
			type.SetMethods(GetFields(xml.Element("Methods").Elements().ToList(), "Method"));
			type.SetFields(GetFields(xml.Element("Fields").Elements().ToList(), "Field"));
			type.SetProperties(GetFields(xml.Element("Properties").Elements().ToList(), "Property"));
			type.SetAttributes(GetFields(xml.Element("Attributes").Elements().ToList(), "Attribute"));
			type.SetEvents(GetFields(xml.Element("Events").Elements().ToList(), "Event"));

			return type;
		}
	}
}
