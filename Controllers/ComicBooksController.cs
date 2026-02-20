using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnepieceBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
       /* public ContentResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
            {
                return Redirect("/");
            }
            return Content("Hello from the ComicBooksController!");
        }

        private ContentResult Redirect(string v)
        {
            throw new NotImplementedException();
        }*/

        public ActionResult Detail()
        {
            /*if (DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
            {
                return Redirect("/");
            }
            return Content("Hello from the ComicBooksController!");*/
            return View();
        }
    }
}