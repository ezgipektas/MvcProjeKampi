using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class AuthorizationController : Controller
    {
        AdminManager adm = new AdminManager(new EfAdminDal());
        // GET: Authorization
        public ActionResult Index()
        {   
            var values=adm.GetList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddAdmin()
        {
            return View();

        }
        [HttpPost]
        public ActionResult AddAdmin(Admin p)
        {
            adm.AdminAdd(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditAdmin(int id)
        {
            var value = adm.GetByID(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult EditAdmin(Admin p)
        {
            adm.AdminUpdate(p);
            return RedirectToAction("Index");
        }

    }
}