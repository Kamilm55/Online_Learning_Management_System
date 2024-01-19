using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningManagementSystemApp.Models
{
    internal interface IAssessmentUserRepository
    {
        Assessment_User GetById(long assessmentUserId);
        List<Assessment_User> GetByUserId(long userId);
        List<Assessment_User> GetByAssessmentId(long assessmentId);
        List<Assessment_User> GetAll();
        void Add(Assessment_User assessmentUser);
        void Delete(long assessmentUserId);
        void UpdateGrade(string newGrade, long assessmentUserId);
        
    }
}
