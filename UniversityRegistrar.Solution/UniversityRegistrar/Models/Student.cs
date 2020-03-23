using System;
using System.Collections.Generic;

namespace UniversityRegistrar.Models
{
  public class Student
  {
    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DOB { get; set; }
    public ICollection<CourseStudent> Courses { get; set; }
    public Student()
    {
      this.Courses = new HashSet<CourseStudent>();
    }

  }
}