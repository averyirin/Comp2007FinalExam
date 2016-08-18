﻿using System;
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
    public class AlbumsController : Controller
    {
        private MVCMusicStoreContext db = new MVCMusicStoreContext();

        // GET: Albums
        public async Task<ActionResult> Index()
        {
            var albums = db.Albums.Include(a => a.Artist).Include(a => a.Genre);
            return View(await albums.ToListAsync());
        }
    }
}
