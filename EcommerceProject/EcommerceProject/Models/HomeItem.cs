using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceProject.Models
{
    public class HomeItem
    {
        public int ProductID { get; set; }
        public string ProductName;
        public string ProductPrice;
        public string ProductImage;
        public string Screen;
        public string OS;
        public string CPU;
        public string RAM;
        public string InternalStorage;
    }
}