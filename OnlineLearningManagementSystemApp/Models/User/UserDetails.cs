using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningManagementSystemApp
{
    public class UserDetails
    {
        public long UserID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string CourseTitle { get; set; }
        public long EnrollmentID { get; set; }
    }
}
