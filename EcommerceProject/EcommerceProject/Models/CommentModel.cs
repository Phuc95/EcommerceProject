using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceProject.Models
{
    public class CommentModel
    {
        public int userID { get; set; }
        public int productID { get; set; }
        public int page { get; set; }
        public string userName { get; set; }
        public string commentDate { get; set; }
        public string commentContent { get; set; }
    }
}