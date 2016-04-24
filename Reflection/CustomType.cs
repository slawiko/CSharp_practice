using System.Collections.Generic;

namespace Reflection
{
	class CustomType
	{
		public string FullName;
		private List<string> _methods;
		private List<string> _fields;
		private List<string> _properties;
		private List<string> _attributes;
		private List<string> _events;

		public CustomType(string fullName)
		{
			this.FullName = fullName;
		}

		public List<string> GetMethods()
		{
			return this._methods;
		}

		public List<string> GetFields()
		{
			return this._fields;
		}

		public List<string> GetEvents()
		{
			return this._events;
		}

		public List<string> GetProperties()
		{
			return this._properties;
		}

		public List<string> GetAttributes()
		{
			return this._attributes;
		}

		public void SetMethods(List<string> methods)
		{
			this._methods = methods;
		}

		public void SetFields(List<string> fields)
		{
			this._fields = fields;
		}

		public void SetAttributes(List<string> attributes)
		{
			this._attributes = attributes;
		}

		public void SetProperties(List<string> properties)
		{
			this._properties = properties;
		}

		public void SetEvents(List<string> events)
		{
			this._events = events;
		}
	}
}
