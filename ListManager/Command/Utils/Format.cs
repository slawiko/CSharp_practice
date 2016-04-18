namespace ListManager.Command.Utils
{
	class Format
	{
		public static readonly string FORMAT_LONG = "LONG";
		public static readonly string FORMAT_SHORT = "SHORT";
		public static readonly string FORMAT_TAG = "TAG";
		public static readonly string FORMAT_JSON = "JSON";

		private string _format;

		public Format()
		{
			this._format = FORMAT_LONG;
		}

		public Format(Format format)
		{
			this._format = format._format;
		}

		public Format(string format)
		{
			this._format = format.ToUpper();
		}

		public bool IsLong()
		{
			return this._format.Equals(FORMAT_LONG);
		}

		public bool IsShort()
		{
			return this._format.Equals(FORMAT_SHORT);
		}

		public bool IsTag()
		{
			return this._format.Equals(FORMAT_TAG);
		}

		public bool IsJSON()
		{
			return this._format.Equals(FORMAT_JSON);
		}

		public static string SupportedFormats()
		{
			return FORMAT_LONG + ", " + FORMAT_SHORT + ", " + FORMAT_TAG + ", " + FORMAT_JSON;
		}

		public override string ToString()
		{
			return this._format;
		}
	}
}
