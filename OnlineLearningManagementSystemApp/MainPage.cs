using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineLearningManagementSystemApp
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'online_learning_management_system_dbDataSet.Course' table. You can move, or remove it, as needed.
           /* this.courseTableAdapter.Fill(this.online_learning_management_system_dbDataSet.Course);
*/
        }

        private void textBoxMain_TextChanged(object sender, EventArgs e)
        {
            Debug.WriteLine(textBoxMain.Text);
        }

        private void maintest_TextChanged(object sender, EventArgs e)
        {
            Debug.WriteLine(maintest.Text);
        }
    }
}
