using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Context.Repositories;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Context.EntityFramework
{
    public class EFProductDal : GenericRepository<Product>, IProductDal
    {
        public List<Object> GetProductsWithCategory()
        {
            var context = new CampContext();
            var vaules = context.Products
                .Select(p => new
                {
                    ProductID = p.ProductID,
                    ProductName = p.ProductName,
                    ProductStock = p.ProductStock,
                    ProductPrice = p.ProductPrice,
                    ProductDescription = p.ProductDescription,
                    CategoryName = p.Category.CategoryName,
                }).ToList();
            return vaules.Cast<object>().ToList();

        }
    }
}
