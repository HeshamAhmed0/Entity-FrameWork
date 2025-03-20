﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Session03.Models
{
    [PrimaryKey(nameof(StdId),nameof(CrsId))]
    public  class StudentCourse
    {
        [ForeignKey(nameof(Student))]
        public int StdId { get; set; }
        [ForeignKey(nameof(Course))]
        public int CrsId { get; set; }
        public int Grade {  get; set; }
        public virtual Student Student { get; set; } = null!;
        public virtual Course Course { get; set; } = null!;


    }
}
