using System;

namespace XMLImporter.WinFormsMVP.Events
{
    public delegate void FileSelectedEventHandler(object sender, FileSelectedEventArgs e);

    public class FileSelectedEventArgs : EventArgs
    {
        public string SelectedFilePath { get; private set; }

        public FileSelectedEventArgs(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentNullException(nameof(path));
            }

            this.SelectedFilePath = path;
        }
    }
}
