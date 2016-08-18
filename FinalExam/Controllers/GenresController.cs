/***
 * Author: Irin Avery
 * Student Number: 200260949 
 * Date	Modified: Aug 18 2016
 * Short Version History: Removed Create, Edit, Delete and Details View
 * Description: A Genre controller that directs over to the list of all the genres
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FinalExam.Models;

namespace FinalExam.Controllers
{
    public class GenresController : Controller
    {
        private MVCMusicStoreContext db = new MVCMusicStoreContext();

        // GET: Genres
        public async Task<ActionResult> Index()
        {
            return View(await db.Genres.ToListAsync());
        }

    }
}
