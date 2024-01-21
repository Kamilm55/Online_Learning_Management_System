using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningManagementSystemApp.Models
{
    public class AssessmentUserDetails
    {
        public long AssessmentUserID { get; set; }
        public string AssessmentTitle { get; set; }
        public string CourseTitle { get; set; }
        public string Username { get; set; }
        public string Grade { get; set; }
        public DateTime DueDate { get; set; }
    }

}
