using Guna.UI2.WinForms;

namespace OnlineLearningManagementSystemApp.Utils
{
    public class GunaMessageDialogUtils
    {

        // Show information dialog
        public static void PrepareShowInformation(Guna2MessageDialog guna2MessageDialog, string message, string caption = "Information")
        {
            guna2MessageDialog.Buttons = MessageDialogButtons.OK;
            guna2MessageDialog.Icon = MessageDialogIcon.Information;
            guna2MessageDialog.Show(message, caption);
        }

        // Show warning dialog
        public static void PrepareShowWarning(Guna2MessageDialog guna2MessageDialog, string message, string caption = "Warning")
        {
            guna2MessageDialog.Buttons = MessageDialogButtons.OK;
            guna2MessageDialog.Icon = MessageDialogIcon.Warning;
            guna2MessageDialog.Show(message, caption);
        }

        // Show error dialog
        public static void PrepareShowError(Guna2MessageDialog guna2MessageDialog, string message, string caption = "Error")
        {
            guna2MessageDialog.Buttons = MessageDialogButtons.OK;
            guna2MessageDialog.Icon = MessageDialogIcon.Error;
            guna2MessageDialog.Show(message, caption);
        }

        // Show confirmation dialog and return the DialogResult
        public static void PrepareShowConfirmation(Guna2MessageDialog guna2MessageDialog, string message, string caption = "Confirmation")
        {
            guna2MessageDialog.Buttons = MessageDialogButtons.YesNo;
            guna2MessageDialog.Icon = MessageDialogIcon.Question;
            guna2MessageDialog.Show(message, caption);
        }
    }
}
