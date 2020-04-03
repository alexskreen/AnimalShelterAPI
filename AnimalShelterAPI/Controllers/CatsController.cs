using Microsoft.AspNetCore.Mvc;
using AnimalShelterAPI.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace AnimalShelterAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CatsController : Controller
  {
    private readonly AnimalShelterAPIContext _db;

    public CatsController(AnimalShelterAPIContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult<ICollection<Cat>> Get(string name, int age, string breed)
    {
      var query = _db.Cats.AsQueryable();

      if (age != 0)
      {
        query = query.Where(entry => entry.Age == age);
      }

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (breed != null)
      {
        query = query.Where(entry => entry.Breed == breed);
      }

      return query.ToList();
    }
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Cat cat)
    {
      _db.Cats.Add(cat);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}