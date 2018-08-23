using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCartStart.Models
{
	public static class ShoppingCart
	{
		public static List<Product> CreateEmptyShoppingCartList()
		{
			List<Product> products = new List<Product>();
			return products;
		}
		/// <summary>
		/// returns true if a list is empty and false if its not.
		/// </summary>
		/// <param name="products"></param>
		/// <returns></returns>
		public static bool IsCartEmpty(List<Product> products)
		{
			if (products == null)
				return true;
			return false;
		}

		
	}
}