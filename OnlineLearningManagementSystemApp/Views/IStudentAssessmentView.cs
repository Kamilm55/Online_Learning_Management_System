using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningManagementSystemApp.Views
{
    public interface IStudentAssessmentView
    { 
        void BindAssessments(List<Assessment> assessments);
    }
}
