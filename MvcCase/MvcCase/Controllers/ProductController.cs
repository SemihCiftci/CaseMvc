using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCase.Controllers
{
    public class ProductController : Controller
    {
        ProductManager productmana = new ProductManager(new EProductDL());

        public ActionResult Index()
        {
            var ProductVal = productmana.GetList();
            return View(ProductVal);
        }
        public ActionResult ProductList()
        {
            var ProductVal = productmana.GetList();
            return View(ProductVal);
        }
    }
}