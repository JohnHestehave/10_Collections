using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Collections
{
	interface IStockRepository
	{
		long NextId();
		void SaveStock(Asset a);
		Stock LoadStock(long id);
		List<Asset> FindAllStocks();
		void Clear();
	}
}
