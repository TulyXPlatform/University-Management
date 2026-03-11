using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContosoUniversity.ViewModels;



namespace ContosoUniversity.ViewModels
{
    public class CourseVM
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
    }
}