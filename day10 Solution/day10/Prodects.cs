using System;
namespace day10
{
	public class Prodects
	{
		public static int cnt;
		public int ProdectId;
		public int id;
		public string Name;
		public string description;
		public double price;
		public int countInStock;
		public bool hasDiscount;


		public Prodects(int id, int ProdectId, string Name, string description, double price, int countInStock, bool hasDiscount)
		{
			id = id + 1;
			this.ProdectId = ProdectId;


		}
	}
}

