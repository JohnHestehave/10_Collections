using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Collections
{
	public class Portfolio
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
		public List<Asset> GetAssets()
		{
			return Stocks;
		}

		public Asset GetAssetByName(string name)
		{
			foreach (Asset item in Stocks)
			{
				if (item.GetName() == name)
				{
					return item;
				}
			}
			return null;
		}

		public IList<Asset> GetAssetsSortedByName()
		{ 
			Dictionary<string, Asset> assets = new Dictionary<string, Asset>();
			foreach (Asset a in Stocks)
			{
				assets.Add(a.GetName(), a);
			}
			List<string> sorter = new List<string>(assets.Keys);
			sorter.Sort();
			List<Asset> newList = new List<Asset>();
			foreach (var item in sorter)
			{
				newList.Add(assets[item]);
			}
			
			return newList;
		}
	}
}
