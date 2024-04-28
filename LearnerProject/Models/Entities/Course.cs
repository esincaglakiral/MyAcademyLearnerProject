﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearnerProject.Models.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string ProgramLength { get; set; }
        public string Quota { get; set; }
        public bool Status { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }

        public int? TeacherId { get; set; }
        public virtual Category Category { get; set; }
        public virtual Teacher Teacher { get; set; }

        public List<Review> Reviews { get; set; }
        public List<CourseRegister> CourseRegisters { get; set; }
        public List<CourseVideo> CourseVideos { get; set; }




        // IEnumerable, List, ICollection, IList, IQueryable bunların arasındaki farkı araştırcaksın ödev
    }
}