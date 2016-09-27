using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10_Collections;

namespace TestConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			Stock stockHP = new Stock("HPQ", 60.03, 120);
			Stock stockIBM = new Stock("IBM", 32.11, 50);
			Stock stockYHOO = new Stock("YHOO", 44.4, 180);
			Portfolio portfolio = new Portfolio();
			portfolio.AddAsset(stockIBM);
			portfolio.AddAsset(stockHP);
			portfolio.AddAsset(stockYHOO);

			IList<Asset> assets = portfolio.GetAssetsSortedByName();
		}
	}
}
