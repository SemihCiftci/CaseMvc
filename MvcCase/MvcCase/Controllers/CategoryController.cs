using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System.Web.Mvc;

namespace MvcCase.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager cm = new CategoryManager(new ECategoryDL());


        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCategoryList()
        {
            var categoryVal = cm.GetList();
            return View(categoryVal);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            //cm.CategoryAddBL(P);
            CategoryValidatior categoryvalid = new CategoryValidatior();
            ValidationResult result = categoryvalid.Validate(p);
            if (result.IsValid)
            {
                cm.CategoryAdd(p);
                return RedirectToAction("GetCategoryList");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public ActionResult DeleteCategory(int id)
        {
            var categoryVal = cm.GetById(id);
            cm.CategoryDelete(categoryVal);

            return RedirectToAction("GetCategoryList");
        }
        [HttpGet]
        public ActionResult EditCategory(int id)
        {
            var categoryVal = cm.GetById(id);

            return View(categoryVal);
        }

        [HttpPost]
        public ActionResult EditCategory(Category p)
        {
            cm.CategoryUpdate(p);

            return RedirectToAction("GetCategoryList");
        }
    }
}