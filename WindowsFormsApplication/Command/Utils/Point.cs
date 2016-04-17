using System;

namespace ListManager.Command.Utils
{
	class Point : IComparable<Point>
	{
		public double x;
		public double y;
		private Format _format;

		public Point()
		{
			this.x = 0;
			this.y = 0;
			this._format = new Format();
		}

		public Point(double x, double y)
		{
			this.x = x;
			this.y = y;
			this._format = new Format();
		}

		public void SetFormat(Format format)
		{
			this._format = format;
		}

		public Format GetFormat()
		{
			return this._format;
		}

		public double CountPath(Point p)
		{
			return Math.Sqrt((this.x - p.x)*(this.x - p.x)
			                 + (this.y - p.y)*(this.y - p.y)
				);
		}

		public double CountPhi()
		{
			double phi;
			if (this.x > 0)
			{
				if (this.y >= 0)
					phi = Math.Atan(this.y/this.x);
				else
					phi = Math.Atan(this.y/this.x) + (2*Math.PI);
			}
			else if (this.x < 0)
			{
				phi = Math.Atan(this.y/this.x) + Math.PI;
			}
			else if (this.y > 0)
				phi = Math.PI/2;
			else if (this.y < 0)
				phi = 3*Math.PI/2;
			else
				phi = 0;
			return phi;
		}

		public int CompareTo(Point other)
		{
			var diff = this.CountPhi() - other.CountPhi();
			if (diff != 0)
				return diff > 0 ? 1 : -1;
			else
			{
				Point zero = new Point();
				diff = this.CountPath(zero) - other.CountPath(zero);
				return diff > 0 ? 1 : -1;
			}
		}

		public override string ToString()
		{
			if (_format.IsLong())
			{
				return LongFormat();
			}
			else if (_format.IsShort())
			{
				return ShortFormat();
			}
			else if (_format.IsTag())
			{
				return TagFormat();
			}
			else if (_format.IsJSON())
			{
				return JSONFormat();
			}
			else
			{
				throw new UnsupportedFormatException();
			}
		}

		private string ShortFormat()
		{
			return this.x + "; " + this.y;
		}

		private string LongFormat()
		{
			return "x = " + this.x + "; y = " + this.y;
		}

		private string TagFormat()
		{
			return "<x>" + this.x + "</x>" + "<y>" + this.y + "</y>";
		}

		private string JSONFormat()
		{
			return "{" + Environment.NewLine + 
				"  \"x\": \"" + this.x + "\"," + Environment.NewLine + 
				"  \"y\": \"" + this.y + "\"" + Environment.NewLine +
				"}";
		}
	}
}
