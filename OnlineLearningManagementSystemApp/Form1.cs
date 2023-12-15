using OnlineLearningManagementSystemApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OnlineLearningManagementSystemApp
{
    public partial class Form1 : Form
    {
        private IUserRepository userRepository ;
        private ICourseRepository courseRepository;
        private IEnrollmentRepository enrollmentRepository;
        private String userName;
        private String password;

        public Form1()
        {
            InitializeComponent();
            userRepository = new UserRepository();
            courseRepository = new CourseRepository();
            enrollmentRepository = new EnrollmentRepository();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            User userAdmin = userRepository.GetByUserName("Kamil");
            User userStudent = userRepository.GetByEmail("kamil@Student");
            Course course = courseRepository.GetById(1);
            //Test Code

            foreach (var item in enrollmentRepository.GetByCourseId(course.CourseID))
            {
                Debug.WriteLine(item.StudentID);
            }
           
            //enroll course
           /* Enrollment  enrollment = new Enrollment();
            enrollment.StudentID = userStudent.UserID;
            enrollment.CourseID = course.CourseID;
            enrollment.EnrollmentDate = DateTime.Now;

            try
            {
                enrollmentRepository.Add(enrollment);

            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }*/

            /*Course course = new Course();
            course.Title = "data structures";
            course.Description = "Desc";
            course.InstructorID = userAdmin.UserID;

            try
            {
                 courseRepository.Add(course);
                
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }*/
            /*
                        User user = new User(); 

                        user.Username = "Samir";
                        user.Email = "samir@admin";
                        user.Password = "kamilAdmin";
                        user.Role = "Student";

                        try
                        {
                            //  userRepository.Add(user);
                            userRepository.UpdateByEmail("kamil@admin",6);
                        }
                        catch (InvalidOperationException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
            */


            // MessageBox.Show("Data added successfully.");
        }


        private void LoginBtn_Click(object sender, EventArgs e)
        {
            userName = textBox1.Text;
            password = textBox2.Text;

          //  login(userName, password); // inside try-catch make login user

        }
    }
}
