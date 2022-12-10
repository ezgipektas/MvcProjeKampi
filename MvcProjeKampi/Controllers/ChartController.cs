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
        //public ActionResult CategoryChart()
        //{
        //    return Json(BlogList(),JsonRequestBehavior.AllowGet);
        //}
        //public List<CategoriesModel> BlogList()
        //{
        //    List<CategoriesModel> ct = new List<CategoriesModel>();
        //    using (var c=new Context())
        //    {
        //        c.Categories.Select(new )
        //    }
        //    ct.Add(new CategoriesModel()
        //    {
        //        CategoryName =c.Categories.Add() ,
        //        CategoryCount = 8


        //    });
        //    ct.Add(new CategoriesModel()
        //    {
        //        CategoryName = "Seyahat",
        //        CategoryCount = 4
        //    });
        //    ct.Add(new CategoriesModel()
        //    {
        //        CategoryName = "Teknoloji",
        //        CategoryCount = 7
        //    });
        //    ct.Add(new CategoriesModel()
        //    {
        //        CategoryName = "Spor",
        //        CategoryCount = 1
        //    });
        //    return ct;
        //}
    }
}