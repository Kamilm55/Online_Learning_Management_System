using Guna.UI2.WinForms;
using OnlineLearningManagementSystemApp.Business;
using OnlineLearningManagementSystemApp.Models;
using OnlineLearningManagementSystemApp.Utils;
using OnlineLearningManagementSystemApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OnlineLearningManagementSystemApp
{
    public partial class StudentMainPage : Form, IView
    {
        private const string AllCourses = "All Courses";
        private readonly IStudentBusinessService studentBusinessService;
        private readonly ICourseRepository courseRepository;
        private readonly long exStudentId;

        public StudentMainPage(long userId)
        {
            InitializeComponent();
            studentBusinessService = new StudentBusinessService();
            courseRepository = new CourseRepository();
            exStudentId = userId;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            this.courseTableAdapter.Fill(this.online_learning_management_system_dbDataSet.Course);
        }

        private void studentDataComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTableType = studentDataComboBox.SelectedItem?.ToString();

            switch (selectedTableType)
            {
                case AllCourses:
                    LoadCourses(courseRepository.GetAll());
                    break;

                case "Enrolled Courses":
                    LoadCourses(studentBusinessService.GetEnrolledCoursesForUser(exStudentId));
                    break;

                default:
                    // Handle default case if necessary
                    break;
            }
        }


        private void CourseSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string filterText = CourseSearchTextBox.Text.Trim().ToLower();

            List<Course> courses = GetSelectedCourses();

            if (string.IsNullOrWhiteSpace(filterText))
            {
                courseBindingSource.DataSource = courses;
            }
            else
            {
                var filteredCourses = FilterCourses(courses, filterText);
                courseBindingSource.DataSource = filteredCourses;
            }
        }

        private void LoadCourses(List<Course> courses)
        {
            courseBindingSource.DataSource = courses;
        }

        private List<Course> GetSelectedCourses()
        {
            return AllCourses.Equals(studentDataComboBox.SelectedItem?.ToString())
                ? courseRepository.GetAll()
                : studentBusinessService.GetEnrolledCoursesForUser(exStudentId);
        }

        private List<Course> FilterCourses(List<Course> courses, string filterText)
        {
            return courses.Where(course =>
                course.Title.ToLower().Contains(filterText) ||
                course.InstructorID.ToString().Contains(filterText) ||
                course.Description.ToLower().Contains(filterText) ||
                course.CourseID.ToString().Contains(filterText)
            ).ToList();
        }

        private void Update()
        {
            string selectedTableType = studentDataComboBox.SelectedItem?.ToString();

            switch (selectedTableType)
            {
                case AllCourses:
                    LoadCourses(courseRepository.GetAll());
                    break;

                case "Enrolled Courses":
                    UpdateEnrolledCourses(exStudentId);
                    break;

                default:
                    // Handle default case if necessary
                    break;
            }
        }

        private void UpdateEnrolledCourses(long userId)
        {
            List<Course> courses;

            if (AllCourses.Equals(studentDataComboBox.SelectedItem?.ToString()))
            {
                // If "All Courses" is selected, load all courses
                courses = courseRepository.GetAll();
            }
            else
            {
                // If "Enrolled Courses" is selected, load enrolled courses
                courses = studentBusinessService.GetEnrolledCoursesForUser(userId);
            }

            LoadCourses(courses);
        }


        private void HandleException(Exception ex)
        {
            ShowError($"Error: {ex.Message}");
        }

        private void studentEnrollOrUnenrollCourseButton_Click(object sender, EventArgs e, bool enroll)
        {
            Guna2TextBox textBox = enroll ? studentEnrollCourseTextBox : studentUnenrollCourseTextBox;

            try
            {
                if (long.TryParse(textBox.Text, out long courseId))
                {
                    // Check if the course with the given ID exists
                    Course course = courseRepository.GetById(courseId);

                    if (course != null)
                    {
                        // Course exists, proceed with enrollment or unenrollment
                        if (enroll)
                            studentBusinessService.EnrollCourse(exStudentId, courseId);
                        else
                            studentBusinessService.UnenrollCourse(exStudentId, courseId);

                        ShowInformation(enroll ? "Enrollment successful." : "Unenrollment successful.");
                    }
                    else
                    {
                        // Course does not exist
                        ShowError($"Course with ID {courseId} does not exist.");
                    }
                }
                else
                {
                    throw new FormatException($"Invalid {(enroll ? "student" : "course")} ID. Please enter a valid numeric value.");
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }

            Update();
        }
        
        private void studentEnrollCourseButton_Click(object sender, EventArgs e)
        {
            studentEnrollOrUnenrollCourseButton_Click(sender, e, true);
        }

        private void studentUnenrollCourseButton_Click(object sender, EventArgs e)
        {
            studentEnrollOrUnenrollCourseButton_Click(sender, e, false);
        }


        //
        private void assesmentPageLink_Click(object sender, EventArgs e)
        {
            NavigationUtils.NavigateToStudentAssessmentPage(this, exStudentId);
        }
        private void userProfileLink_Click(object sender, EventArgs e)
        {
            NavigationUtils.NavigateToUserProfile(this, exStudentId);
        }
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            NavigationUtils.Logout(this);
        }
        //
        public void ShowInformation(string message, string caption = "Information")
        {
            GunaMessageDialogUtils.PrepareShowInformation(StMainPageMessageDialog1, message, caption);
        }

        public void ShowWarning(string message, string caption = "Warning")
        {
            GunaMessageDialogUtils.PrepareShowWarning(StMainPageMessageDialog1, message, caption);
        }

        public void ShowError(string message, string caption = "Error")
        {
            GunaMessageDialogUtils.PrepareShowError(StMainPageMessageDialog1, message, caption);
        }
    }
}
