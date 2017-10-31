using Model.Dao;
using Model.EF;
using OnlineShop.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class UserController : BaseController
    {
        // GET: Admin/User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create(Account account)
        {
            var dao = new UserDao();
            var encryptedMd5Pas = Encryption.MD5Hash(account.Password);
            account.Password = encryptedMd5Pas;
            long id = dao.Insert(account);
            if (id > 0)
            {
                return RedirectToAction("Index", "User");
            }else
            {
                ModelState.AddModelError("", "Thêm User thành công");
            }
            return View("Index");
        }
    }
}