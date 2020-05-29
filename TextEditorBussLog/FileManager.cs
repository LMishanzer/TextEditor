using System;
using System.Text;
using System.IO;

namespace TextEditorBussLog
{
    public interface IFileManager
    {
        string GetContent(string filePath);
        string GetContent(string filePath, Encoding encoding);
        void SaveFile(string content, string filePath);
        void SaveFile(string content, string filePath, Encoding encoding);
        int GetCharactersCount(string content);
        bool IsExists(string filePath);
        void FileCreate(string filePath);
    }

    public class FileManager : IFileManager
    {
        private readonly Encoding defaultEncoding = Encoding.GetEncoding(1250);

        public string GetContent(string filePath, Encoding encoding)
        {
            return File.ReadAllText(filePath, encoding);
        }

        public string GetContent(string filePath)
        {
            return GetContent(filePath, defaultEncoding);
        }

        public void SaveFile(string content, string filePath, Encoding encoding)
        {
            File.WriteAllText(filePath, content, encoding);
        }

        public void SaveFile(string content, string filePath)
        {
            SaveFile(content, filePath, defaultEncoding);
        }

        public int GetCharactersCount(string content)
        {
            return content.Length;
        }

        public bool IsExists(string filePath)
        {
            return File.Exists(filePath);
        }

        public void FileCreate(string filePath)
        {
            FileStream fs = File.Create(filePath);
            fs.Close();
        }
    }
}
