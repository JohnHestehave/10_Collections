using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Collections
{
	class Portfolio
	{
		public List<Asset> Stocks = new List<Asset>();

		public Portfolio()
		{

		}
		public Portfolio(List<Asset> stocks)
		{
			Stocks = stocks;
		}
		public double GetTotalValue()
		{
			double total = 0;
			foreach(Asset stock in Stocks)
			{
				total += stock.GetValue();
			}
			return total;
		}

		public void AddAsset(Asset asset)
		{
			Stocks.Add(asset);
		}
	}
}
