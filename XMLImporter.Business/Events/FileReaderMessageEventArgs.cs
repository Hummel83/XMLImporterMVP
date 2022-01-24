using System;

namespace XMLImporter.Business.Events
{
    public delegate void FileReaderMessageEventHandler(object sender, FileReaderMessageEventArgs e);

    public class FileReaderMessageEventArgs : EventArgs
    {
        public string Message { get; private set; }

        public FileReaderMessageEventArgs(string value)
        {
            this.Message = value;
        }
    }
}
