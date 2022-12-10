using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContentController : Controller
    {
        ContentManager cm = new ContentManager(new EfContentDal());
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetAllContent(string p)
        {

            if (!string.IsNullOrEmpty(p))
            {
                var values = cm.GetListByWords(p);
                return View(values);
            }
            else
            {
                var allvalues = cm.GetList();
                return View(allvalues);

            }


        }
        public ActionResult ContentByHeading(int id)
        {
            var values = cm.GetListByHeadingID(id);
            return View(values);
        }
    }
}