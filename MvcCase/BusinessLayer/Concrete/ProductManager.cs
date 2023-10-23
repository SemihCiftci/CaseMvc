using BusinessLayer.Abstarct;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDL _productDL;

        public ProductManager(IProductDL productDL)
        {
            _productDL = productDL;
        }

        public Product GetById(int id)
        {
            return _productDL.Get(x=>x.ProductId == id);
        }

        public List<Product> GetList()
        {
            return _productDL.List();
        }

        public void ProductAdd(Product product)
        {
            _productDL.Insert(product);
        }

        public void ProductDelete(Product product)
        {
            _productDL.Delete(product);
        }

        public void ProductUpdate(Product product)
        {
            _productDL.Update(product);
        }
    }
}
