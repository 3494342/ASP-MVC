using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _0907Ajax.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        internal static IEnumerable<Course> GetCourses()
        {
            List<Course> courses = new List<Course>()
            {
                new Course() {CourseId = 1,CourseName = "course1"},
                new Course() {CourseId = 2,CourseName = "course2"},
                new Course() {CourseId = 3,CourseName = "course3"},
            };
            return courses;
        }
    }
}