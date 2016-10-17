using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceProject.Models
{
    public class CartItemModel
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public string productImage { get; set; }
        public string productColor { get; set; }
        public int productPrice { get; set; }
        public int productQuantity { get; set; }
    }
}