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

    public ActionResult Index()
    {
      return View(_db.Courses.ToList());
    }
    
    public ActionResult Details(int id)
    {
      Course thiCourse = _db.Courses
              .Include(course => course.Students)
              .ThenInclude(join =>join.Student)
              .FirstOrDefault(course => course.CourseId == id);
      return View(thiCourse);
    }

    public ActionResult Create()
    {
      // ViewBag.StudentId = new SelectList(_db.Students, "StudentId", "LastName");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Course course)
    {
      _db.Courses.Add(course);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Edit(int id)
    {
      var thisCourse = _db.Courses.FirstOrDefault(courses => courses.CourseId == id);
      // ViewBag.StudentId = new SelectList(_db.Students, "StudentId", "LastName");
      return View(thisCourse);
    }

    [HttpPost]
    public ActionResult Edit(Course course)
    {
      // if (StudentId != 0)
      // {
      //   _db.CourseStudents.Add(new CourseStudent { StudentId = StudentId, CourseId = course.CourseId });
      // }
      _db.Entry(course).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    // public ActionResult Delete
  }
}