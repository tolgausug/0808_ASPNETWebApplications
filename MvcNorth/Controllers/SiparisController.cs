using MvcNorth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcNorth.Controllers
{
    public class SiparisController : Controller
    {
        // GET: Siparis
        public ActionResult Siparisler(int id)
        {
            var sorgu = new NorthwindEntities().Products.Find(id);
            return View(sorgu);
            
        }
    }
}