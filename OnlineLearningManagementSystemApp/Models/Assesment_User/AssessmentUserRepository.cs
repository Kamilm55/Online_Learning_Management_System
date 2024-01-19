using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningManagementSystemApp.Models
{
    internal class AssessmentUserRepository:IAssessmentUserRepository
    {
        private readonly dbEntities dbEntities;

        public AssessmentUserRepository()
        {
            dbEntities = new dbEntities();
        }

        public Assessment_User GetById(long assessmentUserId)
        {
            return dbEntities.Assessment_User.FirstOrDefault(au => au.AssessmentUserID == assessmentUserId);
        }

        public List<Assessment_User> GetByUserId(long userId)
        {
            return dbEntities.Assessment_User.Where(au => au.UserID == userId).ToList();
        }

        public List<Assessment_User> GetByAssessmentId(long assessmentId)
        {
            return dbEntities.Assessment_User.Where(au => au.AssessmentID == assessmentId).ToList();
        }

        public List<Assessment_User> GetAll()
        {
            return dbEntities.Assessment_User.ToList();
        }

        public void Add(Assessment_User assessmentUser)
        {
            dbEntities.Assessment_User.Add(assessmentUser);
            dbEntities.SaveChanges();
        }

        public void Delete(long assessmentUserId)
        {
            Assessment_User assessmentUser = GetById(assessmentUserId);

            if (assessmentUser != null)
            {
                dbEntities.Assessment_User.Remove(assessmentUser);
                dbEntities.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("Assessment user not found.");
            }
        }

        public void UpdateGrade(string newGrade, long assessmentUserId)
        {
            Assessment_User assessmentUser = GetById(assessmentUserId);

            if (assessmentUser != null)
            {
                assessmentUser.Grade = newGrade;
                dbEntities.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("Assessment user not found.");
            }

        }


    }
}
