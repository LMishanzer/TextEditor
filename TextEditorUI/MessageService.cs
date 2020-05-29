using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditorUI
{
    public interface IMessageService
    {
        void ShowMessage(string message);
        void ShowError(string message);
        void ShowExclamation(string message);
    }

    class MessageService : IMessageService
    {
        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Message", MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        public void ShowExclamation(string message)
        {
            MessageBox.Show(message, "Exclamation", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }
    }
}
