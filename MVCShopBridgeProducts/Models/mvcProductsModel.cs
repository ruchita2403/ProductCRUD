using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCShopBridgeProducts.Models
{
    public class mvcProductsModel
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> Quantity { get; set; }
    }
}