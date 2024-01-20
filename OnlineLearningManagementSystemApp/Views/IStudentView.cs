using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningManagementSystemApp.Views
{
    public interface IStudentView : IView
    {
        void BindAllCourses(List<Course> allCourses);
        void BindEnrolledCourses(List<Course> enrolledCourses);
        void ClearTextboxes();
    }
}
