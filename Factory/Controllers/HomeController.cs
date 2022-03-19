using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Factory.Models;

namespace Factory.Controllers
{
    public class HomeController : Controller
    {
    private readonly FactoryContext _db;

    public HomeController(FactoryContext db)
    {
      _db = db;
    }

      [HttpGet("/")]
      public ActionResult Index()
      {
        ViewBag.PageTitle = "Welcome to Dr. Sillystringz's Factory";
        var model = new IndexDisplay();
        model.Engineers = _db.Engineers.ToList();
        model.Machines = _db.Machines.ToList();
        return View(model);
      }
    }
}