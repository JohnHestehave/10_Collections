using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Collections
{
	class MemoryStockRepository : IStockRepository
	{
		private long id;
		private List<Asset> Assets = new List<Asset>();
		public long NextId()
		{
			id++;
			return id;
		}
		public void SaveStock(Asset a)
		{
			Assets.Add(a);
		}
		public Stock LoadStock(long ID)
		{
			foreach(Stock a in Assets)
			{
				if(a.Id == ID)
				{
					return a;
				}
			}
			return null;
		}

		public List<Asset> FindAllStocks()
		{
			return Assets;
		}

		public void Clear()
		{
			Assets.Clear();
		}
	}
}
