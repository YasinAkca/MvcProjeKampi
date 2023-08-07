using BusinessLayer.Concrete;
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
        // GET: Content
        ContentManager cm = new ContentManager(new EfContentDal());
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ContentByHeading(int id)
        {
            var contentvalues = cm.GetListByHeadingID(id);
            Console.WriteLine(contentvalues);
            return View(contentvalues);
            
        }
        public ActionResult DeleteContent(int id)
        {
            var ContentValue = cm.GetByID(id);
            cm.ContentDelete(ContentValue);
            return RedirectToAction("Index");
        }
    }
}