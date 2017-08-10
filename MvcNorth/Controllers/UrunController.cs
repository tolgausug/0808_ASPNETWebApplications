using MvcNorth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcNorth.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        public ActionResult Duzenle(int? id)
        {
            if (id == null)
                return RedirectToAction("Index", "Home");
            var db = new NorthwindEntities();
            var urun = db.Products.Find(id.Value);
            if (urun == null)
                return RedirectToAction("Index", "Home");
            ViewBag.Title = $"{urun.ProductName} - Ürün Düzenleme";
            var kategoriler = db.Categories.ToList();
            return View();
        }
        
        public ActionResult Yeni(Product model)
        {
            var urun = new Product()
            {
                ProductName = model.ProductName,
                UnitPrice = model.UnitPrice,
                Discontinued = model.Discontinued,
                CategoryID = model.CategoryID,
                UnitsInStock = model.UnitsInStock
            };
            try
            {
                var db = new NorthwindEntities();
                db.Products.Add(urun);
                db.SaveChanges();
            }
            catch (Exception e)
            {

                throw;
            }
            return RedirectToAction("Duzenle", new { id = urun.ProductID });
        }
        public ActionResult Ara()
        {
            return View();
        }
        public JsonResult Bul(string key)
        {
            var db = new NorthwindEntities();
            var sonuc=db.Products.Where(x=>x.ProductName.ToLower().Contains(key.ToLower()))||
        }
    }
}