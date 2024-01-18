using Guna.UI2.WinForms;

namespace OnlineLearningManagementSystemApp.Utils
{
    public class GunaMessageDialogUtils
    {

        private Guna2MessageDialog guna2MessageDialog ;

        public GunaMessageDialogUtils()
        {
            this.guna2MessageDialog =  new Guna2MessageDialog();
            guna2MessageDialog.Style = MessageDialogStyle.Dark;
          
        }

        // Show information dialog
        public void ShowInformation(string message, string caption = "Information")
        {
            guna2MessageDialog.Show(message, caption);
            guna2MessageDialog.Buttons = MessageDialogButtons.OK;
            guna2MessageDialog.Icon = MessageDialogIcon.Information;
        }

        // Show warning dialog
        public void ShowWarning(string message, string caption = "Warning")
        {
            guna2MessageDialog.Show(message, caption);
            guna2MessageDialog.Buttons = MessageDialogButtons.OK;
            guna2MessageDialog.Icon = MessageDialogIcon.Warning;
        }

        // Show error dialog
        public void ShowError(string message, string caption = "Error")
        {
            guna2MessageDialog.Show(message, caption);
            guna2MessageDialog.Buttons = MessageDialogButtons.OK;
            guna2MessageDialog.Icon = MessageDialogIcon.Error;
        }

        // Show confirmation dialog and return the DialogResult
        public Guna2MessageDialog  ShowConfirmation(string message, string caption = "Confirmation")
        {
             guna2MessageDialog.Show(message, caption);
            guna2MessageDialog.Buttons = MessageDialogButtons.YesNo;
            guna2MessageDialog.Icon = MessageDialogIcon.Question;
            return guna2MessageDialog;
        }
    }
}
