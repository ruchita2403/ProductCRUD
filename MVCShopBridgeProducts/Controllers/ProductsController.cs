using MVCShopBridgeProducts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MVCShopBridgeProducts.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            IEnumerable<mvcProductsModel> productlist;
            HttpResponseMessage response = GlobalVriables.WebapiClient.GetAsync("Product").Result;
            productlist = response.Content.ReadAsAsync<IEnumerable<mvcProductsModel>>().Result;
            return View(productlist);
            
        }
    }
}