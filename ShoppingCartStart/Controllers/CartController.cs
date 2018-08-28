using ShoppingCartStart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCartStart.Controllers
{
    public class CartController : Controller
    {
        public ActionResult Add() 
        {
            //retrieve productID and qty
            int prodID = Convert.ToInt32(Request.Form["product_id"]);

            //get rest of product info
            CartContext db = new CartContext();
            Product p = db.Products.Find(prodID);

            //qty of product to add to cart
            short qty = Convert.ToInt16(Request.Form["qty"]);
            p.Quantity = qty;

			List<Product> products = cookieHelper.GetProducts();
			//TODO: Add product to cart, if product exists, add to qty
			cookieHelper.AddProduct(p, products, qty);

            return RedirectToAction("Index", "Home");
        }
		public ActionResult ViewCart()
		{
			List<Product> cartProducts = ShoppingCart.GetProducts();
			return View(cartProducts);
		}
    }
}