using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCL
{
    public class Repository
    {
       
        public Product GetProductByID(int ID)
        {
            var Context = new NorthwindEntities();
            //return Products.FirstOrDefault(p => p.ProductID == ID);
            return Context.Products.FirstOrDefault(p => p.ProductID == ID);
        }

        public List<Product> GetProducts()
        {
            List<Product> result = null;
            using(var Context = new NorthwindEntities())
            {
                result = Context.Products.ToList();
            }
            return result;
        }

        List<Product> Products = new List<Product>
        {
            new Product{ProductID=1, ProductName="Cacao", UnitPrice=150, UnitsInStock=12},
            new Product{ProductID=2, ProductName="Azucar", UnitPrice=15, UnitsInStock=10},
            new Product{ProductID=3, ProductName="Coca-Cola", UnitPrice=27, UnitsInStock=25},
            new Product{ProductID=4, ProductName="Mango", UnitPrice=20, UnitsInStock=40},
            new Product{ProductID=5, ProductName="Aguacate", UnitPrice=200, UnitsInStock=15}
        };
    }
}
