using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVCApp.Controllers
{
    public class TodolistController : Controller
    {
        //
        // GET: /Todolist/

        public ActionResult Index()
        {
            return View();
        }

    }
}
