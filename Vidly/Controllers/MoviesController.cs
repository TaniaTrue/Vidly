﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //public ActionResult Details(int id)
        //{
        //    //var movie = _context.Movies.Include(m=>m.Genre)

        //    if (movie == null)
        //        return HttpNotFound();

        //    return View(movie);

        //}
    }
}