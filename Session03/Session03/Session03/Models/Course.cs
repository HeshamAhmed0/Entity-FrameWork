﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03.Models
{
    internal class Course
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public ICollection<StudentCourse> StudentCourses { get; set; }=new HashSet<StudentCourse>();
    }
}
