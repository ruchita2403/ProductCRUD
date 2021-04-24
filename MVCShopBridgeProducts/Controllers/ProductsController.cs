using MVCShopBridgeProducts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using PagedList.Mvc;
using PagedList;

namespace MVCShopBridgeProducts.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index(string search, int? i)
        {
            IEnumerable<mvcProductsModel> productlist;
            HttpResponseMessage response = GlobalVriables.WebapiClient.GetAsync("Products").Result;
            productlist = response.Content.ReadAsAsync<IEnumerable<mvcProductsModel>>().Result;
            var product = from s in productlist
                           select s;
            if (!String.IsNullOrEmpty(search))
            {
                productlist = productlist.Where(s => s.Name.Contains(search)
                                       );
            }
            return View(productlist.ToPagedList(i ?? 1, 3));
            
        }
        public ActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)//when clicked on create new
                return View(new mvcProductsModel());

            else//to click on edit
            {
                HttpResponseMessage response = GlobalVriables.WebapiClient.GetAsync("Products/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<mvcProductsModel>().Result);
            }
        }
        [HttpPost]
        public ActionResult AddOrEdit(mvcProductsModel product)
        {
            if (product.ProductId == 0)//to create a new product and submit
            {
                HttpResponseMessage response = GlobalVriables.WebapiClient.PostAsJsonAsync("Products", product).Result;
                TempData["SuccessMessage"] = "Saved Successfully";
            }
            else//to update an existing product and submit
            {
                HttpResponseMessage response = GlobalVriables.WebapiClient.PutAsJsonAsync("Products/" + product.ProductId, product).Result;
                TempData["SuccessMessage"] = "Updated Successfully";
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVriables.WebapiClient.DeleteAsync("Products/" + id.ToString()).Result;
            TempData["SuccessMessage"] = "Deleted Successfully";
            return RedirectToAction("Index");
        }
    }
}