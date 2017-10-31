using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShop.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Chưa nhập user name")]
        public string UserName { set; get; }

        [Required(ErrorMessage = "Chưa nhập password")]
        public string Password { set; get; }

        public bool RememberMe { set; get; }
    }
}