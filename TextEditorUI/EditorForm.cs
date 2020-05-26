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
    public interface IMainForm
    {
        string filePath { get; set; }
        string content { get; set; }
        void SetCharactersCount(int count);
        event EventHandler FileOpenClick;
        event EventHandler FileSaveClick;
        event EventHandler FileSaveAsClick;
    }

    public partial class EditorForm : Form, IMainForm
    {
        public EditorForm()
        {
            InitializeComponent();
        }

        public string filePath { get; set; }
        public string content 
        { 
            get
            {
                return textField.Text;
            }
            set
            {
                content = value;
            }
        }

        public void SetCharactersCount(int count)
        {
            charCount.Text = count.ToString();
        }

        public event EventHandler FileOpenClick;
        public event EventHandler FileSaveClick;
        public event EventHandler FileSaveAsClick;
    }
}
