using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValeraMaps.Models;

namespace ValeraMaps.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        public JsonResult GetData()
        {
            // создадим список данных
            List<People> pp = new List<People>();

            pp.Add(
                new People {
                    name="Валера",
                    numform="791",
                    GeoLat = 37.608644,
                    GeoLong = 55.75226,
                    info ="Валера вместо прохождения Морфлота гуляет по Александровскому саду",
                    photolink= "http://www.videosharp.info/users/791/avatar/791_avatar_1.png"

                }
                
                );

            pp.Add(
               new People
               {
                   name = "Оля Муза",
                   numform = "24",
                   GeoLat = 37.610489,
                   GeoLong = 55.752308,
                   info = "Оля пополняет багаж знаний в библиотеке им Ленина",
                   photolink = "http://www.videosharp.info/users/24/avatar/24_avatar_1.jpg"

               }

               );


            return Json(pp, JsonRequestBehavior.AllowGet);
        }
    }
}