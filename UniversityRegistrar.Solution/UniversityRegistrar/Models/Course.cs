using System;
using System.Collections.Generic;

namespace UniversityRegistrar.Models
{
  public class Course
  {
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public int CourseNumber { get; set; }
    public ICollection<CourseStudent> CourseStudents { get; set; }

    public Course()
    {
      this.CourseStudents = new HashSet<CourseStudent>();
    }

  }
}