using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceProject.Models
{
    public class ProductDetailView
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public string productManufacturer { get; set; }
        public int productPrice { get; set; }
        public List<string> productImages { get; set; }
        public List<string> productColor { get; set; }
        public string Screen { get; set; }
        public string OS { get; set; }
        public int FrontCamera { get; set; }
        public Nullable<int> RearCamera { get; set; }
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string MemoryCard { get; set; }
        public string SIMCard { get; set; }
        public string Connection { get; set; }
        public string Battery { get; set; }
        public string InternalStorage { get; set; }
        public int Weight { get; set; }
    }
}