using BusinessLayer.Abstarct;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repostories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDL _categorydl;

        public CategoryManager(ICategoryDL categorydl)
        {
            _categorydl = categorydl;
        }

        public void CategoryAdd(Category category)
        {
            _categorydl.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _categorydl.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categorydl.Update(category);
        }

        public Category GetById(int id)
        {
            return _categorydl.Get(x=>x.CategoryId == id);
        }

        public List<Category> GetList()
        {
            return _categorydl.List();
        }
    }
}
