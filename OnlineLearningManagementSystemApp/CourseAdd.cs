using OnlineLearningManagementSystemApp.Models;
using OnlineLearningManagementSystemApp.Utils;
using OnlineLearningManagementSystemApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineLearningManagementSystemApp
{
    public partial class CourseAdd : Form , IView
    {
        private readonly ICourseRepository courseRepository;
        private readonly long teacherId;

        public CourseAdd(ICourseRepository courseRepository, long teacherId)
        {
            InitializeComponent();
            this.courseRepository = courseRepository;
            this.teacherId = teacherId;
        }

        private void courseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.online_learning_management_system_dbDataSet);

        }

        private void CoursesCRUD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'online_learning_management_system_dbDataSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.online_learning_management_system_dbDataSet.Course);

        }

        private void CourseAddSubmitBtn_Click(object sender, EventArgs e)
        {
            // Gather information from the form
            string title = CourseAddTitleTextBox.Text;
            string description = CourseAddDescTextBox.Text;

            try
            {
                // Save the course to the database using the injected repository
                courseRepository.Add(new Course { Title = title, Description = description, InstructorID = teacherId });

                // Use your custom ShowInformation method for success
                ShowInformation("Course added successfully.");

                // Close the form after adding the course
                this.Close();
            }
            catch (Exception ex)
            {
                // Use your custom ShowError method for errors
                ShowError($"Error: {ex.Message}");
            }
        }

        //
        public void ShowInformation(string message, string caption = "Information")
        {
            GunaMessageDialogUtils.PrepareShowInformation(courseAddMessageDialog, message, caption);
        }

        public void ShowWarning(string message, string caption = "Warning")
        {
            GunaMessageDialogUtils.PrepareShowWarning(courseAddMessageDialog, message, caption);

        }

        public void ShowError(string message, string caption = "Error")
        {
            GunaMessageDialogUtils.PrepareShowError(courseAddMessageDialog, message, caption);

        }
    }
}
