using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCShopBridgeProducts.Models
{
    public class mvcProductsModel
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage="This field is reuired")]
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> Quantity { get; set; }
    }
}