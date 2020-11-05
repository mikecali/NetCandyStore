﻿using NetCandyStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetCandyStore.Controllers
{
    public class CartController : Controller
    {
        private CandiesDBEntities db = new CandiesDBEntities();
        // GET: Cart
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddToCart(int? Id = 1)
        {
            // Get or Create Cart GUID
            string cartGUID;
            HttpCookie cartCookie = Request.Cookies["netcandystoreCartGUID"];
            if (cartCookie != null)
            {
                cartGUID = cartCookie.Value;
            }
            else
            {
                //Cookie not set.
                cartGUID = System.Guid.NewGuid().ToString();
                //create cookie with some ID as i have given CookName
                cartCookie = new HttpCookie("netcandystoreCartGUID");
                cartCookie.Value = cartGUID;
                cartCookie.Expires = DateTime.Now.Add(TimeSpan.FromHours(200));
                Response.Cookies.Add(cartCookie);
            }


            // Get item
            Product thisProduct = db.Products.FirstOrDefault(p => p.Id == Id);
            // Get item so we have a price at the time of being added to cart
            decimal itemPrice = (decimal)thisProduct.itemPrice;

            // Set quantity
            int quantity = 1;

            // Set status to Active
            byte status = 1;

            // Add to cart
            db.AddToCart(cartGUID, Id, itemPrice, quantity, status);
            //            List<GetProductsByCategoryId_Result> r = db.GetProductsByCategoryId(categoryId).ToList();

            // Get Shopping Cart items

            // Return cart contents to View
            return View("Index", db.GetShoppingCartItems(cartGUID).ToList());
        }
    }
}