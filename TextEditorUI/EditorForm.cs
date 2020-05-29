using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditorUI
{
    public interface IEditorForm
    {
        string filePath { get; set; }
        string content { get; set; }
        void SetCharactersCount(int count);
        event EventHandler FileOpenClick;
        event EventHandler FileSaveClick;
        event EventHandler ContentChanged;
    }

    public partial class EditorForm : Form, IEditorForm
    {
        public EditorForm()
        {
            InitializeComponent();

            fileOpen.Click += fileOpen_Click;
            fileSave.Click += FileSave_Click;
            fileSaveAs.Click += FileSaveAs_Click;
            textField.TextChanged += TextField_TextChanged;
        }

        #region EventsUsing
        private void TextField_TextChanged(object sender, EventArgs e)
        {
            if (ContentChanged != null)
                ContentChanged(sender, e);
        }

        private void FileSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Text file|*.txt";
            fileDialog.DefaultExt = "txt";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = fileDialog.FileName;

                if (FileSaveClick != null)
                    FileSaveClick(sender, e);
            }
        }

        private void FileSave_Click(object sender, EventArgs e)
        {
            if (filePath == null)
            {
                FileSaveAs_Click(sender, e);
            }
            else if (FileSaveClick != null)
                FileSaveClick(sender, e);
        }

        void fileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "All|*.*|Text files|*.txt";
            
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = fileDialog.FileName;
                if (FileOpenClick != null)
                    FileOpenClick(sender, e);
            }
        }
        #endregion

        #region IEditorForm
        public string filePath { get; set; }
        public string content 
        { 
            get
            {
                return textField.Text;
            }
            set
            {
                textField.Text = value;
            }
        }

        public void SetCharactersCount(int count)
        {
            charCount.Text = count.ToString();
        }

        public event EventHandler FileOpenClick;
        public event EventHandler FileSaveClick;
        public event EventHandler ContentChanged;
        #endregion


    }
}
