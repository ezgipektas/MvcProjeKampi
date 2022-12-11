using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using MvcProjeKampi.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcProjeKampi.Controllers;



namespace MvcProjeKampi.Controllers
{
    public class ChartController : Controller
    {
        Context c = new Context();
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CategoryChart()
        {
            return Json(BlogList(), JsonRequestBehavior.AllowGet);
            
        }
        public List<CategoriesModel> BlogList()
        {
            
            List<CategoriesModel> ct = new List<CategoriesModel>();
            using (var c = new Context())
            {

                ct=c.Categories.Select(x => new CategoriesModel()
                {
                    CategoryName = x.CategoryName,
                    CategoryCount =(x.Headings.Count())
                }).ToList();
                return ct;             
            }
        }
        public ActionResult Index2()
        {
            return View();
        }
        public ActionResult HeadingChart()
        {
            return Json(HeadingList(), JsonRequestBehavior.AllowGet);

        }
        public List<HeadingsModel> HeadingList()
        {

            List<HeadingsModel> hm = new List<HeadingsModel>();
            using (var c = new Context())
            {

                hm = c.Headings.Select(x => new HeadingsModel()
                {
                    HeadingName = x.HeadingName,
                    HeadingCount = x.Contents.Count()
                }).ToList();
                return hm;
            }
        }
    } 
}
    