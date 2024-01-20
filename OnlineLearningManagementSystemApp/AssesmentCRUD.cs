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
    public partial class AssesmentCRUD : Form
    {
        public AssesmentCRUD()
        {
            InitializeComponent();
        }

        private void assessmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.assessmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.online_learning_management_system_dbDataSet);

        }

        private void AssesmentCRUD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'online_learning_management_system_dbDataSet.Assessment_User' table. You can move, or remove it, as needed.
            this.assessment_UserTableAdapter.Fill(this.online_learning_management_system_dbDataSet.Assessment_User);
            // TODO: This line of code loads data into the 'online_learning_management_system_dbDataSet.Assessment' table. You can move, or remove it, as needed.
            this.assessmentTableAdapter.Fill(this.online_learning_management_system_dbDataSet.Assessment);

        }
    }
}
