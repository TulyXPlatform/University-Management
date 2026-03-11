using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContosoUniversity.ViewModels;



namespace ContosoUniversity.ViewModels
{
    public class EnrollmentVM
    {
        public int EnrollmentID { get; set; }
        public string StudentName { get; set; }
        public string Grade { get; set; }
    }
}