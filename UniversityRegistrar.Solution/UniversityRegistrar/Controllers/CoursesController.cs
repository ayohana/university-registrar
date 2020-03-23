using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using UniversityRegistrar.Models;
using System.Collections.Generic;
using System.Linq;

namespace UniversityRegistrar.Controllers
{
  public class CoursesController : Controller
  {
    private readonly UniversityRegistrarContext _db;

    public CoursesController(UniversityRegistrarContext db)
    {
      _db = db;
    }

    // public ActionResult Index()
    // {
    //   return View(_db.Items.ToList());
    // }


    // public ActionResult Details(int id)
    // {
    //   var thisItem = _db.Items
    //       .Include(item => item.Categories)
    //       .ThenInclude(join => join.Category)
    //       .FirstOrDefault(item => item.ItemId == id);
    //   return View(thisItem);
    // }

    //  public ActionResult Create()
    // {
    //   ViewBag.CategoryId = new SelectList(_db.Categories, "CategoryId", "Name");
    //   return View();
    // }

    // [HttpPost]
    // public ActionResult Create(Item item, int CategoryId)
    // {
    //   _db.Items.Add(item);
    //   if (CategoryId != 0)
    //   {
    //     _db.CategoryItem.Add(new CategoryItem() { CategoryId = CategoryId, ItemId = item.ItemId });
    //   }
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

    // public ActionResult AddCategory(int id)
    // {
    //   var thisItem = _db.Items.FirstOrDefault(items => items.ItemId == id);
    //   ViewBag.CategoryId = new SelectList(_db.Categories, "CategoryId", "Name");
    //   return View(thisItem);
    // }

    // [HttpPost]
    // public ActionResult AddCategory(Item item, int CategoryId)
    // {
    //   if (CategoryId != 0)
    //   {
    //     _db.CategoryItem.Add(new CategoryItem() { CategoryId = CategoryId, ItemId = item.ItemId });
    //   }
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

  }
}