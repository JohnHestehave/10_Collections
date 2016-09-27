using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Collections
{
	class StockValueComparator
	{
		public double Compare(Asset a, Asset b)
		{
			return b.GetValue().CompareTo(a.GetValue());
		}
	}
}
