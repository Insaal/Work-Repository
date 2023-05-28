using System.ComponentModel;
using System.Windows;
using Rosneft.Helpers.Interfaces;

namespace Rosneft.Helpers
{
    public class DefaultDialogService : IDialogService
    {
        public void ShowMessage(string message, string titlemessage)
        {
            MessageBox.Show(message, titlemessage);
        }

        public bool Exit(string message, string titlemessage, CancelEventArgs e)
        {
            if (MessageBox.Show(message, titlemessage, MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                return true;
            return false;
        }

        public bool Close(string message, string titlemessage)
        {
            if (MessageBox.Show(message, titlemessage, MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                return true;
            else return false;
        }
    }
}