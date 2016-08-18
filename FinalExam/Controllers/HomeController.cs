/***
 * Author: Irin Avery
 * Student Number: 200260949 
 * Date	Modified: Aug 18 2016
 * Short Version History: Scaffolded Home Controller
 * Description: A Home controller that directs to the home, about and contact views
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalExam.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}