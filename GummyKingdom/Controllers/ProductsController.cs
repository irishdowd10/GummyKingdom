using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GummyKingdom.Models;


namespace GummyKingdom.Controllers
{
    public class ProductsController : Controller
    {
		private GummyKingdomDbContext db = new GummyKingdomDbContext();
		public IActionResult Index()
        {
            return View(db.Products.ToList());
        }
    }
}
