using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StrongView.Models
{
    public class Student
    {
        public string Name { get; internal set; }
        public string Number { get; internal set; }
        public int Rollno { get; internal set; }
    }
}