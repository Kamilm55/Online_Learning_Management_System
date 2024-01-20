using OnlineLearningManagementSystemApp.Business;
using OnlineLearningManagementSystemApp.Models;
using OnlineLearningManagementSystemApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningManagementSystemApp.Presenters
{
    internal class StudentPresenter
    {
        private readonly IStudentView view;
        private readonly IStudentBusinessService studentBusinessService;
        private readonly ICourseRepository courseRepository;

        public StudentPresenter(IStudentView view)
        {
            this.view = view;
            this.studentBusinessService = new StudentBusinessService();
            this.courseRepository = new CourseRepository();
        }

     
    }
}
