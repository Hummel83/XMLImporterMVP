using XMLImporter.Business.Events;
using XMLImporter.Business.Interfaces;

namespace XMLImporter.Business.Services
{
    public class FileService : IFileService
    {
        public event FileReaderMessageEventHandler FileReaderMessageSent;

        public void ReadFile(string path)
        {
            RaiseFileReaderMessageEvent("Read file started...");

            //todo read xml file
            throw new System.NotImplementedException();

            RaiseFileReaderMessageEvent("Read file finished...");
        }

        private void RaiseFileReaderMessageEvent(string message)
        {
            FileReaderMessageSent?.Invoke(this, new FileReaderMessageEventArgs(message));
        }
    }
}