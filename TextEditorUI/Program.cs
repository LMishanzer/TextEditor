using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextEditorBussLog;

namespace TextEditorUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            EditorForm mainEditor = new EditorForm();
            FileManager manager = new FileManager();
            MessageService messageService = new MessageService();
            MainPresenter mainPresenter = new MainPresenter(manager, mainEditor,
                messageService);

            Application.Run(mainEditor);
        }
    }
}
