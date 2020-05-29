using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextEditorBussLog;

namespace TextEditorUI
{
    class MainPresenter
    {
        private readonly IFileManager manager;
        private readonly IEditorForm view;
        private readonly IMessageService messageService;

        private string currentFilePath;

        public MainPresenter(IFileManager fileManager, IEditorForm editorForm,
            IMessageService messageService)
        {
            manager = fileManager;
            view = editorForm;
            this.messageService = messageService;

            view.ContentChanged += EditorForm_ContentChanged;
            view.FileOpenClick += View_FileOpenClick;
            view.FileSaveClick += View_FileSaveClick;

            view.SetCharactersCount(0);
        }

        private void View_FileSaveClick(object sender, EventArgs e)
        {
            try
            {
                string content = view.content;
                currentFilePath = view.filePath;

                if (!manager.IsExists(currentFilePath))
                {
                    manager.FileCreate(currentFilePath);
                }

                manager.SaveFile(content, currentFilePath);
                messageService.ShowMessage("File saved!");
            }
            catch(Exception ex)
            {
                messageService.ShowMessage(view.filePath);
                messageService.ShowError(ex.Message);
            }
        }

        private void View_FileOpenClick(object sender, EventArgs e)
        {
            try
            {
                string path = view.filePath;

                if (!manager.IsExists(path))
                {
                    messageService.ShowExclamation("File doesn't exist");
                    return;
                }

                currentFilePath = path;

                string content = manager.GetContent(path);
                int count = manager.GetCharactersCount(content);

                view.content = content;
                view.SetCharactersCount(count);
            }
            catch(Exception)
            {
                messageService.ShowError("Something went wrong!");
            }
        }

        private void EditorForm_ContentChanged(object sender, EventArgs e)
        {
            view.SetCharactersCount(view.content.Length);
        }
    }
}
