using ContosoUniversity.DAL;
using ContosoUniversity.ViewModels;
using System.Linq;
using System.Web.Mvc;


namespace ContosoUniversity.Controllers
{
    public class MasterDetailController : Controller
    {
        private readonly SchoolContext db = new SchoolContext();

        public ActionResult Index()
        {
            var vm = db.Departments
                .Select(d => new DepartmentVM
                {
                    DepartmentID = d.DepartmentID,
                    Name = d.Name
                })
                .ToList();

            return View(vm);
        }

        public ActionResult LoadCourses(int departmentId)
        {
            var vm = db.Courses
                .Where(c => c.DepartmentID == departmentId)
                .Select(c => new CourseVM
                {
                    CourseID = c.CourseID,
                    Title = c.Title,
                    Credits = c.Credits
                })
                .ToList();

            return PartialView("_Courses", vm);
        }

        public ActionResult LoadEnrollments(int courseId)
        {
            var vm = db.Enrollments
                .Where(e => e.CourseID == courseId)
                .Select(e => new EnrollmentVM
                {
                    EnrollmentID = e.EnrollmentID,
                    StudentName = e.Student.FirstMidName + " " + e.Student.LastName,
                    Grade = e.Grade.ToString()
                })
                .ToList();

            return PartialView("_Enrollments", vm);
        }
    }
}
