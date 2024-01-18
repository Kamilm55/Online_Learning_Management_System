using Guna.UI2.WinForms;
using OnlineLearningManagementSystemApp.Models;
using OnlineLearningManagementSystemApp.Presenters;
using OnlineLearningManagementSystemApp.Utils;
using OnlineLearningManagementSystemApp.Views;
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
    public partial class Login : Form , ILoginView
    {
       
        /* private IUserRepository userRepository ;
private ICourseRepository courseRepository;
private IEnrollmentRepository enrollmentRepository;*/

        public Login()
        {
            InitializeComponent();
         /*   userRepository = new UserRepository();
            courseRepository = new CourseRepository();
            enrollmentRepository = new EnrollmentRepository();*/
        }

       public string Email { get ; set ; }
       public string Password { get ; set; }

        // Events to be handled by the presenter
        public event EventHandler LoginButtonClicked;

        private void Login_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            // Assuming you have an instance of LoginRegisterPresenter in your class
            var presenter = new LoginRegisterPresenter(this);

            this.StartPosition = FormStartPosition.CenterScreen;

            // Subscribe to view events
            LoginButtonClicked += presenter.OnLoginButtonClicked;
        }

       /* private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Notify the presenter that login button is clicked
            LoginButtonClicked?.Invoke(this, EventArgs.Empty);
        }*/

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void loginEmailTextBox_TextChanged(object sender, EventArgs e)
        {
            Debug.WriteLine(loginEmailTextBox.Text);
        }

        private void loginSubmitBtn_Click(object sender, EventArgs e)
        {
            ShowMessage(loginEmailTextBox.Text);
        }

        private void linkToRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }

        private void test_TextChanged(object sender, EventArgs e)
        {
            Debug.WriteLine(test.Text);
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /*private void loginEmailTextBox_TextChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("changes");
            Email = loginEmailTextBox.Text;
            //  Password = guna2TextBox2.Text;
            Debug.WriteLine(loginEmailTextBox.Text);
            Debug.WriteLine(Email + " " + Password);
        }*/









        //
        /*
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
                   *//* Enrollment  enrollment = new Enrollment();
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
        *//*


        // MessageBox.Show("Data added successfully.");
    }


    private void LoginBtn_Click(object sender, EventArgs e)
    {
      *//*  userName = textBox1.Text;
        password = textBox2.Text;*//*

      //  login(userName, password); // inside try-catch make login user

    }

    private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void guna2TextBox2_TextChanged(object sender, EventArgs e)
    {

    }*/
    }
}
