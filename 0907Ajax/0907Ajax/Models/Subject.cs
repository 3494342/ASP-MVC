using System;
using System.Collections.Generic;
using System.Web;
namespace _0907Ajax.Models
{
    public class Subject
    {
        public int CourseId { get; set; }
        public string SubjectName { get; set; }
        public static IEnumerable<Subject> GetSubjects()
        {
            List<Subject> subject = new List<Subject>()
            {
                new Subject() {CourseId = 1,SubjectName = "math"},
                new Subject() {CourseId = 1,SubjectName = "m"},

                new Subject() {CourseId = 2,SubjectName = "Chinses"},
                new Subject() {CourseId = 2,SubjectName = "c"},

                new Subject() {CourseId = 3,SubjectName = "English"},
                new Subject() {CourseId = 3,SubjectName = "e"},
            };
            return subject;
        }
    }
}