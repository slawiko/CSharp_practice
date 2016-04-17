using System;
using System.Collections;
using System.Collections.Generic;

namespace Command.Utils
{
	class PointsTarget : ITarget
	{
		private List<Point> list;
		private Format _format;
		public int Count;

		public PointsTarget(PointsTarget target)
		{
			this.list = new List<Point>(target.list);
			this._format = new Format(target._format);
			this.Count = target.Count;
		}

		public PointsTarget(List<Point> list)
		{
			this.list = list;
			this._format = new Format();
			this.Count = list.Count;
		}

		public void SetFormat(Format format)
		{
			this._format = format;
			foreach (var item in this.list)
			{
				item.SetFormat(this._format);
			}
		}

		public Format GetFormat()
		{
			return this._format;
		}

		public void Add(Point item)
		{
			this.list.Add(item);
			this.Count++;
		}

		public bool Contains(Point item)
		{
			return this.list.Contains(item);
		}

		public int IndexOf(Point item)
		{
			return this.list.IndexOf(item);
		}

		public void RemoveAt(int index)
		{
			this.list.RemoveAt(index);
			this.Count--;
		}

		public bool Remove(Point item)
		{
			bool result = false;
			if (this.list.Remove(item))
			{
				this.Count--;
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		public void Clear()
		{
			this.list.Clear();
			this.Count = 0;
		}

		public Point this[int index]
		{
			get { return this.list[index]; }
			set { this.list[index] = value; }
		}

		public Point ElementAt(int index)
		{
			try
			{
				return this.list[index];
			}
			catch (IndexOutOfRangeException ioor)
			{
				throw new NoSuchItemException();
			}
		}

		public IEnumerator<Point> GetEnumerator()
		{
			return this.list.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		int ITarget.Count()
		{
			return this.Count;
		}

		public void Sort()
		{
			this.list.Sort();
		}

		public double CountPath(int startIndex, int finishIndex)
		{
			double path = 0;
			for (var i = startIndex; i < finishIndex; i++)
			{
				path += this.list[i].CountPath(this.list[i + 1]);
			}
			return path;
		}

		public ITarget Clone()
		{
			return new PointsTarget(this);
		}

		public void ReplaceAll(ITarget target)
		{
			var tmp = (PointsTarget)target;
			this.list = tmp.list;
			this.Count = tmp.Count;
			this._format = tmp._format;
		}

		public IEnumerable<Point> GetCollection()
		{
			return this.list;
		}
	}
}
