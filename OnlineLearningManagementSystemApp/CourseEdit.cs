using OnlineLearningManagementSystemApp.Models;
using OnlineLearningManagementSystemApp.Utils;
using OnlineLearningManagementSystemApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OnlineLearningManagementSystemApp
{
    public partial class CourseEdit : Form, IView
    {
        private readonly ICourseRepository courseRepository;
        private readonly long teacherId;
        private long courseId;

        public CourseEdit(ICourseRepository courseRepository ,long teacherId)
        {
            InitializeComponent();

            // Initialize the repository
            this.courseRepository = courseRepository ?? throw new ArgumentNullException(nameof(courseRepository));
            this.teacherId = teacherId;
            // Load the course details for editing
            LoadCourseIds();
        }

        private void LoadCourseIds()
        {
            try
            {
                // Retrieve all course IDs
                List<long> courseIds = courseRepository.GetCourseIdsByInstructorId(teacherId);

                // Populate the ComboBox with course IDs
                courseIdComboBox.Items.AddRange(courseIds.Cast<object>().ToArray());
            }
            catch (Exception ex)
            {
                ShowError($"Error loading course IDs: {ex.Message}");
            }
        }

        private void courseIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update the selected courseId
            if (courseIdComboBox.SelectedItem != null && long.TryParse(courseIdComboBox.SelectedItem.ToString(), out long selectedCourseId))
            {
                courseId = selectedCourseId;

                // Load course details for the selected course ID
                LoadCourseDetails();
            }
        }

        private void LoadCourseDetails()
        {
            try
            {
                // Retrieve the course details based on the courseId
                Course course = courseRepository.GetById(courseId);

                // Populate the form controls with the retrieved course details
                if (course != null)
                {
                    CourseEditTitleTextBox.Text = course.Title;
                    CourseEditDescTextBox.Text = course.Description;
                }
                else
                {
                    // Handle the case where the course is not found
                    ShowError($"Course with ID {courseId} not found.");
                    this.Close(); // Close the form if the course is not found
                }
            }
            catch (Exception ex)
            {
                ShowError($"Error loading course details: {ex.Message}");
            }
        }

        private void CourseEditTitleBtn_Click(object sender, EventArgs e)
        {
            // Implement the logic to update the course title in the database
            string newTitle = CourseEditTitleTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(newTitle))
            {
                try
                {
                    courseRepository.UpdateTitle(newTitle, courseId);
                    ShowInformation("Course title updated successfully.");
                }
                catch (Exception ex)
                {
                    ShowError($"Error updating course title: {ex.Message}");
                }
            }
            else
            {
                ShowError("Please enter a valid course title.");
            }
        }

        private void CourseEditDescBtn_Click(object sender, EventArgs e)
        {
            // Implement the logic to update the course description in the database
            string newDescription = CourseEditDescTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(newDescription))
            {
                try
                {
                    courseRepository.UpdateDescription(newDescription, courseId);
                    ShowInformation("Course description updated successfully.");
                }
                catch (Exception ex)
                {
                    ShowError($"Error updating course description: {ex.Message}");
                }
            }
            else
            {
                ShowError("Please enter a valid course description.");
            }
        }

        // Other methods and event handlers...

        //
        public void ShowInformation(string message, string caption = "Information")
        {
            GunaMessageDialogUtils.PrepareShowInformation(CourseEditMessageDialog1, message, caption);
        }

        public void ShowWarning(string message, string caption = "Warning")
        {
            GunaMessageDialogUtils.PrepareShowWarning(CourseEditMessageDialog1, message, caption);
        }

        public void ShowError(string message, string caption = "Error")
        {
            GunaMessageDialogUtils.PrepareShowError(CourseEditMessageDialog1, message, caption);
        }
    }
}
