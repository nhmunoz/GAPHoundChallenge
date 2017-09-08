using GapHound.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GapHound.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult SolveMaze(HttpPostedFileBase file, InputModel model)
        {
            try
            {
                byte[] content;
                Business.MazeHound mh = new Business.MazeHound();
                if (file.ContentLength > 0)
                {
                    content = new byte[file.InputStream.Length];
                    file.InputStream.Read(content, 0, (int)file.InputStream.Length - 1);
                    if (mh.SolveMaze(System.Text.Encoding.UTF8.GetString(content), model.X1, model.Y1, model.X2, model.Y2, 5, 5))
                    {
                        return Json(new ResponseModel() { email = "norman.munoz@gmail.com", repo = "https://github.com/nhmunoz/GAPHoundChallenge", solution = mh.Path });
                    }
                }
                return Json(new ResponseModel() { email = "norman.munoz@gmail.com", repo = "https://github.com/nhmunoz/GAPHoundChallenge", solution = "" });
            }
            catch
            {
                return Json("Error solving maze.");
            }
        }
    }
}