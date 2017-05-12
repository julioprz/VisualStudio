using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppMVC4.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            var Repository = new ModelCL.Repository();
            var Model = Repository.GetProducts();
            return View(Model);
        }
        // GET: Product
        public ActionResult Details(int id)
        {
            ActionResult result = null;
            var Repository = new ModelCL.Repository();
            var Model = Repository.GetProductByID(id);
            if(Model != null)
            {
                //result = Content(Model.ProductName);
                //result = View(Model);
                //result = View("Details2", Model);
                result = View("Details3", Model);
            }
            else
            {
                result = Content("Producto No encontrado!");
            }
            return result;
        }
    }
}