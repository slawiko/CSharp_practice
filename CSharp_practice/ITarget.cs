using System.Collections.Generic;

namespace CSharp_practice
{
	interface ITarget : IEnumerable<Point>
	{
		void Add(Point item);
		bool Contains(Point item);
		int IndexOf(Point item);
		void RemoveAt(int index);
		bool Remove(Point item);
		void Clear();
		int Count();
		void Sort();
		Point ElementAt(int index);
		double CountPath(int startIndex, int finishIndex);
		void SetFormat(Format format);
		Format GetFormat();
		ITarget Clone();
		void ReplaceAll(ITarget target);
	}
}
